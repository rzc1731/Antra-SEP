using Antra.CRMApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CRMApp.Core.Contract.Service
{
    public interface IProductServiceAsync
    {
        Task<IEnumerable<ProductModel>> GetAllAsync();
        Task<int> AddProductAsync(ProductModel product);
        Task<ProductModel> GetByIdAsync(int id);
        Task<ProductModel> GetProductForEditAsync(int id);
        Task<int> UpdateProductAsync(ProductModel employee);
        Task<int> DeleteProductAsync(int id);
    }
}
