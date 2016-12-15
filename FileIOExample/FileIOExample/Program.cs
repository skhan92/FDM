using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\\Users\\suleman.khan\\Desktop\\myFile.txt
            Console.WriteLine("Please enter the path of the file:");
            string path = Console.ReadLine();

            try
            {
                CheckPathValidity(path);
            }
            catch (InvalidTextFilePathException)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Please enter the message to go in the file:");
            string message = Console.ReadLine();
            bool append = true;

            WriteToFile(path, message, append);

            string fileContents = ReadFromFile(path);

            Console.WriteLine(fileContents);
            Console.ReadLine();
        }

        private static void CheckPathValidity(string path)
        {
            if (path != "C:\\Users\\suleman.khan\\Desktop\\myFile.txt")
            {
                throw new InvalidTextFilePathException("Incorrect path given!");
            }
        }

        private static void WriteToFile(string path, string message, bool append)
        {
            StreamWriter writer = new StreamWriter(path);

           
            //true will append to the file, false will overwrite
            writer.WriteLine(message, append);
            
            writer.Close();
            
        }

        private static string ReadFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);

            StringBuilder stringBuilder = new StringBuilder();

            do
            {
                stringBuilder.Append(reader.ReadLine());
            } 
            while (reader.Peek() != -1); //while loop, as long as the reader can read a line, the do loop will continue

            return stringBuilder.ToString();

        }
    }
}
