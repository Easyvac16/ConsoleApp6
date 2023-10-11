namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);
            string operation = args[2];

            int result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"Результат: {result}");


        }


    }


}