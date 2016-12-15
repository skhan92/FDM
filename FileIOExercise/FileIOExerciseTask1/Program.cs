using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOExerciseTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\suleman.khan\\Desktop\\myFile.txt";
            //Console.WriteLine("Please enter a file path: ");
            //string path = Console.ReadLine();
            Console.WriteLine("Please choose a character :");
            string character = Console.ReadLine();

            StreamReader reader = new StreamReader(path);

            String line = reader.ReadToEnd();
            
            int count = 0;
        
            foreach (char ch in line)
                {
                    if (character == ch.ToString())
                    {
                        count++;
                    }
                    
                }
                Console.WriteLine(count);
                Console.ReadLine();
           }
     }
}

