using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semEkz
{
	interface Input
	{
		List<Shop> GetShops();
		List<Price> GetPrices();
		List<Good> GetGoods();
	}
}
