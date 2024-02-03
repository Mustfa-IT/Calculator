using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TempForm2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        
        string expression ;

        private void zero_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "0";
        }
        private void one_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "1";
        }
        private void two_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "2";

            
        }
        private void three_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "3";

            
        }
        private void four_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "4";

            
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "5";

            
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "6";

            
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "7";

            
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "8";

            
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "9";

            
        }
        private void dot_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += ".";
            
        }
        private void plus_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "+";

        }

        private void mins_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "-";

        }

        private void mul_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "*";
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text += "÷";
        }

        private void AC_btn_Click(object sender, EventArgs e)
        {
            input_txtBox.Text = "";
        }
        private void backspace_btn_Click(object sender, EventArgs e)
        {
            if (input_txtBox.Text.Length == 0)
                return;
            input_txtBox.Text = input_txtBox.Text.Remove(input_txtBox.Text.Length - 1);
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            Checks();
        }
        private void Checks() 
        {
            
            string s = input_txtBox.Text;
            if (s.Equals("con"))
            {
                ConsoleShow();
                input_txtBox.Text = ""; 
                return;
            }
           if (s.Contains('÷'))
                s = s.Replace('÷', '/');
           expression = s;
            if (!CalculatorLogic.IsValidMathExpression(expression))
            {
                MessageBox.Show("Invalid math expression. Please enter a valid expression.");
                return;
            }



            double result =CalculatorLogic.EvaluateMathExpression(expression);
            if (result.Equals(double.NaN) || result.Equals(double.PositiveInfinity) || result.Equals(double.NegativeInfinity))
            {
                input_txtBox.Text = "can't do division with zero";
                return;
            }
            if (result.Equals(double.Epsilon))
            {
                MessageBox.Show("Invalid math expression. Please enter a valid expression.");
                return;
            }


            input_txtBox.Text = result.ToString();
            SetCursorPosition(result.ToString().Length);
            expression = result.ToString();
            
        }
       
        private void input_txtBox_KeyDown(object sender, KeyEventArgs e) 
        {
            if(e.KeyCode == Keys.Enter) 
            {
                Checks();
                e.Handled = true;
            }
        }
        
        private void SetCursorPosition(int position)
        {
            input_txtBox.SelectionStart = position;
            input_txtBox.SelectionLength = 0;
        }

        private void ConsoleShow() 
        {
            Test test = new Test();
            test.Show();
        }
    }
}
