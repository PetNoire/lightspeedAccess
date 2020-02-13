using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lightspeedAccess.Models.Product;

namespace lightspeedAccess { 

	public interface ILightspeedInventoryService
	{
		IEnumerable<LightspeedProduct> GetItem();
		Task<IEnumerable<LightspeedProduct>> GetItemAsync();
		IEnumerable<LightspeedProduct> GetItems();
		Task<IEnumerable<LightspeedProduct>> GetItemsAsync();
	}
}
