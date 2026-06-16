using OnlineShopp.DB;

namespace OnLineShop2026.Data
{
    public class ProductsRepositoryInMemory : IProductsDBRepository
    {
        private static List<ProductDB> products = new List<ProductDB>()
        {
            new ProductDB { Name = "Колбаса", Description = "сервелат", Cost = 1300, PathPicture = "/images/sausage.jpg" },
            new ProductDB { Name = "Пирожок", Description = "с котятами", Cost = 50, PathPicture = "https://cs14.pikabu.ru/post_img/2022/03/21/6/1647856655122391644.jpg" },
            new ProductDB { Name = "Тортик", Description = "медовик", Cost = 90, PathPicture = "/images/img_cake.jpg" },
            new ProductDB { Name = "Игра", Description = "имитация", Cost = 1300, PathPicture = "https://moretorg55.ru/d/763c5388b8a310c97cc46f0bbeab94fb.jpg" },
            new ProductDB { Name = "Чебурек", Description = "с вишней", Cost = 80, PathPicture = "https://optim.tildacdn.com/tild3635-3764-4331-b832-633037643133/-/resize/340x/-/format/webp/cheb.png.webp" }
        };

        public List<ProductDB> GetAll()
        {
            return products;
        }

        public ProductDB TryGetById(Guid id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(ProductDB product)
        {
            products.Add(product);
        }

        public void Update(ProductDB product)
        {
            var existing = TryGetById(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Description = product.Description;
                existing.Cost = product.Cost;
                existing.PathPicture = product.PathPicture;
            }
        }
    }
}
