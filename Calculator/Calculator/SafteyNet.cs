using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SafteyNet 
    {
        public static Boolean LastZero(string screen) //no more 0000
        {
            int length = screen.Length;

            if (screen[length - 1] == '0')
            {
                if (length > 1 && screen[length-2] != '*' && screen[length - 2] != '/' && screen[length - 2] != '+' && screen[length - 2] != '-' && screen[length - 2] != '(')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static Boolean LastSpecials(string screen) //checks for (- and ^(
        {
            int length = screen.Length;

            if (length >= 2)
            {
                char choice = screen[length - 1];
                char choice2 = screen[length - 2];

                if (choice == '-' && choice2 == '(')
                {
                    return true;
                }
                else if (choice == '(' && choice2 == '^')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string TooLargeScreen(string screen) //reduces screen length to not go out of screen
        {
            if (screen.Length == 12)
            {
                screen = screen.Substring(1);
            }
            return screen;
        }

        public static bool EmptyString(string screen)
        {
            if (screen.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool LastNegative(string screen)
        {
            int length = screen.Length;

            char choice1;
            char choice2;

            bool can = false;

            if (length >= 2)
            {
                choice1 = screen[length - 1];
                choice2 = screen[length - 2];

                if (choice1 == '-' && choice2 == '(')
                {
                    can = true;
                }
            }
            return can;
        }

        public static bool LastOpenParenthesis(string screen)
        {
            int length = screen.Length;
            char choice = screen[length - 1];

            bool can = false;

            if (choice == '(')
            {
                can = true;
            }
            else
            {
                can = false;
            }

            return can;
        }

        public static bool LastClosedParenthesis(string screen)
        {
            int length = screen.Length;
            char choice = screen[length - 1];

            bool can = false;

            if (choice == ')')
            {
                can = true;
            }
            else
            {
                can = false;
            }

            return can;
        }

        public static bool LastOperators(string screen)
        {
            int length = screen.Length;
            char choice = screen[length - 1];

            bool can = false;

            switch (choice)
            {
                case '/':
                    can = true;
                    break;
                case '*':
                    can = true;
                    break;
                case '-':
                    can = true;
                    break;
                case '+':
                    can = true;
                    break;
                default:
                    can = false;
                    break;
            }
            return can;
        }

        public static bool LastNumbers(string screen) 
        {
            int length = screen.Length;
            char choice = screen[length - 1];

            bool can = false;

            switch (choice)
            {
                case '0':
                    can = true;
                    break;
                case '1':
                    can = true;
                    break;
                case '2':
                    can = true;
                    break;
                case '3':
                    can = true;
                    break;
                case '4':
                    can = true;
                    break;
                case '5':
                    can = true;
                    break;
                case '6':
                    can = true;
                    break;
                case '7':
                    can = true;
                    break;
                case '8':
                    can = true;
                    break;
                case '9':
                    can = true;
                    break;
                default:
                    can = false;
                    break;
            }
            return can;
        }
    }
}
