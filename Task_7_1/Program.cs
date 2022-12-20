using System;
using System.Linq.Expressions;

namespace Task_7_1
{
	class Program
	{
		static void Main(string[]args)
		{
			try
			{
				Console.WriteLine("Введите строку");
				String beginStr = Console.ReadLine();
				Console.Write("Введите букву, которую надо удвоить: ");
				String strReplace = Console.ReadLine();
				bool check = false;

				if (strReplace.Length != 1)
				{
					throw new Exception();
				}
				
				for (int i = 0; i < beginStr.Length; i++)
				{
					if (strReplace[0] == beginStr[i])
					{
						check = true;
						break;
					}
				}

				if (check)
				{
					String afterStr = beginStr.Replace(strReplace, (strReplace + strReplace));
					Console.WriteLine("Новая строка с удвоенными буквами\n" + afterStr);
				}
				else
				{
					throw new Exception();
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Введите корректные данные");
			}
			catch
			{
				Console.WriteLine("Такого символа нет в строке и/или в строке должен быть один символ");
			}
		}
	}
}