using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Service
{
    public interface IProductService
    {
        Task<ProductModel> SaveProduct(ProductModel product);
        Task<IEnumerable<ProductModel>> GetProducts();
        Task<ProductModel> Get(int productId);
    }
}
