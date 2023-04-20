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


            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadLine();
        }

    }
}
