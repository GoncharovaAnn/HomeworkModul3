using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Journal
{
    class Shop
    {
        public string Name, Description, Number, Email, Adress;
        public void Print(string Name, string Adress, string Description, string Number, string Email)
        {
            WriteLine("Название магазина: {0}\nАдрес: {1}\nОписание: {2}\nКонтактный телефон: {3}\nКонтактный e-mail: {4}\n", Name, Adress, Description, Number, Email);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            WriteLine("Введите название магазина: ");
            shop.Name = ReadLine();
            WriteLine("Введите адрес магазина: ");
            shop.Adress = ReadLine();
            WriteLine("Введите описание магазина: ");
            shop.Description = ReadLine();
            WriteLine("Введите контактный телефон: ");
            shop.Number = ReadLine();
            WriteLine("Введите контактный e-mail: ");
            shop.Email = ReadLine();

            shop.Print(shop.Name, shop.Adress, shop.Description, shop.Number, shop.Email);
        }
    }
}
