using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MSI_AEX
{
    class WritingResults
    {

        public static void WriteResults()
        {
            for (int i = 1; i <= GenereteNewPopulation.t; i++)
            {
                Console.WriteLine("{0}:\t{1}", i, FitnessCalculation.HistroyOfFit[i - 1]);
            }
            for (int i = 0; i < PopulationGenerating.Populacja.Length; i++)
            {
                Console.WriteLine("{0}:\t{1}", i, FitnessCalculation.fitness[i]);
                for (int j = 0; j < PopulationGenerating.Populacja[i].Length; j++)
                {
                    if (j == 10 || j == 20)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(PopulationGenerating.Populacja[i][j]);
                }
                Console.WriteLine();
            }

            using (StreamWriter sw = File.AppendText("date.txt"))
            {
                sw.WriteLine("Pokolenie {0}:\r\n\t", GenereteNewPopulation.t - 2);
                for (int i = 0; i < PopulationGenerating.Populacja.Length; i++)
                {
                    sw.Write("Osobnik {0}:\r\n", i + 1);
                    for (int j = 0; j < PopulationGenerating.Populacja[i].Length; j++)
                    {
                        if (j == 0)
                            sw.Write("\t\t");
                        if (j == 10 || j == 20)
                            sw.Write("\r\n\t\t");
                        sw.Write(PopulationGenerating.Populacja[i][j]);
                    }
                    sw.Write("\r\nFitness: {0}", FitnessCalculation.fitness[i]);
                    sw.Write("\r\n");
                }
            }
        }
    }
}
