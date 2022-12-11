using System;
using System.IO;
using System.IO.Enumeration;

class Questions
{
    static void Main()
    {
        string[] questions = System.IO.File.ReadAllLines(@"F:\Creative Projects\programming\C#\questions\question\txts\questions.txt");
        string[] answers = System.IO.File.ReadAllLines(@"F:\Creative Projects\programming\C#\questions\question\txts\answers.txt");

        Console.WriteLine("Welcome to my console trivia application!\nHow many questions would you like today?");
        int usrChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(usrChoice);
    }
}