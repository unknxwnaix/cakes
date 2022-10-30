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
        static zakaz Menu(int posin)
        {
            zakaz shape = new zakaz();
            shape.name[0] = "Круглый";
            shape.name[1] = "квадратный";
            shape.name[2] = "Треугольный";
            shape.name[3] = "Сердечко";
            shape.name[4] = "Особая";
            shape.cost[0] = 500;
            shape.cost[1] = 500;
            shape.cost[2] = 500;
            shape.cost[3] = 700;
            shape.cost[4] = 800;
            zakaz size = new zakaz();
            size.name[0] = "Маленький";
            size.name[1] = "Cредний";
            size.name[2] = "Большой";
            size.name[3] = "На заказ";
            size.name[4] = "Свадебный";
            size.cost[0] = 1000;
            size.cost[1] = 1200;
            size.cost[2] = 1500;
            size.cost[3] = 2000;
            size.cost[4] = 5000;

            zakaz taste = new zakaz();
            taste.name[0] = "Ванильный";
            taste.name[1] = "Шоколадный";
            taste.name[2] = "Карамельный";
            taste.name[3] = "Ягодный";
            taste.name[4] = "Кокосовый";
            taste.cost[0] = 100;
            taste.cost[1] = 100;
            taste.cost[2] = 150;
            taste.cost[3] = 200;
            taste.cost[4] = 250;

            zakaz amount = new zakaz();
            amount.name[0] = "1 корж";
            amount.name[1] = "2 коржа";
            amount.name[2] = "3 коржа";
            amount.name[3] = "4 коржа";
            amount.name[4] = "5 коржей";
            amount.cost[0] = 200;
            amount.cost[1] = 400;
            amount.cost[2] = 600;
            amount.cost[3] = 800;
            amount.cost[4] = 1000;

            zakaz glaze = new zakaz();
            glaze.name[0] = "Шоколад";
            glaze.name[1] = "Крем";
            glaze.name[2] = "Бизе";
            glaze.name[3] = "Драже";
            glaze.name[4] = "Ягоды";
            glaze.cost[0] = 100;
            glaze.cost[1] = 100;
            glaze.cost[2] = 150;
            glaze.cost[3] = 150;
            glaze.cost[4] = 200;

            zakaz decor = new zakaz();
            decor.name[0] = "Шоколадная";
            decor.name[1] = "Ягодная";
            decor.name[2] = "Кремовая";
            decor.name[3] = "Особая";
            decor.name[4] = "Особая ++";
            decor.cost[0] = 150;
            decor.cost[1] = 150;
            decor.cost[2] = 150;
            decor.cost[3] = 200;
            decor.cost[4] = 1000;

            zakaz[] zakaz = new zakaz[] { shape, size, taste, amount, glaze, decor };
            zakaz menupart = zakaz[posin];
            return menupart;
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
                zakaz menupart = Menu(posout);
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