using Inventory.Data;
using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Service
{
    public class ProductService : IProductService
    {
        InventoryContext dbContext;
        public ProductService(InventoryContext dbContext) {
            this.dbContext = dbContext;
        }

        public async Task<ProductModel> Get(int productId)
        {
            var product = await dbContext.Product.SingleOrDefaultAsync(p => p.Id == productId);
            if (product != null) {
                var productModel = new ProductModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    CategoryId = product.CategoryId
                };
                return productModel;
            }
            return null;
        }

        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            var products = await dbContext.Product.ToListAsync();
            var productModels = products.Select(p => new ProductModel() { 
                Id = p.Id,
                CategoryId = p.CategoryId,
                CategoryName = CategoriesDictionary.GetCategoryById(p.CategoryId),
                Price = p.Price,
                Description = p.Description,
                Name = p.Name
            });

            return productModels;
        }

        public async Task<ProductModel> SaveProduct(ProductModel product)
        {
            var data = await Get(product.Id);
            if (data != null)
            {
                data.Name = product.Name;
                data.Price = product.Price;
                data.Description = product.Description;
            }
            else 
            {
                var newProduct = new Products();
                newProduct.Name = product.Name;
                newProduct.Price = product.Price;
                newProduct.Description = product.Description;
                newProduct.CategoryId = product.CategoryId;

                await dbContext.AddAsync(newProduct);
            }

            int id = await dbContext.SaveChangesAsync();
            product.Id = id;

            return product;
        }
    }
}
