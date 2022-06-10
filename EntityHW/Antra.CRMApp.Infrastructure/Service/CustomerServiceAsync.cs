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
    public class CustomerServiceAsync : ICustomerServiceAsync
    {
        private readonly ICustomerRepositoryAsync repo;
        public CustomerServiceAsync(ICustomerRepositoryAsync _repo)
        {
            repo = _repo;
        }
        public async Task<int> AddCustomerAsync(CustomerModel customer)
        {
            Customer cust = new Customer();
            cust.Id = customer.Id;
            cust.Name = customer.Name;
            cust.Address = customer.Address;
            cust.City = customer.City;
            cust.Country = customer.Country;
            cust.Phone = customer.Phone;
            cust.PostalCode = customer.PostalCode;
            cust.Title = customer.Title;
            cust.RegionId = customer.RegionId;
            return await repo.InsertAsync(cust);
        }

        public async Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            var collection = await repo.GetAllAsync();
            if (collection != null)
            {
                List<CustomerModel> result = new List<CustomerModel>();
                foreach (var item in collection)
                {
                    CustomerModel model = new CustomerModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    model.Address = item.Address;
                    model.City = item.City;
                    model.Country = item.Country;
                    model.Phone = item.Phone;
                    model.PostalCode = item.PostalCode;
                    model.Title = item.Title;
                    model.RegionId = item.RegionId;
                    result.Add(model);
                }
                return result;
            }
            return null;
        }
    }
}
