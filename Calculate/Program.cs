namespace Calculate
{
    enum Operation
    {
        Add = '+',
        Sub = '-',
        Mul = '*',
        Div = '/',

    }
    internal class Program
    {
        int parseConsole(string asq)
        {
            Console.Write(asq);
            return int.Parse(Console.ReadLine());
        }

        Operation parseOperation(string asq)
        {
            Console.Write(asq);
            switch (Console.ReadLine()){
                case "+": return Operation.Add;
                case "-": return Operation.Sub;
                case "*": return Operation.Mul;
                case "/": return Operation.Div;
                default: return Operation.Add;
            }
        }

        double calculate(int number1, int number2, Operation operation)
        {
            switch (operation)
            {
                case Operation::Add:
                    return number1 + number2;
                case Operation::Sub:
                    return number1 - number2;
                case Operation::Mul:
                    return number1 * number2;
                case Operation::Div:
                    return (double)number1 / (double)number2;
                default:
                    return number1 + number2;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Андрей !");

            int number1 = parseConsole("Первое число: ");

            int number2 = parseConsole("Второе число: ");

            Operation operation = parseOperation("Операция: ");

            double result = calculate(number1, number2, operation);


            Console.WriteLine(number1 + " " + operation + " " + number2 + " = " + result);


            #region Циклы
            //string[] elements;
            //bool numbersIsCorrect = false;

            //do
            //{
            //    Console.Write("Введите выражение: "); // 10 + 4
            //    string expression = Console.ReadLine();

            //    elements = expression.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //    int number1 = int.Parse(elements[0]); // 1-10
            //    int number2 = int.Parse(elements[2]); // 1-10

            //    if ((number1 < 1 || number1 > 10) || (number2 < 1 || number2 > 10))
            //    {
            //        Console.WriteLine("Числа могут быть только от 1 до 10 включительно!");
            //        continue;
            //    }

            //    numbersIsCorrect = true;
            //}
            //while (elements.Length != 3 || numbersIsCorrect == false);
            #endregion
        }
    }
}
