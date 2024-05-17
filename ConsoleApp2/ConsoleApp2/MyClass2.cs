using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //задание 2
    public struct Notebook
    {
        private string Model;
        private string Manufacturer;
        private double Price;

        public Notebook(string model, string manufacturer, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }
        public void Show()
        {
            Console.WriteLine($"Модель: {Model}\nПроизводитель: {Manufacturer}\nЦена: {Price}");
        }
    }
    class MyClass2
    {

    }
}
