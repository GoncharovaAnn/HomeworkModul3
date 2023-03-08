using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Journal
{
    class Shop
    {
        public string Name, Description, Number, Email, Adress;
        public int S;
        public int x;
        public void Print(string Name, string Adress, string Description, string Number, string Email, int S)
        {
            WriteLine("Название магазина: {0}\nАдрес: {1}\nОписание: {2}\nКонтактный телефон: {3}\nКонтактный e-mail: {4}\n Площадь магазина: {5}\n", Name, Adress, Description, Number, Email, S);
        }
        public static Shop operator +(Shop a, Shop b)
        {
            return new Shop { S = a.S + b.S };
        }
        public static Shop operator -(Shop a, Shop b) 
        {
            return new Shop { S = a.S - b.S };
        }
        public static bool operator >(Shop a, Shop b)
        {
            return a.S > b.S;
        }
        public static bool operator <(Shop a, Shop b)
        {
            return a.S < b.S;
        }
        public static bool operator ==(Shop a, Shop b)
        {
            return a.S == b.S;
        }
        public static bool operator !=(Shop a, Shop b) 
        {
            return !(a == b);
        }
    }
    internal class Program
    {
        static Shop GetShop()
        {
            Shop shop1 = new Shop();
            
            shop1.Name = "Ромашка";
            shop1.Description = "Магазин фермерской продукции";
            shop1.Adress = "ул. Ленина д.4";
            shop1.Number = "40389579876";
            shop1.Email = "Romashka@gmail.com";
            shop1.S = 142;
            return shop1;
        }
        static Shop GetShopGetShop()
        {
            Shop shop2 = new Shop();

            shop2.Name = "Фасоль";
            shop2.Description = "Магазин музыкальных инструментов";
            shop2.Adress = "ул. Гагарина д.5";
            shop2.Number = "34837295872";
            shop2.Email = "FaSol@gmail.com";
            shop2.S = 512;

            return shop2;
        }
        static void Main(string[] args)
        {
            //Извините, додоелаю потом 😢
        }
    }
}
