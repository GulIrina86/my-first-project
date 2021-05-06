using System;
using System.IO;
namespace SecondConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"E:\projects\Employees.csv";

            using (StreamReader sr = File.OpenText(path))
            {
                string input = null; 
                while ((input = sr.ReadLine()) != null)
                {

                    Console.WriteLine(input);
                }
            }
        }
    }
}