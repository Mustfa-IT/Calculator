using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempForm2
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        static List<string> testRandom(int count)
        {
            
            bool isValid1, isValid2;
            int i = 0;
            int wrong = 0;

            List<string> wrongTests = new List<string>();
            do
            {
                string randomExpression = GenerateRandomMathExpression();

                double res1 = 0, res2 = 0;
                isValid1 = CalculatorLogic.IsValidMathExpression(randomExpression);
                isValid2 = IsValidMathExpression(randomExpression);
                if (isValid1)
                {
                    res1 = CalculatorLogic.EvaluateMathExpression(randomExpression);
                }
                if (isValid2)
                {
                    res2 = Evaluate(randomExpression);
                }

                if (isValid1 != isValid2 || res1 != res2)
                {
                    wrongTests.Add($"Random Expression: {randomExpression}" );
                    wrongTests.Add($"Result: isValid1 = {isValid1} , isValid2  = {isValid2} ");
                    wrongTests.Add($"Math : res1 = {res1} , res2 = {res2}") ;
                    wrongTests.Add($"");
                    wrong++;
                }
                i++;
            } while (i <= count);
            wrongTests.Add("Wrong counts = "+wrong);
            double prenectage = ((double) wrong / count) * 100;
            wrongTests.Add("test ended with %"+prenectage + " Faild rate");
            return wrongTests;
        }
        static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        static bool IsValidMathExpression(string expression)
        {
            DataTable table = new DataTable();

            try
            {
                double result = Convert.ToDouble(table.Compute(expression, string.Empty));

                // Check for division by zero separately
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        static Random random = new Random();
        static string GenerateRandomMathExpression()
        {
            // Valid characters for the math expression
            string validChars = ".0123456789+-/*";

            // Set the length of the expression
            int expressionLength = random.Next(5, 10);

            // Build the random expression
            char[] expression = new char[expressionLength];
            for (int i = 0; i < expressionLength; i++)
            {
                expression[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(expression);
        }

        private bool waitingForSecondEnter = false;
        private void input_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string command = input_textBox.Text.Trim();
                ProcessCommand(command);

                // Clear the input only if not waiting for the second Enter
                if (!waitingForSecondEnter)
                {
                    input_textBox.Clear();
                }

                e.Handled = true;  // Move this line inside the if block
            }
        }

        private void ProcessCommand(string command)
        {
            if (command == "test")
            {
                PrintToConsole("Enter test counts");
                waitingForSecondEnter = true;
                input_textBox.Clear();
            }
            else if (waitingForSecondEnter)
            {
                // Check if the input is a valid integer
                if (int.TryParse(command, out int count))
                {
                    PrintToConsole($"You entered: {count}");
                    List<string> results = testRandom(count);
                    foreach (string result in results)
                    {
                        PrintToConsole(result);
                    }
                }
                else
                {
                    PrintToConsole("Invalid input. Please enter a valid integer.");
                }

                // Reset the state after processing
                waitingForSecondEnter = false;
            }
            else if (command == "help")  // Use "else if" to avoid multiple conditions being true
            {
                PrintToConsole("test - do some testing and show the false test");
            }
            else if (command == "clear")
            {
                listBoxOutput.Items.Clear();
                input_textBox.Clear();
            }
            else
            {
                PrintToConsole("Unknown command. Type 'help' for a list of commands.");
            }
        }

        private void PrintToConsole(string message)
        {
            listBoxOutput.Items.Add(message);
            listBoxOutput.SelectedIndex = listBoxOutput.Items.Count - 1;
            // Optionally, you can clear the input after processing
            // input_textBox.Clear();  // Removed this line to clear input only when necessary
        }

    }
}
