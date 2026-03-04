using Xunit.Sdk;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operand2 == 0) return "Division by zero is not allowed.";

        switch (operation)
        {
            case "+": return $"{operand1} + {operand2} = {operand1 + operand2}";
            case "*": return $"{operand1} * {operand2} = {operand1 * operand2}";
            case "/": return $"{operand1} / {operand2} = {operand1 / operand2}";
            case "": throw new ArgumentException();
            case null: throw new ArgumentNullException();
            default: throw new ArgumentOutOfRangeException();
        }
    }
}
