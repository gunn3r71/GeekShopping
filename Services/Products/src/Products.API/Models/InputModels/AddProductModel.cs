using System;
using GeekShopping.Services.Products.Domain.ValueObjects;

namespace GeekShopping.Services.Products.API.Models.InputModels
{
    public class AddProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Money Price { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
    }
}
