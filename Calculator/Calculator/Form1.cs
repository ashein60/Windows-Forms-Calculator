using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private string screenText; //Full screen text

        private bool activeDecimals = false; //limits decimals
        private bool activePlusMinus = false; //makes sure there is a closed parenthesis
        private bool usedOperator = false; //checks to allow equal sign
        private bool activePower = false; //disables stacking powers
        private bool activeDividePower = false; //allows only 1 division symbol in a power
        private int activeParenthesis = 0; //limits closed parenthesis

        public Calculator()
        {
            InitializeComponent();
        }

        //Click events
        private void Click_clear(object sender, EventArgs e)
        {
            screenText = "";
            this.screen.Text = "";

            activeParenthesis = 0;
            activeDecimals = false;
            activePlusMinus = false;
            activePower = false;
            activeDividePower = false;
            usedOperator = false;

            GrayEquals();
        }

        private void Click_power(object sender, EventArgs e)
        {
            if (activePower == false && activePlusMinus == false && SafteyNet.EmptyString(this.screen.Text) == false && (SafteyNet.LastNumbers(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == true))
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += '^';
                this.screen.Text += '^';

                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += '(';
                this.screen.Text += '(';

                activeParenthesis++;               
                activeDecimals = false;
                activePower = true;
                usedOperator = true;

                GrayEquals();
            }
        }

        private void Click_parenthesis(object sender, EventArgs e)
        {
            if (activePower == false && SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastOperators(this.screen.Text) == true || SafteyNet.LastOpenParenthesis(this.screen.Text) == true)
            {
                if (SafteyNet.LastSpecials(this.screen.Text) == false)
                {
                    this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                    screenText += "(";
                    this.screen.Text += "(";

                    activeDecimals = false;
                    activeParenthesis++;

                    GrayEquals();
                }
            }
            else if (activeParenthesis > 0)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += ")";
                this.screen.Text += ")";

                activeDecimals = false;
                activePlusMinus = false;
                activePower = false;
                activeDividePower = false;
                activeParenthesis--;

                GrayEquals();
            }
        }

        private void Click_divide(object sender, EventArgs e)
        {
            if (activeDividePower == false && SafteyNet.EmptyString(this.screen.Text) == false)
            {
                if (SafteyNet.LastNumbers(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == true)
                {
                    if (activePlusMinus == true)
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += ")";
                        this.screen.Text += ")";

                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "/";
                        this.screen.Text += "/";

                        activePlusMinus = false;
                    }
                    else if (activePower == true)
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "/";
                        this.screen.Text += "/";
                        activeDividePower = true;
                    }
                    else
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "/";
                        this.screen.Text += "/";
                    }

                    activeDecimals = false;
                    usedOperator = true;

                    GrayEquals();
                }
            }
        }

        private void Click_multiply(object sender, EventArgs e)
        {
            if (activePower == false && SafteyNet.EmptyString(this.screen.Text) == false)
            {
                if (SafteyNet.LastNumbers(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == true)
                {
                    if (activePlusMinus == true)
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += ")";
                        this.screen.Text += ")";

                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "*";
                        this.screen.Text += "*";

                        activePlusMinus = false;
                    }
                    else
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "*";
                        this.screen.Text += "*";
                    }

                    activeDecimals = false;
                    usedOperator = true;

                    GrayEquals();
                }
            }
        }

        private void Click_subtract(object sender, EventArgs e)
        {
            if (activePower == false && SafteyNet.EmptyString(this.screen.Text) == false)
            {
                if (SafteyNet.LastNumbers(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == true)
                {
                    if (activePlusMinus == true)
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += ")";
                        this.screen.Text += ")";

                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "-";
                        this.screen.Text += "-";

                        activePlusMinus = false;
                    }
                    else
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "-";
                        this.screen.Text += "-";
                    }

                    activeDecimals = false;
                    usedOperator = true;

                    GrayEquals();
                }
            }
        }

        private void Click_add(object sender, EventArgs e)
        {
            if (activePower == false && SafteyNet.EmptyString(this.screen.Text) == false)
            {
                if (SafteyNet.LastNumbers(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == true)
                {
                    if (activePlusMinus == true)
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += ")";
                        this.screen.Text += ")";

                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "+";
                        this.screen.Text += "+";

                        activePlusMinus = false;
                    }
                    else
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "+";
                        this.screen.Text += "+";
                    }

                    activeDecimals = false;
                    usedOperator = true;

                    GrayEquals();
                }
            }
        }

        private void Click_period(object sender, EventArgs e)
        {
            if (activePower == false && activeDecimals == false && SafteyNet.EmptyString(this.screen.Text) == false)
            {
                if (SafteyNet.LastNumbers(this.screen.Text) == true)
                {
                    this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                    screenText += ".";
                    this.screen.Text += ".";

                    activeDecimals = true;

                    GrayEquals();
                }
            }
        }

        private void Click_plusMinus(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "(-";
                this.screen.Text += "(-";
                activeParenthesis++;

                activeDecimals = false;
                activePlusMinus = true;
                usedOperator = true;

                GrayEquals();
            }
            else
            {
                if (SafteyNet.LastOpenParenthesis(this.screen.Text) == true || SafteyNet.LastOperators(this.screen.Text) == true )
                {
                    if (SafteyNet.LastNegative(this.screen.Text) == false && SafteyNet.LastSpecials(this.screen.Text) == false)
                    {
                        this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                        screenText += "(-";
                        this.screen.Text += "(-";
                        activeParenthesis++;

                        activeDecimals = false;
                        activePlusMinus = true;
                        usedOperator = true;

                        GrayEquals();
                    }
                }
            }
        }

        //NUMBERS NUMBERS NUMBERS
        private void Click_zero(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "0";
                this.screen.Text += "0";

                GrayEquals();
            }
            else if (SafteyNet.LastZero(this.screen.Text) == false && SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "0";
                this.screen.Text += "0";

                GrayEquals();
            }
        }

        private void Click_one(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "1";
                this.screen.Text += "1";

                GrayEquals();
            }
        }

        private void Click_two(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "2";
                this.screen.Text += "2";

                GrayEquals();
            }
        }

        private void Click_three(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "3";
                this.screen.Text += "3";

                GrayEquals();
            }
        }

        private void Click_four(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "4";
                this.screen.Text += "4";

                GrayEquals();
            }
        }

        private void Click_five(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "5";
                this.screen.Text += "5";

                GrayEquals();
            }
        }

        private void Click_six(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "6";
                this.screen.Text += "6";

                GrayEquals();
            }
        }

        private void Click_seven(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "7";
                this.screen.Text += "7";

                GrayEquals();
            }
        }

        private void Click_eight(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "8";
                this.screen.Text += "8";

                GrayEquals();
            }
        }

        private void Click_nine(object sender, EventArgs e)
        {
            if (SafteyNet.EmptyString(this.screen.Text) == true || SafteyNet.LastClosedParenthesis(this.screen.Text) == false)
            {
                this.screen.Text = SafteyNet.TooLargeScreen(this.screen.Text);
                screenText += "9";
                this.screen.Text += "9";

                GrayEquals();
            }
        }

        //SPECIALS SPECIALS SPECIALS
        private void Click_equals(object sender, EventArgs e)
        {
            if (this.screen.Text.Length > 0 && activeParenthesis == 0)
            {
                if (SafteyNet.LastClosedParenthesis(this.screen.Text) == true || (SafteyNet.LastNumbers(this.screen.Text) == true && usedOperator == true))
                {
                    string result = StringToNum.CalculateEverything(screenText);
                    screenText = result;

                    if (screenText.Length > 12) //max char in screen is 12
                    {
                        result = result.Remove(result[screenText.Length - 13]);
                    }

                    this.screen.Text = result;

                    activeParenthesis = 0;
                    activeDecimals = false;
                    activePlusMinus = false;
                    activePower = false;
                    activeDividePower = false;
                    usedOperator = false;

                    GrayEquals();
                }
            }
        }

        private void Click_screen(object sender, EventArgs e)
        {
            int parentX = this.Location.X;
            int parentY = this.Location.Y;
            Point position = new Point(parentX - 92, parentY + 51);

            ScreenModal screen = new ScreenModal();
            screen.Location = position;
            screen.modalText.Text = screenText;
            screen.ShowDialog(this);
        }

        private void GrayEquals() //changes the color of equals to show if it's usable
        {
            if (this.screen.Text.Length > 0 && activeParenthesis == 0)
            {
                if (SafteyNet.LastClosedParenthesis(this.screen.Text) == true || (SafteyNet.LastNumbers(this.screen.Text) == true && usedOperator == true))
                {
                    this.equals.BackColor = System.Drawing.Color.White;
                    this.equals.FlatAppearance.MouseDownBackColor = Control.DefaultBackColor;
                    this.equals.FlatAppearance.MouseOverBackColor = Control.DefaultBackColor;
                }
                else
                {
                    this.equals.BackColor = System.Drawing.Color.LightGray;
                    this.equals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
                    this.equals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
                }
            }
            else
            {
                this.equals.BackColor = System.Drawing.Color.LightGray;
                this.equals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
                this.equals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            }
        }
    }
}