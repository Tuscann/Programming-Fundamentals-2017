using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

class HolidaysBetweenTwoDates
{

    static void Main()

    {
        var inputArray = Console.ReadLine().Split(' ').ToArray();
        var leftPartArr = new int[inputArray.Length / 4];
        var rightPartArr = new int[inputArray.Length / 4];
        var middlePartArr = new int[inputArray.Length / 2];

        ExtractMiddlePartOfTheInputArr(inputArray, middlePartArr, leftPartArr);

        ExtractLeftPartOfTheInputArr(inputArray, leftPartArr);

        ExtractRightPartfTheInputArr(inputArray, rightPartArr);
        // create new arr
        var bothLeftAndRightArr = new int[leftPartArr.Length + rightPartArr.Length];

        //Fill the new arr with left and right part of the main arr to use it further

        FillTheArr(leftPartArr, rightPartArr, bothLeftAndRightArr);


        int[] sumArr = new int[bothLeftAndRightArr.Length];

        for (int index = 0; index < sumArr.Length; index++)
        {
            sumArr[index] = middlePartArr[index] + bothLeftAndRightArr[index];
        }
        Console.WriteLine(string.Join(" ", sumArr));

    }

    private static void FillTheArr(int[] leftPartArr, int[] rightPartArr, int[] bothLeftAndRightArr)
    {
        for (int indexLeftArr = leftPartArr.Length - 1, countIndex = 0; indexLeftArr >= 0; indexLeftArr--)
        {
            bothLeftAndRightArr[countIndex] = leftPartArr[indexLeftArr];
            countIndex++;
        }

        for (int indexRightArr = rightPartArr.Length - 1, countIndex = leftPartArr.Length; indexRightArr >= 0; indexRightArr--)
        {
            bothLeftAndRightArr[countIndex] = rightPartArr[indexRightArr];
            countIndex++;
        }
    }

    private static void ExtractRightPartfTheInputArr(string[] inputArray, int[] rightPartArr)
    {
        for (int indexOfRightArr = 0; indexOfRightArr < rightPartArr.Length; indexOfRightArr++)
        {
            rightPartArr[indexOfRightArr] = int.Parse(inputArray[inputArray.Length - rightPartArr.Length + indexOfRightArr]);
        }
    }

    private static void ExtractLeftPartOfTheInputArr(string[] inputArray, int[] leftPartArr)
    {
        for (int indexOfLeftArr = 0; indexOfLeftArr < leftPartArr.Length; indexOfLeftArr++)
        {
            leftPartArr[indexOfLeftArr] = int.Parse(inputArray[indexOfLeftArr]);
        }
    }

    private static void ExtractMiddlePartOfTheInputArr(string[] inputArray, int[] middlePartOfTheArr, int[] leftPartOfTheArr)
    {
        for (int indexOfMiddleArr = 0; indexOfMiddleArr < middlePartOfTheArr.Length; indexOfMiddleArr++)
        {
            middlePartOfTheArr[indexOfMiddleArr] = int.Parse(inputArray[inputArray.Length - leftPartOfTheArr.Length - middlePartOfTheArr.Length + indexOfMiddleArr]);
        }
    }
}