using System;
using System.Collections.Generic;
using System.Text;

namespace MSI_AEX
{
    public class Selection
    {
        public static int[][] coupleOfParents = new int[100][];
        public static int nrOfParent1;
        public static int nrOfParent2;
        public static int nrOfParent3;
        public static int nrOfParent4;
        public static int nrOfParent5;
        public static Random rnd = new Random();

        public static void Selecting()
        {
            for (int i = 0; i < coupleOfParents.Length; i++)
            {
                coupleOfParents[i] = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    nrOfParent1 = rnd.Next(0, 100);
                    nrOfParent2 = rnd.Next(0, 100);
                    if (GenereteNewPopulation.t < 15) //coraz ciezej znalezc cos innego, zaczyna sie powtarzac
                    {
                        if (FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent2])
                            coupleOfParents[i][j] = nrOfParent2;
                        else
                            coupleOfParents[i][j] = nrOfParent1;
                    }
                    else if (GenereteNewPopulation.t >= 15 && GenereteNewPopulation.t < 25) //urozmaicenie
                    {
                        nrOfParent3 = rnd.Next(0, 100);
                        if (FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent2] && FitnessCalculation.fitness[nrOfParent3] > FitnessCalculation.fitness[nrOfParent2])
                            coupleOfParents[i][j] = nrOfParent2; //szukanie najmniejszego fitnessu
                        else if (FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent3] && FitnessCalculation.fitness[nrOfParent2] > FitnessCalculation.fitness[nrOfParent3])
                            coupleOfParents[i][j] = nrOfParent3;
                        else
                            coupleOfParents[i][j] = nrOfParent1;
                    }
                    else if ((GenereteNewPopulation.t >= 25 && (GenereteNewPopulation.t < 45))) //urozmaicenie
                    {
                        nrOfParent3 = rnd.Next(0, 100);
                        nrOfParent4 = rnd.Next(0, 100);
                        if (FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent2] && FitnessCalculation.fitness[nrOfParent3] > FitnessCalculation.fitness[nrOfParent2] && FitnessCalculation.fitness[nrOfParent4] > FitnessCalculation.fitness[nrOfParent2])
                            coupleOfParents[i][j] = nrOfParent2;
                        else if (FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent3] && FitnessCalculation.fitness[nrOfParent2] > FitnessCalculation.fitness[nrOfParent3] && FitnessCalculation.fitness[nrOfParent4] > FitnessCalculation.fitness[nrOfParent3])
                            coupleOfParents[i][j] = nrOfParent3;
                        else if (FitnessCalculation.fitness[nrOfParent2] > FitnessCalculation.fitness[nrOfParent1] && FitnessCalculation.fitness[nrOfParent3] > FitnessCalculation.fitness[nrOfParent1] && FitnessCalculation.fitness[nrOfParent4] > FitnessCalculation.fitness[nrOfParent1])
                            coupleOfParents[i][j] = nrOfParent1;
                        else
                            coupleOfParents[i][j] = nrOfParent4;
                    }
                    else if ((GenereteNewPopulation.t >= 45))
                    {
                        nrOfParent3 = rnd.Next(0, 100);
                        nrOfParent4 = rnd.Next(0, 100);
                        nrOfParent5 = rnd.Next(0, 100);
                        if (FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent2] && FitnessCalculation.fitness[nrOfParent3] > FitnessCalculation.fitness[nrOfParent2] && FitnessCalculation.fitness[nrOfParent4] > FitnessCalculation.fitness[nrOfParent2] && FitnessCalculation.fitness[nrOfParent5] > FitnessCalculation.fitness[nrOfParent2])
                            coupleOfParents[i][j] = nrOfParent2;
                        else if (FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent3] && FitnessCalculation.fitness[nrOfParent2] > FitnessCalculation.fitness[nrOfParent3] && FitnessCalculation.fitness[nrOfParent4] > FitnessCalculation.fitness[nrOfParent3] && FitnessCalculation.fitness[nrOfParent5] > FitnessCalculation.fitness[nrOfParent3])
                            coupleOfParents[i][j] = nrOfParent3;
                        else if (FitnessCalculation.fitness[nrOfParent2] > FitnessCalculation.fitness[nrOfParent1] && FitnessCalculation.fitness[nrOfParent3] > FitnessCalculation.fitness[nrOfParent1] && FitnessCalculation.fitness[nrOfParent4] > FitnessCalculation.fitness[nrOfParent1] && FitnessCalculation.fitness[nrOfParent5] > FitnessCalculation.fitness[nrOfParent1])
                            coupleOfParents[i][j] = nrOfParent1;
                        else if (FitnessCalculation.fitness[nrOfParent2] > FitnessCalculation.fitness[nrOfParent4] && FitnessCalculation.fitness[nrOfParent3] > FitnessCalculation.fitness[nrOfParent4] && FitnessCalculation.fitness[nrOfParent1] > FitnessCalculation.fitness[nrOfParent4] && FitnessCalculation.fitness[nrOfParent5] > FitnessCalculation.fitness[nrOfParent4])
                            coupleOfParents[i][j] = nrOfParent4;
                        else
                            coupleOfParents[i][j] = nrOfParent5;
                    }
                }
            }
        }
    }
}