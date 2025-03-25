using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculator App");
                Console.WriteLine("________________");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an operation (1-5): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                
                Console.Write("Please enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = 0;
                bool validOperation = true;
                var calculator = new Calculator();
                
                switch (choice)
                {
                    case 1:
                        result = calculator.Add(num1, num2);
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;
                    case 2:
                        result = calculator.Subtract(num1, num2);
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;
                    case 3:
                        result = calculator.Multiply(num1, num2);
                        Console.WriteLine($"{num1} * {num2} = {result}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                            validOperation = false;
                        }
                        else
                        {
                            result = calculator.Divide(num1, num2);
                            Console.WriteLine($"{num1} / {num2} = {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select 1-5.");
                        validOperation = false;
                        break;
                }
                

                if (validOperation)
                {
                    Console.WriteLine($"Result: {result}");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
      
    }
    
    
    public class Calculator 
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}