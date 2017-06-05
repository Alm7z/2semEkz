using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2semEkz
{
	class Program
	{

		static void Main(string[] args)
		{
			Input input = new FileInput();
			Logic logic = new PriceLogic(input);
			Output output = new FileOutput(logic);
			output.OutData();

		}
	}
}
