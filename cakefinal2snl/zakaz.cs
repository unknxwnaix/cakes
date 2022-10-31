using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace тортики2snl
{
    internal class zakaz
    {
        public string[] name = new string[5];
        public int[] cost = new int[5];
        public static void full(int sumin, List<string> cake)
        {
            string a = string.Join(", ", cake);
            string path = "C:\\Рабочий стол\\cake\\Заказ_торта.txt";
            File.AppendAllText(path, "Заказ от: " + DateTime.Today + "\n");
            File.AppendAllText(path, "Ваш торт: " + a + "\n");
            File.AppendAllText(path, "Сумма заказа: " + sumin + "\n" + "\n");
        }

        public static zakaz Menu(int posin)
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
    }
}