using Microsoft.EntityFrameworkCore;

namespace OnlineShopp.DB
{
    public class ProductsDBRepository : IProductsDBRepository
    {
        private readonly DatabaseContext dbContext;

        // Добавьте тестовые товары (используем PathPicture, а не PathImage)
        private static List<ProductDB> _testProducts = new List<ProductDB>()
        {
            new ProductDB
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Пирожок",
                Description = "с котятами",
                Cost = 50,
                PathPicture = "https://cs14.pikabu.ru/post_img/2022/03/21/6/1647856655122391644.jpg"
            },
            new ProductDB
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Чебурек",
                Description = "с вишней",
                Cost = 80,
                PathPicture = "https://optim.tildacdn.com/tild3635-3764-4331-b832-633037643133/-/resize/340x/-/format/webp/cheb.png.webp"
            },
            new ProductDB
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Тортик",
                Description = "медовик",
                Cost = 90,
                PathPicture = "/images/img_cake.jpg"
            },
            new ProductDB
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Name = "Колбаса",
                Description = "сервелат",
                Cost = 1300,
                PathPicture = "/images/sausage.jpg"
            },
            new ProductDB
            {
                Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                Name = "Игра",
                Description = "имитация",
                Cost = 1300,
                PathPicture = "https://moretorg55.ru/d/763c5388b8a310c97cc46f0bbeab94fb.jpg"
            }
        };

        public ProductsDBRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        void IProductsDBRepository.Add(ProductDB product)
        {
            throw new NotImplementedException();
        }

        List<ProductDB> IProductsDBRepository.GetAll()
        {
           
            var temp = dbContext.ProductDBs;
            if (temp != null && temp.Any())
                return temp.ToList();

            return _testProducts;
        }

        ProductDB IProductsDBRepository.TryGetById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IProductsDBRepository.Update(ProductDB product)
        {
            throw new NotImplementedException();
        }
    }
}