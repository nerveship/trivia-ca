using System;
using System.IO;
using System.IO.Enumeration;

class Questions
{
    public static void Main()
    {
        Console.WriteLine("Welcome to my console trivia application!\nHow many questions would you like today?");
        int usrChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Brilliant! Here come {usrChoice} questions!\n");
        Thread.Sleep(2000);

        for (int i = 0; i < usrChoice; i++)
        {
            string[] questions = System.IO.File.ReadAllLines(@"F:\Creative Projects\programming\C#\questions\question\txts\questions.txt");
            string[] answers = System.IO.File.ReadAllLines(@"F:\Creative Projects\programming\C#\questions\question\txts\answers.txt");

            Random rand = new Random();
            int index = rand.Next(questions.Length);
            int ansrInput = 0;
            Console.WriteLine($"{questions[index]}");
        }
    }
}