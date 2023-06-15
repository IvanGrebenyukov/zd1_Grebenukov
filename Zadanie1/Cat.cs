using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Cat
    {
        private string name;
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                try
                {
                    if(value <= 0)
                    {
                        Console.WriteLine("Недопустимое значение веса!!!");
                    } 
                    else
                    {
                        weight = value;
                    }
                } 
                catch
                {
                    Console.WriteLine("Недопустимое значение веса!!!");
                }
            }
        }
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters && value.Length != 0)
                {
                    name = value;
                } else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public Cat (string CatName, double Catweight)
        {
            Name = CatName;
            Weight = Catweight;
        }
        public void CountWeight()
        {
            if (weight == 0)
            {
                Console.WriteLine("Вы ввели неправильный вес кошки");
            }

            else if (name == null || name.Length == 0)
            {
                
            }
            else
                Console.WriteLine($"Кот с кличкой '{name}' имеет вес: {weight} кг");
        }
        public void Meow ()
        {
            if (name == null || name.Length == 0)
            {
               
            }
            else
            {
                Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
            }
        }
        
    }
}
