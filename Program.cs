using System;
using System.IO;

class Questions
{
    static void Main()
    {
        string[] sportQ = System.IO.File.ReadAllLines(@"F:\Creative Projects\programming\C#\questions\question\txts\sportQ.txt");
        foreach (string line in sportQ)
        {
            Console.WriteLine(line);
        }
    }
}