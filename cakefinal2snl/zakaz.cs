using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Drawing;
using cakefinal2snl;

namespace тортики2snl
{
    internal class zakaz
    {
        public static avtozak[] zakaz1;
        public zakaz()
        {
            avtozak shape = new avtozak(new string[] { "Круглый", "Квадратный", "Треугольный", "Сердечко", "Особая" }, new int[] { 1500, 1500, 1700, 1800, 2000 });
            avtozak size = new avtozak(new string[] { "Маленький", "Cредний", "Большой", "На заказ", "Свадебный" }, new int[] { 4000, 5200, 6500, 10000, 50000 });
            avtozak taste = new avtozak(new string[] { "Ванильный", "Шоколадный", "Карамельный", "Ягодный", "Экзотический" }, new int[] { 1500, 1500, 1550, 1500, 2050 });
            avtozak amount = new avtozak(new string[] { "1 корж", "2 коржа", "3 коржа", "4 коржа", "5 коржей" }, new int[] { 1300, 1600, 1900, 2200, 2500 });
            avtozak glaze = new avtozak(new string[] { "Шоколад", "Крем", "Бизе", "Драже", "Ягоды" }, new int[] { 500, 600, 650, 750, 1000 });
            avtozak decor = new avtozak(new string[] { "Шоколадная", "Ягодная", "Кремовая", "Особая", "Особая ++" }, new int[] { 1150, 1200, 1250, 1600, 4000 });
            zakaz1 = new avtozak[] { shape, size, taste, amount, glaze, decor };
        }
        public avtozak Menu2 (int posin)
        {
            avtozak menupart = zakaz1[posin];
            return menupart;
        }
        public void file(int sumin, List<string> cake)
        {
            string path = "/Users/aix/Desktop/для заказов/Заказ_торта.txt";
            File.AppendAllText(path, "Заказ от: " + DateTime.Today + "\n" + "Ваш торт: " + string.Join(", ", cake) + "\n" + "Сумма заказа: " + sumin + "\n" + "\n");
        }
    }
}