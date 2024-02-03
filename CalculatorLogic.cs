using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempForm2
{
    public static class CalculatorLogic
    {
        public static bool IsValidMathExpression(string expression)
        {
            try
            {
                // Initialize indexList to keep track of parsing position
                List<int> indexList = new List<int> { 0 };
                // Attempt to parse the expression
                ParseExpression(expression, indexList);

                // If parsing is successful and end of the string is reached, it's a valid expression
                return indexList[0] == expression.Length;
            }
            catch (Exception e)
            {
                // If an exception occurs during parsing, return false
               return false;
            }
        }

        private static void ParseExpression(string expression, List<int> indexList)
        {
            // Parse the first term of the expression
            ParseTerm(expression, indexList);

            // Continue parsing while encountering addition or subtraction operators
            while (indexList[0] < expression.Length && (expression[indexList[0]] == '+' || expression[indexList[0]] == '-'))
            {
                indexList[0]++; // Move past the operator
                ParseTerm(expression, indexList);
            }

            // Check for a valid expression end
            if (indexList[0] < expression.Length && (expression[indexList[0]] == ')' || expression[indexList[0]] == '+' || expression[indexList[0]] == '-'))
            {
                // Throw an exception for invalid expression end
                throw new Exception("Invalid expression");
            }
        }

        private static void ParseTerm(string expression, List<int> indexList)
        {
            // Parse the first factor of the term
            ParseFactor(expression, indexList);

            // Continue parsing while encountering multiplication or division operators
            while (indexList[0] < expression.Length && (expression[indexList[0]] == '*' || expression[indexList[0]] == '/'))
            {
                indexList[0]++; // Move past the operator
                ParseFactor(expression, indexList);
            }
        }

        private static void ParseFactor(string expression, List<int> indexList)
        {
            // Check for opening parenthesis
            if (indexList[0] < expression.Length && (expression[indexList[0]] == '('))
            {
                indexList[0]++; // Move past the opening parenthesis
                                // Recursively parse the expression inside the parentheses
                ParseExpression(expression, indexList);

                // Check for closing parenthesis
                if (indexList[0] < expression.Length && (expression[indexList[0]] == ')'))
                {
                    indexList[0]++; // Move past the closing parenthesis
                }
                else
                {
                    // Throw an exception for mismatched parentheses
                    throw new Exception("Mismatched parentheses");
                }
            }
            // Check for unary operators
            else if (indexList[0] < expression.Length && (expression[indexList[0]] == '+' || expression[indexList[0]] == '-') &&
                     (indexList[0] == 0 || expression[indexList[0] - 1] == '+' || expression[indexList[0] - 1] == '-' ||
                      expression[indexList[0] - 1] == '*' || expression[indexList[0] - 1] == '/'))
            {
                indexList[0]++; // Move past the unary operator
                ParseFactor(expression, indexList);
            }
            else
            {
                // If not an opening parenthesis or unary operator, parse the number
                ParseNumber(expression, indexList);
            }

            // Check for division by zero after parsing the factor
            if (indexList[0] < expression.Length && expression[indexList[0]] == '/' &&
                (indexList[0] + 1 < expression.Length && expression[indexList[0] + 1] == '0'))
            {
                // Throw an exception for division by zero
                throw new Exception("Division by zero");
            }
        }

        private static void ParseNumber(string expression, List<int> indexList)
        {
            // Check for a valid numeric expression
            bool hasDigit = false;

            // Check if the first character is a digit or a dot followed by a digit
            if (indexList[0] < expression.Length && (char.IsDigit(expression[indexList[0]]) ||
                (expression[indexList[0]] == '.' && (indexList[0] + 1 < expression.Length && char.IsDigit(expression[indexList[0] + 1])))))
            {
                // Move past the digits or dot
                while (indexList[0] < expression.Length && (char.IsDigit(expression[indexList[0]]) ||
                    (expression[indexList[0]] == '.' && !hasDigit)))
                {
                    if (expression[indexList[0]] == '.')
                    {
                        if (hasDigit)
                        {
                            // Throw an exception for invalid numeric expression
                            throw new Exception("Invalid numeric expression");
                        }
                        hasDigit = true;
                    }
                    indexList[0]++;
                }
            }
            else
            {
                // Throw an exception for invalid numeric expression
                throw new Exception("Invalid numeric expression");
            }
        }




        //i cheated a bit here by using DataTables 
        //if it works it works
        public static double EvaluateMathExpression(string expression)
        {
            try
            {
                if (!IsValidMathExpression(expression))
                {
                    throw new InvalidOperationException($"Invalid expression {expression}");
                }

                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                return double.Parse((string)row["expression"]);

            }
            catch (Exception) 
            {
                return double.PositiveInfinity;
            }
        }
    }
}
