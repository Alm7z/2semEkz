using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2semEkz
{
	class FileOutput:Output
	{
		Logic tLogic;
		public FileOutput(Logic logic)
		{
			tLogic = logic;
		}

		public void OutData()
		{
			foreach (var item in tLogic.GetGroups())
			{
				File.WriteAllLines(item.Key + ".txt", item.ToArray());
			}
		}
	}
}
