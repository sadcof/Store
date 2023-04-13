using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystalsPiece;
            int crystalsCost = 15;

            Console.WriteLine($"Добро пожаловать в магазин кристаллов! Один кристалл стоит {crystalsCost} голды.");
            Console.Write("Ведите ваше количество голды: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество кристаллов, которое хотите купить: ");
            crystalsPiece = Convert.ToInt32(Console.ReadLine());

            gold -= crystalsPiece * crystalsCost;
            Console.WriteLine($"У вас осталось голды: {gold}; вы купили кристаллов: {crystalsPiece} шт");

            Console.ReadKey();
        }
    }
}
