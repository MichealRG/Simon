using System;
using System.Collections.Generic;
using System.Text;

namespace MSI_AEX
{

    public class PopulationGenerating
    {
        public static char[][] Populacja = new char[100][];
        public static double[][] PopulacjaForWeight = new double[100][]; 
        public static string alphabet = "";
        public static int rndNumber;
        public static char rndsign;
        public static Random rnd = new Random();


        public static void GeneratePopulation()
        {
            for (int i = 0, j = 0; i < Populacja.Length; i++, j = 0, alphabet = "")
            {
                Populacja[i] = new char[30]; 
                PopulacjaForWeight[i] = new double[30];
                do
                {
                    rndNumber = rnd.Next(0, 30);
                    rndsign = AssignWeight.sign[rndNumber];
                    if (!alphabet.Contains(rndsign))
                    {
                        alphabet += rndsign;
                        Populacja[i][j] = rndsign;
                        PopulacjaForWeight[i][j] = AssignWeight.signsWeight[rndNumber];
                        j++;

                    }
                } while (alphabet.Length <= 29);
            }
        }
    }
}