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
    public class SupplierServiceAsync : ISupplierServiceAsync
    {
        private readonly ISupplierRepositoryAsync repo;
        public SupplierServiceAsync(ISupplierRepositoryAsync _repo)
        {
            repo = _repo;
        }
        public async Task<int> AddSupplierAsync(SupplierModel supplier)
        {
            Supplier sup = new Supplier();
            sup.Id = supplier.Id;
            sup.CompanyName = supplier.CompanyName;
            sup.ContactName = supplier.ContactName;
            sup.ContactTitle = supplier.ContactTitle;
            sup.Address = supplier.Address;
            sup.City = supplier.City;
            sup.RegionId = supplier.RegionId;
            sup.PostalCode = supplier.PostalCode;
            sup.Country = supplier.Country;
            sup.Phone = supplier.Phone;
            return await repo.InsertAsync(sup);
        }

        public async Task<int> DeleteSupplierAsync(int id)
        {
            return await repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<SupplierModel>> GetAllAsync()
        {
            var collection = await repo.GetAllAsync();
            if (collection != null)
            {
                List<SupplierModel> result = new List<SupplierModel>();
                foreach (var supplier in collection)
                {
                    SupplierModel model = new SupplierModel();
                    model.Id = supplier.Id;
                    model.CompanyName = supplier.CompanyName;
                    model.ContactName = supplier.ContactName;
                    model.ContactTitle = supplier.ContactTitle;
                    model.Address = supplier.Address;
                    model.City = supplier.City;
                    model.RegionId = supplier.RegionId;
                    model.PostalCode = supplier.PostalCode;
                    model.Country = supplier.Country;
                    model.Phone = supplier.Phone;
                    result.Add(model);
                }
                return result;
            }
            return null;
        }

        public async Task<SupplierModel> GetByIdAsync(int id)
        {
            var item = await repo.GetByIdAsync(id);
            if (item != null)
            {
                SupplierModel model = new SupplierModel();
                model.Id = item.Id;
                model.CompanyName = item.CompanyName;
                model.ContactName = item.ContactName;
                model.ContactTitle = item.ContactTitle;
                model.Address = item.Address;
                model.City = item.City;
                model.RegionId = item.RegionId;
                model.PostalCode = item.PostalCode;
                model.Country = item.Country;
                model.Phone = item.Phone;
                return model;
            }
            return null;
        }

        public async Task<SupplierModel> GetSupplierForEditAsync(int id)
        {
            var item = await repo.GetByIdAsync(id);
            if (item != null)
            {
                SupplierModel model = new SupplierModel();
                model.Id = item.Id;
                model.CompanyName = item.CompanyName;
                model.ContactName = item.ContactName;
                model.ContactTitle = item.ContactTitle;
                model.Address = item.Address;
                model.City = item.City;
                model.RegionId = item.RegionId;
                model.PostalCode = item.PostalCode;
                model.Country = item.Country;
                model.Phone = item.Phone;
                return model;
            }
            return null;
        }

        public async Task<int> UpdateSupplierAsync(SupplierModel supplier)
        {
            Supplier s = new Supplier();
            s.Id = supplier.Id;
            s.CompanyName = supplier.CompanyName;
            s.ContactName = supplier.ContactName;
            s.ContactTitle = supplier.ContactTitle;
            s.Address = supplier.Address;
            s.City = supplier.City;
            s.RegionId = supplier.RegionId;
            s.PostalCode = supplier.PostalCode;
            s.Country = supplier.Country;
            s.Phone = supplier.Phone;
            return await repo.UpdateAsync(s);
        }
    }
}
