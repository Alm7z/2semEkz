using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semEkz
{
	class Good
	{
		public int GoodCode;
		public string ShopName;
		public string Category;
		public Good(int goodCode,string shopName,string category)
		{
			GoodCode = goodCode;
			ShopName = shopName;
			Category = category;
		}
	}
}
