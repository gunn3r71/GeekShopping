using System;

namespace GeekShopping.Services.Products.API.Models.OutputModels
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryName { get; set; }
        public Guid CategoryId { get; set; }
    }
}
