using OnLineShop2026.Models;

namespace OnLineShop2026.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? TryGetById(Guid id);
    }
}