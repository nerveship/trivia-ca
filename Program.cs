using System;
using System.IO;
using System.IO.Enumeration;

class Questions
{
    static void Main()
    {
        string Qpath = "F:\\Creative Projects\\programming\\C#\\questions\\question\\txts\\questions";
        string Apath = "F:\\Creative Projects\\programming\\C#\\questions\\question\\txts\\answers";
        var Qfiles = Directory.GetFiles(Qpath);
        var Afiles = Directory.GetFiles(Apath);

        foreach (var file in Qfiles)
        {

        }

        foreach (var file in Afiles)
        {

        }
    }
}