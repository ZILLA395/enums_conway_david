using System;
using System.ComponentModel.Design;
using System.IO;

namespace enums_conway_david
{    
    // a enum containing the months in a year
    enum Months
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


    internal class Program
    {
        static void Main(string[] args)
        {// an int that will determan what your birth month is
            int myBirthMonth = (int)Months.Dec;
            // a int that will determain you bith day
            int myBirthDay = 27;
            // a int that will detewrmain your birth year
            int myBirthYear = 2005;

            // a string that will impliment your ints to determan you birth date 
            string myBirthDate = $"My birthdayis on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            // a file that you will be able to add text to later
            File.WriteAllText("bingus.txt", "this is my bingus file!\n");
            Console.WriteLine(File.ReadAllText("bingus.txt"));

            //adds more text to the file
            File.AppendAllText("bingus.txt","woo more text yay!\n");
            Console.WriteLine(File.ReadAllText("bingus.txt"));

            //if the new file does not exist copys bingus to a new file
            if(!File.Exists("newfile.text"))
            {
                File.Copy("bingus.txt", "newFile.txt")
            }// if new file does exist replaces it with bingus.txt
            else 
            { 
            File.Replace("newFile.txt", "bingus.txt", "backupFile.txt")
            
            }


            File.AppendAllText("newfile.txt", myBirthDate)
        }   
    }
}