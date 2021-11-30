using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    if (cup >= 1)
                    {
                        Cereal C = new Cereal();
                        C.Manufacturer = Mname;
                        C.Name = Cname;
                        C.Calories = calories;
                        C.Cups = cup;
                        CerealName.Add(C);
                    }
                }
                for (int i = 0; i < CerealName.Count; i++)
                {
                    if (calories <= 100)
                    {
                        calNote = ".This cereal has less than 100 calories.";
                    }
                    else
                    {
                        calNote = "";
                    }
                }
                Console.WriteLine("These cereals have a serving size of one or more.");
                foreach (var cereal in CerealName)
                {
                    Console.WriteLine(cereal + "" + calNote);
                }

            }
        }
    }
}
