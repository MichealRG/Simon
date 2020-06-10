using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MSI_AEX
{
    public class SaveGenerationsToTextFile
    {
        public static void SaveToFile()
        {
            using (StreamWriter sw = File.AppendText("date.txt"))
            {
                sw.WriteLine("Zapis kolejnych pokoleń: ");
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
