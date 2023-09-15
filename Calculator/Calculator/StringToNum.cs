using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class StringToNum
    {
        public static bool active = false; //allows to loop until no more of type

        public static string CalculateEverything(string screen) //(-2)^(3) NOOOOOOOo
        {
            string oldscreen; //value to check for active

            do
            {
                oldscreen = screen;
                screen = ChangePlusMinus(screen);

                if (oldscreen == screen) //changes active
                {
                    active = false;
                }
                else
                {
                    active = true;
                }

            } while (active == true);

            do
            {
                oldscreen = screen;

                screen = CalculateParenthesis(screen);

                if (oldscreen == screen)
                {
                    active = false;
                }
                else
                {
                    active = true;
                }

            } while (active == true);

            do
            {
                oldscreen = screen;

                screen = CalculateExponents(screen);

                if (oldscreen == screen)
                {
                    active = false;
                }
                else
                {
                    active = true;
                }

            } while (active == true);

            screen = LoopMDAS(screen);

            return screen;
        }

        public static string ChangePlusMinus(string screen) //changes (-num) to -num
        {
            active = false;

            int start = 0;
            int end = 0;

            string miniScreen = ""; //holds the string of the (-num)

            for (start = 0; start < screen.Length; start++)
            {
               if (screen[start] == '(' && screen[start+1] == '-')
                {
                    active = true;

                    break; //sets start to the position of (
                }
            }

            if (active == true)
            {
                miniScreen = screen.Substring(start+1);

                for (end = 0; end < miniScreen.Length; end++)
                {
                    if (miniScreen[end] == ')')
                    {
                        break; //sets end to the postion of )
                    }
                }
                miniScreen = miniScreen.Remove(end);
            }

            screen = screen.Replace('(' + miniScreen + ')', miniScreen); //removes parenthesis

            return screen;
        }

        public static string CalculateParenthesis(string screen)
        {
            active = false;

            int start = 0;
            int end = 0;

            string oldMiniScreen = ""; //holds the values before calculation
            string miniScreen = "";

            for (start = screen.Length-1; start >= 0; start--) //holds the value of the last open parenthesis
            {
                if (screen[start] == '(' && (start == 0 || screen[start-1] != '^'))
                {
                    active = true;
                    break;
                }
            }

            if (active == true)
            {
                miniScreen = screen.Substring(start+1); //everything after last open parenthesis

                for (end = 0; end < miniScreen.Length; end++) //hold value of first closed parenthesis after the open parenthesis
                {
                    if (miniScreen[end] == ')')
                    {
                        miniScreen = miniScreen.Remove(end);
                        break;
                    }
                }

                oldMiniScreen = miniScreen;

                miniScreen = LoopMDAS(miniScreen);

                screen = screen.Replace('(' + oldMiniScreen + ')', miniScreen); 
            }

            return screen;
        }

        public static string CalculateExponents(string screen) //include */+- ...
        {
            active = false;

            int startNum = 0;
            int startPower = 0;
            int endParenthesis = 0;

            string num = "";
            string power1 = "";
            string power2 = "1";
            string miniScreen = ""; //holds the num and exponent
            string resultString = ""; //result after everything as string

            double numNum = 0;
            double power1Num = 0;
            double power2Num = 1;
            double result = 0; //result after everything

            for (startPower = 0; startPower < screen.Length; startPower++) //records ^ of power
            {
                if (screen[startPower] == '^' && screen[startPower+1] == '(')
                {
                    active = true;
                    break;
                }
            }

            if (active == true)
            {
                for (endParenthesis = startPower; endParenthesis < screen.Length; endParenthesis++) //records end parenthesis for power
                {
                    if (screen[endParenthesis] == ')')
                    {
                        break;
                    }
                }

                for (startNum = startPower-1; startNum >= 0; startNum--) //records start of num
                {
                    if (startNum == 0 || screen[startNum] == '*' || screen[startNum] == '/' || screen[startNum] == '+')
                    {
                        break;
                    }
                    else if (screen[startNum] == '-' && (startNum == 0 || startNum-1 == '*' || startNum - 1 == '/' || startNum - 1 == '+' || startNum - 1 == '-'))
                    {

                    }
                }

                num = screen.Remove(startPower);
                num = num.Substring(startNum);
                numNum = Convert.ToDouble(num);

                power1 = screen.Remove(endParenthesis);
                power1 = power1.Substring(startPower + 2); //really just the base power for now

                miniScreen = num + "^(" + power1 + ")";

                for (int i = 0; i < power1.Length; i++)
                {
                    if (power1[i] == '/')
                    {
                        power2 = power1.Substring(i+1);
                        power1 = power1.Remove(i);
                        break;
                    }
                }

                power1Num = Convert.ToDouble(power1);
                power2Num = Convert.ToDouble(power2);

                result = CalcMath.CalcToPower(numNum, power1Num, power2Num);
                result = Math.Round(result, 9);
                resultString = Convert.ToString(result);

                screen = screen.Replace(miniScreen, resultString);
            }

            return screen;
        }

        public static string CalculateMultiply(string screen)
        {
            active = false; //resets active to false

            int spot; //spot of sign

            for (spot = 0; spot < screen.Length; spot++)
            {
                if (screen[spot] == '*')
                {
                    active = true;
                    break;
                }
            }

            if (active == true)
            {
                string num1 = screen.Remove(spot);
                string num2 = screen.Substring(++spot);

                double num1Num;
                double num2Num;

                double result;
                string resultString;
               
                for (int i = num1.Length-1; i >= 0; i--) //reduces everything behind num1
                {
                    if (num1[i] == '*' || num1[i] == '/' || num1[i] == '+')
                    {
                        num1 = num1.Substring(i+1);
                        break;
                    }
                    else if (num1[i] == '-')
                    {
                        if (i > 0 && (num1[i-1] == '*' || num1[i - 1] == '/' || num1[i - 1] == '+' || num1[i - 1] == '-'))
                        {
                            num1 = num1.Substring(i);
                            break;
                        }
                        else
                        {
                            if (i == 0)
                            {
                                break;
                            }
                            else
                            {
                                num1 = num1.Substring(i + 1);
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < num2.Length; i++) //reduces everythng after num2
                {
                    if (i > 0 && (num2[i] == '*' || num2[i] == '/' || num2[i] == '+' || num2[i] == '-'))
                    {
                        num2 = num2.Remove(i);

                        break;
                    }
                }

                num1Num = Convert.ToDouble(num1);
                num2Num = Convert.ToDouble(num2);

                result = CalcMath.CalcMultiply(num1Num, num2Num);
                result = Math.Round(result, 9);
                resultString = Convert.ToString(result);

                screen = screen.Replace(num1 + '*' + num2, resultString);
            }

            return screen;
        }

        public static string CalculateDivide(string screen)
        {
            active = false; //resets active to false

            int spot; //spot of sign

            for (spot = 0; spot < screen.Length; spot++)
            {
                if (screen[spot] == '/')
                {
                    active = true;
                    break;
                }
            }

            if (active == true)
            {
                string num1 = screen.Remove(spot);
                string num2 = screen.Substring(++spot);

                double num1Num;
                double num2Num;

                double result;
                string resultString;

                for (int i = num1.Length - 1; i >= 0; i--) //reduces everything behind num1
                {
                    if (num1[i] == '*' || num1[i] == '/' || num1[i] == '+')
                    {
                        num1 = num1.Substring(i + 1);
                        break;
                    }
                    else if (num1[i] == '-')
                    {
                        if (i > 0 && (num1[i - 1] == '*' || num1[i - 1] == '/' || num1[i - 1] == '+' || num1[i - 1] == '-'))
                        {
                            num1 = num1.Substring(i);
                            break;
                        }
                        else
                        {
                            if (i == 0)
                            {
                                break;
                            }
                            else
                            {
                                num1 = num1.Substring(i + 1);
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < num2.Length; i++) //reduces everythng after num2
                {
                    if (i > 0 && (num2[i] == '*' || num2[i] == '/' || num2[i] == '+' || num2[i] == '-'))
                    {
                        num2 = num2.Remove(i);

                        break;
                    }
                }

                num1Num = Convert.ToDouble(num1);
                num2Num = Convert.ToDouble(num2);

                result = CalcMath.CalcDivide(num1Num, num2Num);
                result = Math.Round(result, 9);
                resultString = Convert.ToString(result);

                screen = screen.Replace(num1 + '/' + num2, resultString);
            }

            return screen;
        }

        public static string CalculateAdd(string screen)
        {
            active = false; //resets active to false

            int spot; //spot of sign

            for (spot = 0; spot < screen.Length; spot++)
            {
                if (screen[spot] == '+')
                {
                    active = true;
                    break;
                }
            }

            if (active == true)
            {
                string num1 = screen.Remove(spot);
                string num2 = screen.Substring(++spot);

                double num1Num;
                double num2Num;

                double result;
                string resultString;

                for (int i = num1.Length - 1; i >= 0; i--) //reduces everything behind num1
                {
                    if (num1[i] == '*' || num1[i] == '/' || num1[i] == '+')
                    {
                        num1 = num1.Substring(i + 1);
                        break;
                    }
                    else if (num1[i] == '-')
                    {
                        if (i > 0 && (num1[i - 1] == '*' || num1[i - 1] == '/' || num1[i - 1] == '+' || num1[i - 1] == '-'))
                        {
                            num1 = num1.Substring(i);
                            break;
                        }
                        else
                        {
                            if (i == 0)
                            {
                                break;
                            }
                            else
                            {
                                num1 = num1.Substring(i + 1);
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < num2.Length; i++) //reduces everythng after num2
                {
                    if (i > 0 && (num2[i] == '*' || num2[i] == '/' || num2[i] == '+' || num2[i] == '-'))
                    {
                        num2 = num2.Remove(i);

                        break;
                    }
                }

                num1Num = Convert.ToDouble(num1);
                num2Num = Convert.ToDouble(num2);

                result = CalcMath.CalcAdd(num1Num, num2Num);
                result = Math.Round(result, 9);
                resultString = Convert.ToString(result);

                screen = screen.Replace(num1 + '+' + num2, resultString);
            }

            return screen;
        }

        public static string CalculateSubtract(string screen)
        {
            active = false; //resets active to false

            int spot; //spot of sign

            for (spot = 0; spot < screen.Length; spot++)
            {
                if (screen[spot] == '-' && spot > 0) //if spot == 0 and result = - then issue
                {
                    if (screen[spot-1] != '*' && screen[spot - 1] != '/' && screen[spot - 1] != '+' && screen[spot - 1] != '-') 
                    {
                        active = true;
                        break;
                    }
                }
            }

            if (active == true)
            {
                string num1 = screen.Remove(spot);
                string num2 = screen.Substring(++spot);

                double num1Num;
                double num2Num;

                double result;
                string resultString;

                for (int i = num1.Length - 1; i >= 0; i--) //reduces everything behind num1
                {
                    if (num1[i] == '*' || num1[i] == '/' || num1[i] == '+')
                    {
                        num1 = num1.Substring(i + 1);
                        break;
                    }
                    else if (num1[i] == '-')
                    {
                        if (i > 0 && (num1[i - 1] == '*' || num1[i - 1] == '/' || num1[i - 1] == '+' || num1[i - 1] == '-'))
                        {
                            num1 = num1.Substring(i);
                            break;
                        }
                        else
                        {
                            if (i == 0)
                            {
                                break;
                            }
                            else
                            {
                                num1 = num1.Substring(i + 1);
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < num2.Length; i++) //reduces everythng after num2
                {
                    if (i > 0 && (num2[i] == '*' || num2[i] == '/' || num2[i] == '+' || num2[i] == '-'))
                    {
                        num2 = num2.Remove(i);

                        break;
                    }
                }

                num1Num = Convert.ToDouble(num1);
                num2Num = Convert.ToDouble(num2);

                result = CalcMath.CalcSubtract(num1Num, num2Num);
                result = Math.Round(result, 9);
                resultString = Convert.ToString(result);

                screen = screen.Replace(num1 + '-' + num2, resultString);
            }

            return screen;
        }

        public static string LoopMDAS(string screen) //loops through basic operators
        {
            for (int i = 0; i < screen.Length; i++)
            {
                do
                {
                    if (screen[i] == '*' || screen[i] == '/')
                    {
                        if (screen[i] == '*')
                        {
                            screen = CalculateMultiply(screen);
                        }
                        else
                        {
                            screen = CalculateDivide(screen);
                        }
                        i = 0; //lowers i to start by reading the new result
                        active = true; //only active that counts towards the loop
                    }
                    else
                    {
                        active = false;
                    }
                } while (active == true);
            }

            for (int i = 0; i < screen.Length; i++)
            {
                do
                {
                    if (screen[i] == '+' || screen[i] == '-')
                    {
                        if (screen[i] == '+')
                        {
                            screen = CalculateAdd(screen);
                            active = true;
                        }
                        else if (i > 0 && screen[i - 1] != '*' && screen[i - 1] != '/' && screen[i - 1] != '+' && screen[i - 1] != '-')
                        {
                            screen = CalculateSubtract(screen);
                            active = true;
                        }
                        else
                        {
                            active = false;
                        }
                        i = 0; //lowers i to start by reading the new result
                    }
                    else
                    {
                        active = false;
                    }
                } while (active == true);
            }

            return screen;
        }
    }
}