using System;
using System.Collections.Generic;
using System.Text;

namespace MSI_AEX
{
    public class Mutation
    {
        public static int tempint;
        public static int tempint2;
        public static double tempdouble;
        public static int numberOfMutation;

        public static void Mutate()
        {
            tempint2 = PopulationGenerating.rnd.Next(10, 15);
            for (int i = 0; i < tempint2; i++)
            {
                AEXCrossing.number = PopulationGenerating.rnd.Next(0, 100);
                tempint = PopulationGenerating.rnd.Next(3, 8);
                for (int j = 0; j < tempint; j++)
                {
                    PopulationGenerating.rndNumber = PopulationGenerating.rnd.Next(0, 30);
                    if (PopulationGenerating.rndNumber < 29)
                    {
                        PopulationGenerating.rndsign = PopulationGenerating.Populacja[AEXCrossing.number][PopulationGenerating.rndNumber + 1];
                        PopulationGenerating.Populacja[AEXCrossing.number][PopulationGenerating.rndNumber + 1] = PopulationGenerating.Populacja[AEXCrossing.number][PopulationGenerating.rndNumber];
                        PopulationGenerating.Populacja[AEXCrossing.number][PopulationGenerating.rndNumber] = PopulationGenerating.rndsign;
                        tempdouble = PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][PopulationGenerating.rndNumber + 1];
                        PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][PopulationGenerating.rndNumber + 1] = PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][PopulationGenerating.rndNumber];
                        PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][PopulationGenerating.rndNumber] = tempdouble;
                    }
                    else
                    {
                        PopulationGenerating.rndsign = PopulationGenerating.Populacja[AEXCrossing.number][0];
                        PopulationGenerating.Populacja[AEXCrossing.number][0] = PopulationGenerating.Populacja[AEXCrossing.number][PopulationGenerating.rndNumber];
                        PopulationGenerating.Populacja[AEXCrossing.number][PopulationGenerating.rndNumber] = PopulationGenerating.rndsign;
                        tempdouble = PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][0];
                        PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][0] = PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][PopulationGenerating.rndNumber];
                        PopulationGenerating.PopulacjaForWeight[AEXCrossing.number][PopulationGenerating.rndNumber] = tempdouble;
                    }
                }

            }
            numberOfMutation++;
        }
    }
}