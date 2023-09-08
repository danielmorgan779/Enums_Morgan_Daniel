using System;
using System.IO;

namespace Enums_Morgan_Daniel
{

    enum Months //Used Enums for months.We give January a value of 1, and it assigs the rest of the months values chronologically
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Apr;
            int myBirthDay = 6;
            int myBirthYear = 2005;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";
            /// Use file method to place text, write text, copy text, and to see if specific file exists
            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            /// If the file is there, it copies it to the new file, if not it replaces with "myFile.txt"
            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }
            /// Appends the myBirthDate string to the new file, and prints all of the text from the file to the console
            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }   
}