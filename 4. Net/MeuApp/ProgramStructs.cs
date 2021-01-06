using System;

namespace MeuApp
{
    class ProgramStructs
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse gamer", 299.97);

            Console.WriteLine(mouse.Id)
            Console.WriteLine(mouse.Name)
            Console.WriteLine(mouse.Price)
        }
    }
    struct Product
    {
        public Product(int id, string, double Price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}