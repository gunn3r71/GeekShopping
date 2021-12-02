using System;
using GeekShopping.Services.Products.Domain.Entities.Base;
using GeekShopping.Services.Products.Domain.ValueObjects;

namespace GeekShopping.Services.Products.Domain.Entities
{
    public class Product : Entity
    {
        protected Product()
        {
        }

        public Product(string name,
            Money price,
            string description, 
            Guid categoryId)
        {
            Name = name;
            Price = price;
            Description = description;
            CategoryId = categoryId;
        }

        public string Name { get; private set; }
        public Money Price { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }
        public bool Removed { get; private set; }

        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }
        
        public void SetRemove()
        {
            //TODO - Adicionar notification pattern
            Removed = true;
        }
    }
}
