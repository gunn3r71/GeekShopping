using GeekShopping.Services.Products.Domain.Entities.Base;

namespace GeekShopping.Services.Products.Domain.Entities
{
    public class Category : Entity
    {
        protected Category()
        {
        }

        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
