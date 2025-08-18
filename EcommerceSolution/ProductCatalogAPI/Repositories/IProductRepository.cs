﻿
using ProductCatalogAPI.Entities;

namespace ProductCatalogAPI.Repositories
{
    public interface IProductRepository
    {
        //crud operations
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int id);

    }
}
