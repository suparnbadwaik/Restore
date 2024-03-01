using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new() {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Product 1 Description",
                    Brand = "Brand 1",
                    Price = 10,
                    QuantityInStock = 10,
                    Type = "Electronics",
                    PictureUrl = "1.jpg"
                },
                new() {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Product 2 Description",
                    Brand = "Brand 2",
                    Price = 20,
                    QuantityInStock = 20,
                    Type = "Electronics",
                    PictureUrl = "2.jpg"
                },
                new() {
                    Id = 3,
                    Name = "Product 3",
                    Description = "Product 3 Description",
                    Brand = "Brand 3",
                    Price = 30,
                    QuantityInStock = 30,
                    Type = "Electronics",
                    PictureUrl = "3.jpg"
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}