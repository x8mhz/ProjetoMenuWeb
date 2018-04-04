using System;

namespace ProjetoMenuWeb.Domain.Entities
{
    public class Product
    {
        public Product(int id, string brand, string model, string description, int amount, decimal price)
        {
            Id = id;
            Code = Guid.NewGuid();
            Brand = brand;
            Model = model;
            Description = description;
            Date = DateTime.Now;
            Amount = amount;
            Price = price;
            Total = Amount * Price;
        }

        public int Id { get; private set; }
        public Guid Code { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public int Amount { get; set; }
        public decimal Price { get; private set; }
        public decimal Total { get; private set; }
    }
}