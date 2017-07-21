using System;
using System.Linq;
public class StringDecryption
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        int[] givenArray = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        int[] result = givenArray.Where(x => x >= 65 && x <= 90).ToList().Skip(nums[0]).Take(nums[1]).ToArray();
        Console.WriteLine(string.Join(string.Empty, result.Select(x => (char)x)));
    }
}