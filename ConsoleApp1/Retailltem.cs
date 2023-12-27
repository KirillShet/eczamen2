using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Retailltem
    {
        protected string[] name = new string[3] { "Пиджак", "Дизайнерские джинсы", "Рубашка" };
        protected string[] numb = new string[3] { "Товар1", "Товар2", "Товар3" };
        protected int[] col = new int[3] { 12, 40, 20 };
        protected float[] cell = new float[3] { (float)59.95, (float)34.95, (float)24.95 };
        public void info()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Номер товара: " + numb[i]);
                Console.WriteLine("Описание: " + name[i]);
                Console.WriteLine("Кол-во на складе: " + col[i]);
                Console.WriteLine("Цена за штуку: " + cell[i]);
            }
        }
    }
}
