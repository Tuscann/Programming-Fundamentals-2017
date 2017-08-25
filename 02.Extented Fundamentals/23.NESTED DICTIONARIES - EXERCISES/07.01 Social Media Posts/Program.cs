using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main() // 100/100
    {
        Dictionary<string, Dictionary<string, List<string>>> socialMediaPosts = new Dictionary<string, Dictionary<string, List<string>>>();
        string inputLine = Console.ReadLine();

        while (inputLine != "drop the media")
        {
            string[] inputData = inputLine.Split(' ').ToArray();
            string command = inputData[0];
            string postName = inputData[1];

            if (!socialMediaPosts.ContainsKey(postName))
            {
                socialMediaPosts[postName] = new Dictionary<string, List<string>>();
            }

            if (command == "like")
            {
                if (!socialMediaPosts[postName].ContainsKey("Like"))
                {
                    socialMediaPosts[postName]["Like"] = new List<string>();
                }

                socialMediaPosts[postName]["Like"].Add(command);
            }
            else if (command == "dislike")
            {
                if (!socialMediaPosts[postName].ContainsKey("Dislike"))
                {
                    socialMediaPosts[postName]["Dislike"] = new List<string>();
                }

                socialMediaPosts[postName]["Dislike"].Add(command);
            }
            else if (command == "comment")
            {
                string commenter = inputData[2];
                int combinedLenght = command.Length + postName.Length + commenter.Length + 3;
                string comment = inputLine.Substring(combinedLenght);

                if (!socialMediaPosts[postName].ContainsKey(commenter))
                {
                    socialMediaPosts[postName][commenter] = new List<string>();
                }

                socialMediaPosts[postName][commenter].Add(comment);
            }

            inputLine = Console.ReadLine();
        }

        foreach (KeyValuePair<string, Dictionary<string, List<string>>> post in socialMediaPosts)
        {
            int likes = 0;
            int dislikes = 0;
            Dictionary<string, List<string>> commenters = post.Value;

            foreach (KeyValuePair<string, List<string>> item in post.Value)
            {
                if (item.Key == "Like")
                {
                    likes = item.Value.Count;
                }
                else if (item.Key == "Dislike")
                {
                    dislikes = item.Value.Count;
                }
            }

            Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
            Console.WriteLine("Comments:");

            bool noComment = true;

            foreach (KeyValuePair<string, List<string>> comment in commenters)
            {
                if (comment.Key != "Like" && comment.Key != "Dislike")
                {
                    noComment = false;

                    foreach (string each in comment.Value)
                    {
                        Console.WriteLine($"*  {comment.Key}: {each}");
                    }
                }
            }
            if (noComment)
            {
                Console.WriteLine("None");
            }
        }
    }
}