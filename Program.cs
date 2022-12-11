using System;
using System.IO;
using System.IO.Enumeration;

class Questions
{
    static void Main()
    {
        string path = "F:\\Creative Projects\\programming\\C#\\questions\\question\\txts\\";
        var files = Directory.GetFiles(path);

        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
    }
}