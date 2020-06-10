using System;
using System.Linq;
using System.IO;

namespace MSI_AEX
{
    class Program
    {
        static void Main(string[] args)
        {
            AssignWeight.WeightAssignment();
            PopulationGenerating.GeneratePopulation();
            SaveGenerationsToTextFile.SaveToFile();

            FitnessCalculation.HistroyOfFit[0] = 100000 - 2;
            FitnessCalculation.HistroyOfFit[1] = 100000 - 1;
            FitnessCalculation.HistroyOfFit[2] = 100000;
            FitnessCalculation.massiveFit = 0;
            do
            {
                do
                {
                    FitnessCalculation.massiveFit = 0;
                    FitnessCalculation.CalculateFitness();
                    ShowPopulationOnScreen.ShowOnScreen();
                    Selection.Selecting();
                    AEXCrossing.AEX();
                    ChildrenFitnessCalculation.CalculateFitnessForChildren();
                    GenereteNewPopulation.GenerateNewPopulation();
                } while 
                            ((FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 1] < FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 2]) || 
                            (FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 2] < FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 3]) || 
                            (FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 3] < FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 4]));
                Mutation.Mutate();
            } while 
                            (FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 1] < FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 2] ||
                            FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 2] < FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 3] ||
                            FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 3] < FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 4] ||
                            FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 4] < FitnessCalculation.HistroyOfFit[GenereteNewPopulation.t - 5]);
            FitnessCalculation.CalculateFitness();
            WritingResults.WriteResults();

        }
    }
}