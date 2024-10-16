# Credit Card Number Verification Application

This is a simple console application for a given credit card number verifier. This application uses the Luhn algorithm to establish whether a given card number, entered by the user, is valid or not.

## Features
- Accepts a 16-digit card number from the user.
- Implements the Luhn algorithm to verify the validity of the card number.
- Allows multiple card number validations within one session.
- Input validation allows users to correct input upon failure with an appropriate hint.

## How It Works
The spine of the application is the Luhn algorithm, which is implemented in the `LuhnAlgoritm` method. This method checks whether a given number of cards is valid by:
1. Doubling every second digit from right to left.
2. Summing all the digits of the resulting numbers along with the undoubled digits.
3. Checking if the total is divisible by 10.

If the sum is divisible by 10, then the card number is valid.

## Example
- **Input**: 4532015112830366
- **Output**: "The Card Number Entered is Valid"

## File Structure
- `Program.cs`: This contains the main program. It takes the user's input and displays the output.
- `Func.cs`: This contains the utility functions, Luhn algorithm implementation, input validation, and formatting of the methods.



