using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semEkz
{
	class Shop
	{
		public int ShopCode;
		public string ShopName;
		public string Address;
		public Shop(int shopCode,string shopName,string address)
		{
			ShopCode = shopCode;
			ShopName = shopName;
			Address = address;
		}
	}
}
