using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
			static void Main(string[] args)
		{
			List<Products> products = new List<Products>();

		}
		class Products
		{
			public int Name { get; set; }
			public int Price { get; set; }
			public int Number { get; set; }
			public int Color { get; set; }
		}
	}
}
