namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.parenthesis = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.White;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(20, 20);
            this.screen.Margin = new System.Windows.Forms.Padding(10);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(240, 45);
            this.screen.TabIndex = 0;
            this.screen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screen.Click += new System.EventHandler(this.Click_screen);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(20, 85);
            this.clear.Margin = new System.Windows.Forms.Padding(10);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(45, 45);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Click_clear);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.White;
            this.power.FlatAppearance.BorderSize = 0;
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(85, 85);
            this.power.Margin = new System.Windows.Forms.Padding(10);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(45, 45);
            this.power.TabIndex = 2;
            this.power.Text = "/\\";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.Click_power);
            // 
            // parenthesis
            // 
            this.parenthesis.BackColor = System.Drawing.Color.White;
            this.parenthesis.FlatAppearance.BorderSize = 0;
            this.parenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parenthesis.Location = new System.Drawing.Point(150, 85);
            this.parenthesis.Margin = new System.Windows.Forms.Padding(10);
            this.parenthesis.Name = "parenthesis";
            this.parenthesis.Size = new System.Drawing.Size(45, 45);
            this.parenthesis.TabIndex = 3;
            this.parenthesis.Text = "()";
            this.parenthesis.UseVisualStyleBackColor = false;
            this.parenthesis.Click += new System.EventHandler(this.Click_parenthesis);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.White;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(215, 85);
            this.divide.Margin = new System.Windows.Forms.Padding(10);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(45, 45);
            this.divide.TabIndex = 4;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Click_divide);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.White;
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(215, 150);
            this.multiply.Margin = new System.Windows.Forms.Padding(10);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(45, 45);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Click_multiply);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.White;
            this.subtract.FlatAppearance.BorderSize = 0;
            this.subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(215, 215);
            this.subtract.Margin = new System.Windows.Forms.Padding(10);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(45, 45);
            this.subtract.TabIndex = 6;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.Click_subtract);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(215, 280);
            this.add.Margin = new System.Windows.Forms.Padding(10);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 45);
            this.add.TabIndex = 7;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Click_add);
            // 
            // period
            // 
            this.period.BackColor = System.Drawing.Color.White;
            this.period.FlatAppearance.BorderSize = 0;
            this.period.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.period.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(150, 345);
            this.period.Margin = new System.Windows.Forms.Padding(10);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(45, 45);
            this.period.TabIndex = 8;
            this.period.Text = ".";
            this.period.UseVisualStyleBackColor = false;
            this.period.Click += new System.EventHandler(this.Click_period);
            // 
            // plusMinus
            // 
            this.plusMinus.BackColor = System.Drawing.Color.White;
            this.plusMinus.FlatAppearance.BorderSize = 0;
            this.plusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinus.Location = new System.Drawing.Point(20, 345);
            this.plusMinus.Margin = new System.Windows.Forms.Padding(10);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(45, 45);
            this.plusMinus.TabIndex = 9;
            this.plusMinus.Text = "+/-";
            this.plusMinus.UseVisualStyleBackColor = false;
            this.plusMinus.Click += new System.EventHandler(this.Click_plusMinus);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.White;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(85, 345);
            this.zero.Margin = new System.Windows.Forms.Padding(10);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(45, 45);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Click_zero);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.White;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(20, 280);
            this.one.Margin = new System.Windows.Forms.Padding(10);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 45);
            this.one.TabIndex = 11;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Click_one);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.White;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(85, 280);
            this.two.Margin = new System.Windows.Forms.Padding(10);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 45);
            this.two.TabIndex = 12;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Click_two);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.White;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(150, 280);
            this.three.Margin = new System.Windows.Forms.Padding(10);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 45);
            this.three.TabIndex = 13;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Click_three);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.White;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(150, 215);
            this.six.Margin = new System.Windows.Forms.Padding(10);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 45);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Click_six);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.White;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(85, 215);
            this.five.Margin = new System.Windows.Forms.Padding(10);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 45);
            this.five.TabIndex = 15;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Click_five);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.White;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(20, 215);
            this.four.Margin = new System.Windows.Forms.Padding(10);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 45);
            this.four.TabIndex = 16;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Click_four);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.White;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(85, 150);
            this.eight.Margin = new System.Windows.Forms.Padding(10);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 45);
            this.eight.TabIndex = 17;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Click_eight);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.White;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(150, 150);
            this.nine.Margin = new System.Windows.Forms.Padding(10);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(45, 45);
            this.nine.TabIndex = 18;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Click_nine);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.White;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(20, 150);
            this.seven.Margin = new System.Windows.Forms.Padding(10);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 45);
            this.seven.TabIndex = 19;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Click_seven);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.LightGray;
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.equals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(215, 345);
            this.equals.Margin = new System.Windows.Forms.Padding(10);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(45, 45);
            this.equals.TabIndex = 20;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Click_equals);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(280, 410);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.period);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.parenthesis);
            this.Controls.Add(this.power);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.screen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button parenthesis;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button period;
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label screen;
    }
}

