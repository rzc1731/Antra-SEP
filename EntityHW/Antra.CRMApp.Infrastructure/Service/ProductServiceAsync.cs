using Antra.CRMApp.Core.Contract.Repository;
using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Entity;
using Antra.CRMApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CRMApp.Infrastructure.Service
{
    public class ProductServiceAsync : IProductServiceAsync
    {
        private readonly IProductRepositoryAsync repo;
        public ProductServiceAsync(IProductRepositoryAsync _repo)
        {
            repo = _repo;
        }
        public async Task<int> AddProductAsync(ProductModel product)
        {
            Product p = new Product();
            p.Id = product.Id;
            p.Name = product.Name;
            p.SupplierId = product.SupplierId;
            p.CategoryId = product.CategoryId;
            p.QuantityPerUnit = product.QuantityPerUnit;
            p.UnitPrice = product.UnitPrice;
            p.UnitsInStock = product.UnitsInStock;
            p.UnitsOnOrder = product.UnitsOnOrder;
            p.ReorderLevel = product.ReorderLevel;
            p.Discontinued = product.Discontinued;
            return await repo.InsertAsync(p);
        }

        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            var collection = await repo.GetAllAsync();
            if (collection != null)
            {
                List<ProductModel> result = new List<ProductModel>();
                foreach (var item in collection)
                {
                    ProductModel model = new ProductModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    model.SupplierId = item.SupplierId;
                    model.CategoryId = item.CategoryId;
                    model.QuantityPerUnit = item.QuantityPerUnit;
                    model.UnitPrice = item.UnitPrice;
                    model.UnitsInStock = item.UnitsInStock;
                    model.UnitsOnOrder = item.UnitsOnOrder;
                    model.ReorderLevel = item.ReorderLevel;
                    model.Discontinued = item.Discontinued;
                    result.Add(model);
                }
                return result;
            }
            return null;
        }
    }
}
