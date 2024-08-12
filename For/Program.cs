using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int repeatMessage;

            Console.WriteLine($"Введите сообщение которое будет повторяться");
            message = Console.ReadLine();
            Console.WriteLine($"ВВедите количество повторений");
            repeatMessage = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < repeatMessage; i++)
            {
                Console.WriteLine(message);
            }

            Console.ReadKey();
        }
    }
}
