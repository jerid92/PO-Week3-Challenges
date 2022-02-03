using System;
using System.Text;

namespace Times11
{

	public class MultiplyBy11
	{
		static void Main(string[] args)
		{
			string eleven1 = "11";
			string eleven2 = "111111111";
			string eleven3 = "1213200020";
			string eleven4 = "1217197941";
			string eleven5 = "9473745364784876253253263723";

			Console.WriteLine(MultiBy11(eleven1));
			Console.WriteLine(MultiBy11(eleven2));
			Console.WriteLine(MultiBy11(eleven3));
			Console.WriteLine(MultiBy11(eleven4));
			Console.WriteLine(MultiBy11(eleven5));

		}

		public string MultiBy11(string result)
        {
			int length = result.Length + 1;
			StringBuilder product = new StringBuilder();
			int remainder = 0;
			product.Append(result[result.Length - 1]);
			for(int i = 0; i < result.Length - 1; i++)
            {
				int number = (int)Char.GetNumericValue(result[i]) + (int)Char.GetNumericValue(result[i - 1]) + remainder;
				int digit = number % 10;
				result.Insert(0, digit);
				if (number > 10 && digit != 0 || number == 10)
                {
					remainder = 1;
                }
				else
                {
					remainder = 0;
                }
				if (i == 1 && number > 10)
                {
					result.Insert(0, (int)Char.GetNumericValue(result[0]) + 1);
                }
				else if (i == 1)
                {
					result.Insert(0, (int)Char.GetNumericValue(result[0]));
                }
            }

			return result.ToString();
        }
	}
}