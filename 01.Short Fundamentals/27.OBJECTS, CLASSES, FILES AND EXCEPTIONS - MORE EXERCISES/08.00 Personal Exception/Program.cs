using System;
class P08_PersonalException
{
    static void Main() // 100/100
    {
        try
        {
            while (true)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    throw new NegativeNumberException();
                }
                Console.WriteLine(num);
            }
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("My first exception is awesome!!!")
        {

        }
    }
}