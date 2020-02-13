using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightspeedAccess.Models.Request
{
    class UpdateOnHandQuantityRequest : LightspeedRequest, IRequestPagination
	{
		public int Limit { get; private set; }
		public int Offset { get; private set; }

		protected override IEnumerable<LightspeedRestAPISegment> GetPath()
		{
			return new List<LightspeedRestAPISegment> { LightspeedRestAPISegment.Shop };
		}

		protected override Dictionary<LightspeedRequestPathParam, string> GetPathParams()
		{
			return new Dictionary<LightspeedRequestPathParam, string> {{ LightspeedRequestPathParam.Limit, Limit.ToString() },
			{ LightspeedRequestPathParam.Offset, Offset.ToString() }};
		}

		public UpdateOnHandQuantityRequest(int itemId, int relativeQty, int placeholder = 0)
		{
			throw new NotImplementedException(); //copied form GetShopRequest. no idea what the purpose is yet
			Limit = 100;
			Offset = 0;
		}

		public void SetOffset(int offset)
		{
			Offset = offset;
		}

		public int GetOffset()
		{
			return Offset;
		}

		public int GetLimit()
		{
			return Limit;
		}
	}
}
