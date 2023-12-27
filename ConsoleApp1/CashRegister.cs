using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CashRegister : Retailltem
    {
        private int vibor;
        private float deng;
        private float sum;
        private int prov;
        private int col_2;
        private int osh;
        private int[] pocup = new int[3];
        public void purchase_item()
        {
            do
            {
                osh = 0;
                Console.WriteLine("Выберите какой товар вы хотите приобрести (от 1 до 3):");
                vibor = Convert.ToInt32(Console.ReadLine());
                if (vibor < 1 || vibor > 3)
                {
                    Console.WriteLine("Вы ввели не то число");
                    osh++;
                }
                else
                {
                    vibor = vibor - 1;
                    do
                    {
                        osh = 0;
                        Console.WriteLine("Введите кол-во покупаемого товара: " + "(максимум товара: " + col[vibor] + ")");
                        Console.WriteLine("В вашем списке: " + pocup[vibor]);
                        col_2 = Convert.ToInt32(Console.ReadLine());
                        prov = col_2 + pocup[vibor];
                        if (col[vibor] < prov)
                        {
                            Console.WriteLine("К слжалению, на складе нет такого кол-ва товара.");
                            osh++;
                        }
                        else if (col_2 == 0)
                        {
                            Console.WriteLine("Кол-во товара в списке покупок не изменилось.");
                        }
                        else
                        {
                            Console.WriteLine("Покупка была добавлена в общий список.");
                            pocup[vibor] += col_2;
                        }
                    } while (osh == 1);
                }
            } while (osh == 1);
        }
        public void get_total()
        {
            sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += pocup[i] * cell[i];
            }
            Console.WriteLine("Общая стоимость покупки составляет: " + sum);
        }
        public void show_items()
        {
            info();
        }
        public void clear()
        {
            for (int i = 0; i < 3; i++)
            {
                pocup[i] = 0;
            }
        }
        public void itog()
        {
            for (int i = 0; i < 3; i++)
            {
                sum = pocup[i] * cell[i];
                Console.WriteLine("Номер товара: " + numb[i]);
                Console.WriteLine("Описание: " + name[i]);
                Console.WriteLine("Кол-во на складе: " + pocup[i]);
                Console.WriteLine("Цена: " + sum);
            }
            get_total();
        }
    }
}
