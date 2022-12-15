﻿using System;
using System.Formats.Asn1;
using System.IO;
using System.IO.Enumeration;
using System.Threading.Tasks.Sources;

class Questions
{
    public static void Main()
    {
        int score = 0;
        int maxQuestions = 3;

        //Greets the user and prompts them for the number of questions they would like to answer
        Console.WriteLine("Welcome to my console trivia application!\nHow many questions would you like today?");
        int usrChoice = Convert.ToInt32(Console.ReadLine());

        while (usrChoice > maxQuestions)
        {
            Console.WriteLine($"Please choose between 1-{maxQuestions}");
            usrChoice = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Brilliant! Here come {usrChoice} questions!\n");

        //Waits before printing the first question
        Thread.Sleep(2000);

        //Loops over the amount of questions the user selected, starting with one and printing another when they answer
        for (int i = 0; i < usrChoice; i++)
        {
            string[] qu = { "Is Scotland part of the UK?", "Does WWE stand for World Wrestling Education?",
            "Are there 5 countries in the UK?"};
            string[] an = { "yes", "no", "no" };

            Console.WriteLine(qu[i]);
            string usrGuess = Console.ReadLine();
            if (usrGuess == an[i])
            {
                score++;
            }
        }
        Console.WriteLine($"You got {score} questions right! Well done!");
    }
}