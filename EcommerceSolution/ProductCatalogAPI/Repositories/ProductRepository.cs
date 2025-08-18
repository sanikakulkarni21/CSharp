using ProductCatalogAPI.Entities;

namespace ProductCatalogAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return Task.FromResult<IEnumerable<Product>>(new List<Product>());
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            return Task.FromResult<Product?>(null);
        }

        public Task<Product> CreateProductAsync(Product product)
        {
            return Task.FromResult(product);
        }

        public Task<Product> UpdateProductAsync(Product product)
        {
            return Task.FromResult(product);
        }

        public Task<bool> DeleteProductAsync(int id)
        {
            return Task.FromResult(true);
        }
    }
}