using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            int vibor;
            int osh;
            CashRegister game = new CashRegister();
            Console.WriteLine("Добро пожаловать в магазин одежды, чего вы бы хотели?");
            do
            {
                osh = 0;
                Console.WriteLine("На выбор есть 1 - приобретение товара, 2 - сумма всей покупки, 3 - список товаров магазина, 4 - отчистить список пакупок, 5 - итог.");
                vibor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (vibor < 1 || vibor > 5)
                {
                    Console.WriteLine("Вы ввели не то число");
                }
                if (vibor == 1)
                {
                    game.purchase_item();
                }
                if (vibor == 2)
                {
                    game.get_total();
                }
                if (vibor == 3)
                {
                    game.show_items();
                }
                if (vibor == 4)
                {
                    game.clear();
                }
                if (vibor == 5)
                {
                    game.itog();
                    osh++;
                }
            } while (osh == 0);
        }

    }
}
