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
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly ICategoryRepositoryAsync categoryRepositoryAsync;
        public CategoryServiceAsync(ICategoryRepositoryAsync repo)
        {
            categoryRepositoryAsync = repo;
        }
        public async Task<int> AddCategoryAsync(CategoryModel category)
        {
            Category cate = new Category();
            cate.Name = category.Name;
            cate.Description = category.Description;
            return await categoryRepositoryAsync.InsertAsync(cate);
        }

        public async Task<IEnumerable<CategoryModel>> GetAllAsync()
        {
            var collection = await categoryRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<CategoryModel> result = new List<CategoryModel>();
                foreach (var item in collection)
                {
                    CategoryModel model = new CategoryModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    model.Description = item.Description;
                    result.Add(model);
                }
                return result;
            }
            return null;
        }
    }
}
