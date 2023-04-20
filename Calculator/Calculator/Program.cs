class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            double firstValue, secondValue;
            string action;

            try
            {
                Console.WriteLine("Введите число_1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число_2");
                secondValue = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("не удалось преобразовать строки ");
                Console.ReadLine();
                continue;
            }

            Console.WriteLine("Выбор операции '+' '-' '*' '/'");
            action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine(firstValue + secondValue);
            }
            else if (action == "-")
            {
                Console.WriteLine(firstValue - secondValue);
            }
            else if (action == "*")
            {
                Console.WriteLine(firstValue * secondValue);
            }
            switch (action)
            {
                case "/":
                    if (secondValue == 0)
                    {

                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
  
            Console.ReadLine();
        }

    }
}
