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

        public async Task<int> DeleteCategoryAsync(int Id)
        {
            return await categoryRepositoryAsync.DeleteAsync(Id);
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

        public async Task<CategoryModel> GetByIdAsync(int id)
        {
            var item = await categoryRepositoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                CategoryModel model = new CategoryModel();
                model.Name = item.Name;
                model.Id = item.Id;
                model.Description = item.Description;
                return model;
            }
            return null;
        }

        public async Task<CategoryModel> GetCategoryForEditAsync(int id)
        {
            var item = await categoryRepositoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                CategoryModel model = new CategoryModel();
                model.Name = item.Name;
                model.Id = item.Id;
                model.Description = item.Description;
                return model;
            }
            return null;
        }

        public async Task<int> UpdateCategoryAsync(CategoryModel category)
        {
            Category r = new Category();
            r.Name = category.Name;
            r.Id = category.Id;
            r.Description = category.Description;
            return await categoryRepositoryAsync.UpdateAsync(r);
        }
    }
}
