using System;
using System.IO;
using System.IO.Enumeration;

class Questions
{
    static void Main()
    {
        string[] questions = System.IO.File.ReadAllLines(@"F:\Creative Projects\programming\C#\questions\question\txts\questions.txt");
        string[] answers = System.IO.File.ReadAllLines(@"F:\Creative Projects\programming\C#\questions\question\txts\answers.txt");

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
        }

        for (int i = 0; i < answers.Length; i++)
        {
            Console.WriteLine(answers[i]);
        }

    }
}