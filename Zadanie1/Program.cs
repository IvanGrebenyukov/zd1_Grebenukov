using System;

namespace Zadanie1
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                Console.WriteLine("Введите название кошки (только буквы)");
                string nameCat = Console.ReadLine();
                Console.WriteLine("Введите ее вес: ");
                double weightCat = double.Parse(Console.ReadLine());
                Cat cat = new Cat(nameCat, weightCat);
                cat.Meow();
                cat.CountWeight();
            }
            catch
            {
                Console.WriteLine("Вы ввели неправильно вес кошки!");
            }
        }
    }
}
