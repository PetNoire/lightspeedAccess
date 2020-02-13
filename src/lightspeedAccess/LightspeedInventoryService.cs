using lightspeedAccess.Models.Configuration;
using lightspeedAccess.Models.Product;
using lightspeedAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightspeedAccess
{
    class LightspeedInventoryService : ILightspeedInventoryService
    {
		private readonly WebRequestService _webRequestServices;

		public LightspeedInventoryService(LightspeedConfig config)
		{
			_webRequestServices = new WebRequestService(config);
		}

		public IEnumerable<LightspeedProduct> GetItems()
		{
			//var getShopsRequest = new GetShopRequest();
			//return _webRequestServices.GetResponse<ShopsList>(getShopsRequest).Shop;
			return null;
		}

		public Task<IEnumerable<LightspeedProduct>> GetItemsAsync()
		{
			return null;
		}

		public IEnumerable<LightspeedProduct> GetItem()
		{
			//var getShopsRequest = new GetShopRequest();
			//return _webRequestServices.GetResponse<ShopsList>(getShopsRequest).Shop;
			return null;
		}

		public Task<IEnumerable<LightspeedProduct>> GetItemAsync()
		{
			return null;
		}

	}
}
