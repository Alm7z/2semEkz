using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semEkz
{
	class Price
	{
		public int ShopCode;
		public int GoodCode;
		public int GoodPrice;
		public int Discount;
		public Price(int shopCode,int goodCode,int goodPrice,int discount)
		{
			ShopCode = shopCode;
			GoodCode = goodCode;
			GoodPrice = goodPrice;
			Discount = discount;
		}
	}
}
