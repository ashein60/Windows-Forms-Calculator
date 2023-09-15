using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcMath
    {
        public static double CalcToPower(double num, double power, double root) //use CalcPower class
        {
            string numString = Convert.ToString(num);
            double result = 0;
            string resultString;

            if (numString[0] == '-')
            {
                numString = numString.Substring(1);
                num = Convert.ToDouble(numString);

                if (power % 2 != 0)
                {
                    result = CalcPower.CalcToPower(num, power, root);
                    resultString = '-' + Convert.ToString(result);
                    result = Convert.ToDouble(resultString);
                }
                else
                {
                    result = CalcPower.CalcToPower(num, power, root);
                }
            }
            else
            {
                result = CalcPower.CalcToPower(num, power, root);
            }
            return result;
        }

        public static double CalcMultiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double CalcDivide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double CalcSubtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double CalcAdd(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
