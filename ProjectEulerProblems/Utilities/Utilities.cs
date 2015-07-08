using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Utilities
    {
		public static bool IsPrime(double num)
		{
			bool success = true;
			long bound = (long)Math.Floor(Math.Sqrt(num));

			if (num == 1 || ((num % 2) == 0) || ((num % 5) == 0))
			{
				success = false;
			}
			else
			{
				for (int i = 2; i <= bound; i++)
				{
					if (num % i == 0)
					{
						success = false;
						break;
					}
				}
			}

			return success;
		}
    }
}
