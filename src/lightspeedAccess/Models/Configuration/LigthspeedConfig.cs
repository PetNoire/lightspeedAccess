using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightspeedAccess.Models.Configuration
{
	public class LightspeedConfig
	{
		public string Endpoint { get; private set; }
		public string Username { get; private set; }
		public string Password { get; private set; }
		public string ClientID { get; private set; }
		public string ClientSecret { get; private set; }

		public readonly string path = "https://cloud.lightspeedapp.com/oauth/authorize.php";

		public LightspeedConfig()
		{
			var testAccountID = 797;
			Endpoint = string.Format( "{0}/{1}/", path, testAccountID );
			Username = "imademo";
			Password = "thisismypass";
		}

		public LightspeedConfig( string clientId, string clientsecret )
		{
			Endpoint = string.Format("{0}?response_type=code&scope=employee:all&client_id={1}", path, clientId );
			ClientID = clientId;
			ClientSecret = clientsecret;
		}

	}

}