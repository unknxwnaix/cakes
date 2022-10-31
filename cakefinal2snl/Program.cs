using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
namespace тортики2snl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                menu1();
                Console.WriteLine("Если вы хотите сделать еще один заказ, нажмите Escape");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                text();
                if (key.Key != ConsoleKey.Escape)
                {
                    break;
                }
            }
            Console.Clear();
        }
        static void text()
        {
            Console.WriteLine("Заказ тортов в ГЛАЗУРЬКА, торты на ваш выбор!");
            Console.WriteLine("Выберите параметры торта");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Цена: ");
            Console.WriteLine("Ваш торт: ");
        }
        static void menu1()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int position = 3;
            int cena = 0;
            List<string> nazvaniya = new List<string>();
            while (true)
            {
                Console.Clear();
                text();
                position = Pos(key, position);
                if (position < 3) // нижний предел выбора (стрелочка не идет ниже)
                {
                    position = 3;
                }
                if (position > 12) // верхний предел кода (стрелочка не идет выше)
                {
                    position = 12;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter && position == 9)
                {
                    Console.Clear();

                    break; //выход из проги 
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    var a = Menu2(key, position);
                    Console.Clear();
                    text();
                    cena = cena + a.Item1;
                    nazvaniya.Add(a.Item2);
                }
                Console.SetCursorPosition(7, 11);
                Console.WriteLine(cena);
                Console.SetCursorPosition(11, 12);
                foreach (string i in nazvaniya)
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
                ConsoleKeyInfo keyA = Console.ReadKey();
                key = keyA;
                Console.Clear();
            }
            Console.Clear();
            zakaz.full(cena, nazvaniya);
        }
        static int Pos(ConsoleKeyInfo key2, int pos2)
        {
            if (key2.Key == ConsoleKey.DownArrow) // вниз
            {
                pos2++;
            }
            if (key2.Key == ConsoleKey.UpArrow) // вверх
            {
                pos2--;
            }
            return pos2;
        }
        static Tuple<int, string> Menu2(ConsoleKeyInfo key1, int pos1)
        {
            string elements = "";
            int summ = 0;
            int posA = 0;
            string a = "";
            int b = 0;
            while (true)
            {
                int posout = pos1 - 3;
                zakaz menupart = zakaz.Menu(posout);
                for (int i = 0; i < 5; i++)
                {
                    a = menupart.name[i];
                    b = menupart.cost[i];
                    Console.Write("  ");
                    Console.Write(a);
                    Console.Write(" - ");
                    Console.WriteLine(b);
                }

                posA = Pos(key1, posA);
                if (posA < 0) // нижний предел выбора (стрелочка не идет ниже)
                {
                    posA = 4;
                }
                if (posA > 4) // верхний предел кода (стрелочка не идет выше)
                {
                    posA = 0;
                }
                Console.SetCursorPosition(0, posA);
                Console.WriteLine("->");
                ConsoleKeyInfo keyA = Console.ReadKey();
                key1 = keyA;
                Console.Clear();
                if (keyA.Key == ConsoleKey.Enter)
                {
                    summ = menupart.cost[posA];
                    elements = menupart.name[posA];
                    break;
                }
            }
            return Tuple.Create(summ, elements);
        }
    }
}