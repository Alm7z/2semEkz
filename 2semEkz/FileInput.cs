using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2semEkz
{
	class FileInput : Input
	{
		public List<Good> GetGoods()
		{
			return File.ReadAllLines("goods.txt").Select(x =>
			{
				string[] t = x.Split(';');
				return new Good(int.Parse(t[0]), t[1], t[2]);
			}).ToList();
		}

		public List<Price> GetPrices()
		{
			return File.ReadAllLines("prices.txt").Select(x =>
			{
				string[] t = x.Split(';');
				return new Price(int.Parse(t[0]), int.Parse(t[1]), int.Parse(t[2]), int.Parse(t[3]));
			}).ToList();
		}

		public List<Shop> GetShops()
		{
			return File.ReadAllLines("shops.txt").Select(x =>
			{
				string[] t = x.Split(';');
				return new Shop(int.Parse(t[0]), t[1], t[2]);
			}).ToList();
		}
	}
}
