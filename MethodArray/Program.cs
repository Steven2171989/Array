using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodArray
{
	
	class Program
	{
		public static bool IsEven(int value)
		{
			return value % 2 == 0;
		}

		static void Main(string[] args)
		{
			for (int i = 2; i <= 100; i++)
			{
				if (IsEven(i))
				{
					Console.WriteLine(i);
					Console.ReadLine();
				}
			}
		
		}
		
	}
}
