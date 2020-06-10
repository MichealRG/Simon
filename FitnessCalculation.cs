using System;
using System.Collections.Generic;
using System.Text;

namespace MSI_AEX
{
    public class FitnessCalculation
    {
        public static double[] fitness = new double[100];
        public static double massiveFit = 0;
        public static double[] HistroyOfFit = new double[1000];

        public static void CalculateFitness()
        {
            fitness = new double[100];
            for (int i = 0; i < PopulationGenerating.Populacja.Length; i++)
            {
                for (int j = 0; j < KeysWeight.keyWeight.Length; j++)
                {
                    fitness[i] += PopulationGenerating.PopulacjaForWeight[i][j] * KeysWeight.keyWeight[j];
                }
                massiveFit += fitness[i]; 
            }
        }
    }
}
