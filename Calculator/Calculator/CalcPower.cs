using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcPower
    {
        public static double NumToSquares(double num, double power) //calculates the square..etc
        {
            double product = 1;

            for (int i = 0; i < power; i++)
            {
                product *= num;
            }

            return product;
        }

        public static double NumToRoot(double num, double power) //calculates the root
        {
            double sqrt = 0;
            int maxDecimal = 9; //max decimal place
            double numToAdd = .1; //lets the program add by .1, .01, 001, til max decimal place of 9

            while (NumToSquares(sqrt, power) < num) //handles integer value
            {
                sqrt++;
            }

            if (NumToSquares(sqrt, power) > num) //sets sqrt back to the correct number if above
            {
                sqrt--;
            }

            //handles decimals
            if (NumToSquares(sqrt, power) != num)
            {
                for (int deci = 1; deci <= maxDecimal; deci++) //loops max 9 times
                {
                    for (int i = 1; i <= maxDecimal; i++)
                    {
                        sqrt += numToAdd;

                        if (NumToSquares(sqrt, power) == num) //breaks if sqrt is correct
                        {
                            break;
                        }
                        else if (NumToSquares(sqrt, power) > num) //breaks and lowers when sqrt value is correct
                        {
                            sqrt -= numToAdd;
                            break;
                        }
                    }

                    numToAdd *= .1; //goes up to max decimal place

                    if (NumToSquares(sqrt, power) == num) //breaks if sqrt is finished
                    {
                        break;
                    }
                }
            }
            return sqrt;
        }

        public static double CalcToPower(double num, double power1, double power2) //full calculation
        {
            num = NumToSquares(num, power1);
            num = NumToRoot(num, power2);

            return num;
        }
    }
}
