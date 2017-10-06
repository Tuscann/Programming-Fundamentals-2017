using System;
class InstructionSet_broken
{
    static void Main()  // 100/100
    {
        string opCode = Console.ReadLine().ToUpper();
        long result = 0;

        while (opCode != "END")
        {
            string[] codeArgs = opCode.Split(' ');


            switch (codeArgs[0])
            {
                case "INC":
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    result = ++operandOne;
                    break;
                }
                case "DEC":
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    result = --operandOne;
                    break;
                }
                case "ADD":
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    long operandTwo = long.Parse(codeArgs[2]);
                    result = operandOne + operandTwo;
                    break;
                }
                case "MLA":
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    long operandTwo = long.Parse(codeArgs[2]);
                    result = (long)(operandOne * operandTwo);
                    break;
                }
            }
            opCode = Console.ReadLine().ToUpper();
            Console.WriteLine(result);
        }
    }
}