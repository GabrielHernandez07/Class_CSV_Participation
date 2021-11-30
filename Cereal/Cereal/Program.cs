using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] linesofData = File.ReadAllLines("Cereal_Data.txt");
                List<Cereal> CerealName = new List<Cereal>();
                string Cname = "";
                string Mname = "";
                double calories = 0;
                double cup = 0;
                string calNote = "";

                for (int i = 1; i < linesofData.Length; i++)
                {
                    string line = linesofData[i];
                    string[] partofLine = line.Split("|");
                    Cname = partofLine[0];
                    Mname = partofLine[1];
                    calories = Convert.ToDouble(partofLine[2]);
                    cup = Convert.ToDouble(partofLine[3]);

                        Cereal C = new Cereal();
                        C.Manufacturer = Mname;
                        C.Name = Cname;
                        C.Calories = calories;
                        C.Cups = cup;
                        CerealName.Add(C);
                }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cereals with a serving size less than or equal to 1, >>");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Cereal cereal in CerealName)
                {
                    if (cereal.Cups >=1)
                    {
                        Console.WriteLine(cereal);
                    }
                }
            Console.ForegroundColor = ConsoleColor.Green;  
            Console.WriteLine("Cereals with 100 calories or less. >>");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Cereal cereal in CerealName)
                {
                    if (cereal.Calories <= 100)
                    {
                        Console.WriteLine(cereal);
                    }

                }
           
        }
    }
}
