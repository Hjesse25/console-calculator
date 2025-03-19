Console.WriteLine("-------- Welcome to the Console Calculator --------");

do
{
    Console.WriteLine("Choose a number based on the desired operation");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Modulo");
    Console.WriteLine("6. Exit");

    try
    {
        int input = Convert.ToInt32(Console.ReadLine());

        if (input == 6)
        {
            break;
        }

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (input)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"{num1} x {num2} = {result}");
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                break;
            case 5:
                result = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {result}");
                break;
        }

    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input type");
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("Input cannot be empty");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e}");
    }
    Console.WriteLine("Press [enter] to continue");
    ConsoleKeyInfo key;
    do
    {
        key = Console.ReadKey(true);
    } while (key.Key != ConsoleKey.Enter);
    Console.Clear();
} while (true);

Console.WriteLine("Thank you for using the console calculator, goodbye!");
