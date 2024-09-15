namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Андрей !");

            Console.Write("Первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Операция: ");
            string operation = Console.ReadLine();

            double result = 0;
            if (operation == "-")
            {
                result = number1 - number2;
            }
            if (operation == "*")
            {
                result = number1 * number2;
            }
            if (operation == "+")
            {
                result = number1 + number2;
            }
            if (operation == "/")
            {
                result = (double)number1 / (double)number2;
            }
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
