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
            int ownGold;
            int crystals;
            int crystalscost = 15;

            Console.WriteLine($"Добро пожаловать в магазин кристаллов! Один кристалл стоит {crystalscost} голды.");
            Console.Write("Ведите ваше количество голды: ");
            ownGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество кристаллов, которое хотите купить: ");
            crystals = Convert.ToInt32(Console.ReadLine());

            ownGold -= crystals * crystalscost;
            Console.WriteLine($"У вас осталось голды: {ownGold}; вы купили кристаллов: {crystals} шт");

            Console.ReadKey();
        }
    }
}
