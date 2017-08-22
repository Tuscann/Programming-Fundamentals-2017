using System;
using System.Collections.Generic;
using System.Linq;
class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int NumberOfLegs { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }
}

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int IntelligenceQuotient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }
}

class Snake
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CrueltyCoefficient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }
}

class Animals
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        List<Dog> dogsList = new List<Dog>();
        List<Cat> catsList = new List<Cat>();
        List<Snake> snakesList = new List<Snake>();

        while (input != "I'm your Huckleberry")
        {
            string[] commandLine = input.Split(' ');

            if (commandLine[0] == "talk")
            {
                string animalName = commandLine[1];

                if (IsDog(dogsList, animalName))
                {
                    new Dog().ProduceSound();
                }
                else if (IsCat(catsList, animalName))
                {
                    new Cat().ProduceSound();
                }
                else if (isSnake(snakesList, animalName))
                {
                    new Snake().ProduceSound();
                }
            }
            else
            {
                string animal = commandLine[0];

                if (animal == "Dog")
                {
                    Dog dog = new Dog();
                    dog = GetNewDog(commandLine, dog);
                    dogsList.Add(dog);
                }
                else if (animal == "Cat")
                {
                    Cat cat = new Cat();
                    cat = GetNewCat(commandLine, cat);
                    catsList.Add(cat);
                }
                else if (animal == "Snake")
                {
                    Snake snake = new Snake();
                    snake = GetNewSnake(commandLine, snake);
                    snakesList.Add(snake);
                }
            }
            input = Console.ReadLine();
        }

        PrintDogs(dogsList);
        PrintCats(catsList);
        PrintSnakes(snakesList);
    }

    static Dog GetNewDog(string[] commandLine, Dog dog)
    {
        dog = new Dog()
        {
            Name = commandLine[1],
            Age = int.Parse(commandLine[2]),
            NumberOfLegs = int.Parse(commandLine[3])
        };
        return dog;
    }

    static Cat GetNewCat(string[] commandLine, Cat cat)
    {
        cat = new Cat()
        {
            Name = commandLine[1],
            Age = int.Parse(commandLine[2]),
            IntelligenceQuotient = int.Parse(commandLine[3])
        };
        return cat;
    }

    static Snake GetNewSnake(string[] commandLine, Snake snake)
    {
        snake = new Snake()
        {
            Name = commandLine[1],
            Age = int.Parse(commandLine[2]),
            CrueltyCoefficient = int.Parse(commandLine[3])
        };
        return snake;
    }

    static bool IsDog(List<Dog> dogsList, string animalName)
    {
        if (dogsList.Where(x => x.Name == animalName).Count() != 0)
        {
            return true;
        }
        return false;
    }

    static bool IsCat(List<Cat> catsList, string animalName)
    {
        if (catsList.Where(x => x.Name == animalName).Count() != 0)
        {
            return true;
        }
        return false;
    }

    static bool isSnake(List<Snake> snakesList, string animalName)
    {
        if (snakesList.Where(x => x.Name == animalName).Count() != 0)
        {
            return true;
        }
        return false;
    }

    static void PrintDogs(List<Dog> dogsList)
    {
        foreach (Dog dog in dogsList)
        {
            string name = dog.Name;
            int age = dog.Age;
            int numberOfLegs = dog.NumberOfLegs;

            Console.WriteLine($"Dog: {name}, Age: {age}, Number Of Legs: {numberOfLegs}");
        }
    }

    static void PrintCats(List<Cat> catsList)
    {
        foreach (Cat cat in catsList)
        {
            string name = cat.Name;
            int age = cat.Age;
            int iq = cat.IntelligenceQuotient;

            Console.WriteLine($"Cat: {name}, Age: {age}, IQ: {iq}");
        }
    }

    static void PrintSnakes(List<Snake> snakesList)
    {
        foreach (Snake snake in snakesList)
        {
            string name = snake.Name;
            int age = snake.Age;
            int cruelty = snake.CrueltyCoefficient;

            Console.WriteLine($"Snake: {name}, Age: {age}, Cruelty: {cruelty}");
        }
    }
}