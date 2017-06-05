using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semEkz
{
	class PriceLogic : Logic
	{
		Input tInput;
		public PriceLogic(Input input)
		{
			this.tInput = input;
		}

		public List<IGrouping<string, string>> GetGroups()
		{
			var shops = tInput.GetShops();
			var prices = tInput.GetPrices();
			var goods = tInput.GetGoods();
			return goods.Select(g =>
			{
				Price best = prices.Where(p => p.GoodCode == g.GoodCode).Aggregate((a, b) =>
				a = (a.GoodPrice - a.GoodPrice * a.Discount / 100) <
				(b.GoodPrice - b.GoodPrice * b.Discount / 100) ? a : b);
				Shop shop = shops.Where(s => s.ShopCode == best.ShopCode).First();
				return g.ShopName + ";" + (best.GoodPrice - best.Discount * best.GoodPrice / 100) + ";" + shop.Address + ";" + shop.ShopName;
			}).GroupBy(x =>
			{
				int pr = int.Parse(x.Split(';')[1]);
				if (pr < 1000)
				{
					return "cheap";
				}
				if (pr < 10000)
				{
					return "medium";
				}

				return "expensive";
			}).ToList();
		}
	}
}
