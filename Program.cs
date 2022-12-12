using System;
using System.Formats.Asn1;
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
            string[] qu = { "Is Scotland part of the UK?", "Does WWE stand for World Wrestling Education?" };
            string[] an = { "yes", "no" };

            Random rand = new();
            int index = rand.Next(qu.Length);
          
            Console.WriteLine($"{qu[index]}");
            string usrGuess =  Console.ReadLine();
        }
    }
}