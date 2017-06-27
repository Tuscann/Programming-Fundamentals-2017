using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        bool check = false;

        for (int first = a; first <= b; first++)
        {
            for (int secound = a; secound <= b; secound++)
            {
                for (int thuird = a; thuird <= b; thuird++)
                {
                    for (int four = a; four <= b; four++)
                    {
                        for (int five = a; five <= b; five++)
                        {
                            if (first < secound && secound < thuird && thuird < four && four < five)
                            {
                                Console.Write(first + " ");
                                Console.Write(secound + " ");
                                Console.Write(thuird + " ");
                                Console.Write(four + " ");
                                Console.WriteLine(five);
                                check = true;
                            }
                        }
                    }
                }
            }
        }

        if (check == false)
        {
            Console.WriteLine("No");
        }
    }
}