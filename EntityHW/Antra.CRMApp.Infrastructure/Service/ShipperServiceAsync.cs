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
    public class ShipperServiceAsync:IShipperServiceAsync
    {
        private readonly IShipperRepositoryAsync shipperRepositoryAsync;
        public ShipperServiceAsync(IShipperRepositoryAsync repo)
        {
            shipperRepositoryAsync = repo;
        }

        public async Task<int> AddShipperAsync(ShipperModel shipper)
        {
            Shipper ship = new Shipper();
            ship.Name = shipper.Name;
            ship.Phone = shipper.Phone;
            return await shipperRepositoryAsync.InsertAsync(ship);
        }

        public async Task<IEnumerable<ShipperModel>> GetAllAsync()
        {
            var collection = await shipperRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<ShipperModel> result = new List<ShipperModel>();
                foreach (var item in collection)
                {
                    ShipperModel model = new ShipperModel();
                    model.Id = item.Id;
                    model.Name = item.Name;
                    model.Phone = item.Phone;
                    result.Add(model);
                }
                return result;
            }
            return null;
        }
    }
}
