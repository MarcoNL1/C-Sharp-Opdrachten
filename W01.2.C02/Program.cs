using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        var fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);

        while (true)
        {
            Console.WriteLine("Really delete this file? (y/n)");
            var confirm = Console.ReadLine();

            if (confirm == "y")
            {
                fileList.Remove(whichFileToDelete);
                Console.WriteLine("File deleted");
                break;
            }
            else if (confirm == "n")
            {
                break;
            }

            else ;
            {
                continue;
            }
        }
    }
}