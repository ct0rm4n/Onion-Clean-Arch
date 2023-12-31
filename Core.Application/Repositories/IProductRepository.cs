﻿
using Application.Repositories;
using Core.Domain.Entities.Concrates.Catalog;

namespace Application.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<IEnumerable<Product>> GetProducts();
        public Task<Product> GetProduct(int id);
        public Task<IEnumerable<Product>> GetProductsByCount(int count);

    }
}
