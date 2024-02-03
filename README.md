# Calculator Application

This is a simple calculator application with a graphical user interface built using Windows Forms in C#. The calculator supports basic arithmetic operations, including addition, subtraction, multiplication, and division. Additionally, it provides the functionality to evaluate mathematical expressions and perform error checking.

## Features

- Input buttons for digits (0-9), decimal point, and basic arithmetic operators (+, -, *, /).
- Clear button to reset the input.
- Backspace button to remove the last entered character.
- Equal button to evaluate the entered expression.
- Error checking for invalid expressions and division by zero.
- Additional functionalities: "con" command to open a console window and testing functionality.

## Usage

1. **Numeric Input**: Click on the numeric buttons (0-9) to enter digits.
2. **Arithmetic Operators**: Click on the buttons (+, -, *, ÷) to enter arithmetic operators.
3. **Decimal Point**: Click on the dot button to insert a decimal point.
4. **Clear**: Click on the "AC" button to clear the input.
5. **Backspace**: Click on the backspace button to remove the last entered character.
6. **Evaluate**: Click on the equal button or press Enter key to evaluate the entered expression.
7. **Console**: Typing "con" in the input box and pressing Enter will open a console window.
8. **Testing**: Typing "test" in the console window and entering a count will perform random tests on the calculator logic.

## Calculator Logic

The calculator logic is implemented in the `CalculatorLogic` class, providing methods for checking the validity of mathematical expressions (`IsValidMathExpression`) and evaluating expressions (`EvaluateMathExpression`). The logic uses a recursive descent parser to handle parsing and evaluating mathematical expressions.

## Console Window

The console window allows users to execute additional commands like "test" for testing the calculator's functionality. The test command performs random tests and displays any discrepancies in the results.

## Dependencies

- C# (Windows Forms)
- .NET Framework

## How to Run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the Calculator project.

Feel free to contribute or report issues!
