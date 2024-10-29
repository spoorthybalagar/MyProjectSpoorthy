 using Microsoft.EntityFrameworkCore;
using Microservices.Models;
using Microservices.DBContexts;
using Microsoft.CodeAnalysis;

namespace Microservices.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;
        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int ProductId)
        {
            //throw new NotImplementedException();
            var product = _dbContext.Products.Find(ProductId);
            _dbContext.Products.Remove(product);
            Save();

        }

        public Product GetProductById(int ProductId)
        {
            //throw new NotImplementedException();
            return _dbContext.Products.Find(ProductId);
        }

        public IEnumerable<Product> GetProducts()
        {
            //throw new NotImplementedException();
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product Product)
        {
            //throw new NotImplementedException();
            _dbContext.Add(Product);
            Save();
        }

        

    public void Save()
        {
            //throw new NotImplementedException();
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product Product)
        {
            //throw new NotImplementedException();
            _dbContext.Entry(Product).State = EntityState.Modified;
            Save();

        }
    }
}
