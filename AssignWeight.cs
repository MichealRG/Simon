using System;
using System.Collections.Generic;
using System.Text;

namespace MSI_AEX
{
    public class AssignWeight
    {
        public static char[] sign = new char[30];
        public static double[] signsWeight = new double[30];
        public static void WeightAssignment()
        {
            for (int i = 0; i < sign.Length; i++)

            {
                if (i <= 25)
                {
                    sign[i] = (char)('a' + i);
                }
                else
                {
                    sign[i] = (char)(i + 18); //znaki interpunkcyjne
                }
                
                //przypisanie 
                if (i == 0){signsWeight[i] = 8.12; }
                else if (i == 1){signsWeight[i] = 1.49;}
                else if (i == 2){signsWeight[i] = 2.71;}
                else if (i == 3){signsWeight[i] = 4.32;}
                else if (i == 4){signsWeight[i] = 12.02;}
                else if (i == 5){signsWeight[i] = 2.30;}
                else if (i == 6){signsWeight[i] = 2.03;}
                else if (i == 7){signsWeight[i] = 5.92;}
                else if (i == 8){signsWeight[i] = 7.31;}
                else if (i == 9){signsWeight[i] = 0.1;}
                else if (i == 10){signsWeight[i] = 0.69;}
                else if (i == 11){signsWeight[i] = 3.98;}
                else if (i == 12){signsWeight[i] = 2.61;}
                else if (i == 13){signsWeight[i] = 6.95;}
                else if (i == 14){signsWeight[i] = 7.68;}
                else if (i == 15){signsWeight[i] = 1.82;}
                else if (i == 16){signsWeight[i] = 0.11;}
                else if (i == 17){signsWeight[i] = 6.02;}
                else if (i == 18){signsWeight[i] = 6.28;}
                else if (i == 19){signsWeight[i] = 9.1;}
                else if (i == 20){signsWeight[i] = 2.88;}
                else if (i == 21){signsWeight[i] = 1.11;}
                else if (i == 22){signsWeight[i] = 2.09;}
                else if (i == 23){signsWeight[i] = 0.17;}
                else if (i == 24){signsWeight[i] = 2.11;}
                else if (i == 25){signsWeight[i] = 0.07;}
                else if (i == 26){signsWeight[i] = 1.3;}
                else if (i == 27){signsWeight[i] = 0.05;}
                else if (i == 28){signsWeight[i] = 1.1;}
                else if (i == 29){signsWeight[i] = 0.02;}
            }
        }
    }
}