internal class Arithmetic
{
    public void SimpleCalculator()
    {
        Console.WriteLine("Enter the first number:");
        string num1String = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string num2String = Console.ReadLine();

        Console.WriteLine("Choose an operation: +, -, *, /");
        string op = Console.ReadLine();

        if(int.TryParse(num1String, out int num1) && int.TryParse(num2String, out int num2))
        {
            switch(op)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;

                case "/":
                    if(num2 != 0)
                    {
                        Console.WriteLine($"Result: {(float)num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. You must enter 2 integers.");
        }
    }
}
