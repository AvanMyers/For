using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int repeatMassage;

            Console.WriteLine($"Введите сообщение которое будет повторяться");
            message = Console.ReadLine();
            Console.WriteLine($"ВВедите количество повторений");
            repeatMassage = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < repeatMassage; i++)
            {
                Console.WriteLine(message);
            }

            Console.ReadKey();
        }
    }
}
