using System;
using System.Collections;

namespace IND_1
{
    public class OOP
    {

        public struct Item
        {
            public String Name;
            public String Type;
            public int Age;
            public int Exp;

            public Item(string Name, String Type, int Age, int Exp)
            {
                this.Name = Name;
                this.Type = Type;
                this.Age = Age;
                this.Exp = Exp;

            }

            public void Print()
            {
                Console.WriteLine($"|{this.Name,-24}|{this.Type,-12}|{this.Age,-20}|{this.Exp,-15}|");

            }
        }

        private static void Main()
        {
            ArrayList list = new();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("ФИО:");
                string Name = Console.ReadLine();

                Console.WriteLine("Тип деятельности: Т-тренер, С-спортсмен");
                string Type = Console.ReadLine();

                Console.WriteLine("Введите год рождения:");
                int Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите опыт работы(лет):");
                int Exp = int.Parse(Console.ReadLine());
                Item value = new(Name, Type, Age, Exp);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить строку?\nДа - продолжить\nНет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }

            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Состав спортклуба:",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|ФИО:",-25}|{"Тип: ",-12}|{"Год рождения:",-20}|{"Опыт (лет):",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: Т - тренер, С - спортсмен",-75}|");
            Console.WriteLine(new String('-', 76));
        }

    }
}