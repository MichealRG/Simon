using System;
using System.Collections.Generic;
using System.Text;

namespace MSI_AEX
{
    public class GenereteNewPopulation
    {
        public static double[] fitnessMasterPosition = new double[100];
        public static char[][] newPopulation = new char[100][];
        public static double[][] newPopulationWeight = new double[100][];
        public static int t = 3;
        public static int number;

        public static void GenerateNewPopulation()
        {
            for (int i = 0; i < fitnessMasterPosition.Length; i++)
            {
                fitnessMasterPosition[i] = 2000;
            }

            number = 0;
            double tempFit;
            for (int j = 0; j < 20; j++)
            {
                newPopulationWeight[j] = new double[30];
                newPopulation[j] = new char[30];
                for (int k = 0; k < FitnessCalculation.fitness.Length; k++)
                {
                    if (fitnessMasterPosition[j] > FitnessCalculation.fitness[k])
                    {
                        tempFit = FitnessCalculation.fitness[k];
                        FitnessCalculation.fitness[number] = fitnessMasterPosition[j];
                        number = k;
                        fitnessMasterPosition[j] = tempFit;
                        for (int l = 0; l < PopulationGenerating.Populacja[k].Length; l++)
                        {
                            newPopulation[j][l] = PopulationGenerating.Populacja[k][l];
                            newPopulationWeight[j][l] = PopulationGenerating.PopulacjaForWeight[k][l];
                        }
                        FitnessCalculation.fitness[k] = 3000;
                    }
                }
            }
            for (int j = 20; j < 100; j++)
            {
                newPopulationWeight[j] = new double[30];
                newPopulation[j] = new char[30];
                for (int k = 0; k < ChildrenFitnessCalculation.fitnessChildren.Length; k++)
                {
                    if (fitnessMasterPosition[j] > ChildrenFitnessCalculation.fitnessChildren[k])
                    {
                        tempFit = ChildrenFitnessCalculation.fitnessChildren[k];
                        ChildrenFitnessCalculation.fitnessChildren[number] = fitnessMasterPosition[j];
                        number = k;
                        fitnessMasterPosition[j] = tempFit;
                        for (int l = 0; l < AEXCrossing.childrenPopulation[k].Length; l++)
                        {
                            newPopulation[j][l] = AEXCrossing.childrenPopulation[k][l];
                            newPopulationWeight[j][l] = AEXCrossing.childrenPopulationWeight[k][l];
                        }
                        FitnessCalculation.fitness[k] = 3000;
                    }
                }
            }

            for (int i = 0; i < PopulationGenerating.Populacja.Length; i++)
            {
                for (int j = 0; j < PopulationGenerating.Populacja[i].Length; j++)
                {
                    PopulationGenerating.Populacja[i][j] = newPopulation[i][j];
                    PopulationGenerating.PopulacjaForWeight[i][j] = newPopulationWeight[i][j];
                }
            }
            t++;
        }
    }
}