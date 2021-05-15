using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			int length = 10;
			int[] arr = new int[length];
			bool isNumberOk = false;
			int diaposon = 0;

			while (!isNumberOk)
			{
				try
				{
					Console.Write("Enter diaposon from 0 to 'Your value': ");
					diaposon = Int32.Parse(Console.ReadLine());
					isNumberOk = true;
				}

				catch
				{
					Console.WriteLine("Enter a number: ");
				}
			}
			
			Random rnd = new Random();

			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(0, diaposon);
			}

			Console.WriteLine();
			Console.WriteLine("Origin array");

			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}

			int temp;

			for(int i = 0; i < arr.Length; i++)
			{
				for(int j = 1; j < arr.Length - i; j++)
				{
					if(arr[j-1] > arr[j])
					{
						temp = arr[j - 1];
						arr[j - 1] = arr[j];
						arr[j] = temp;
					}
				}
			}

			Console.WriteLine();

			Console.WriteLine();
			Console.WriteLine("Sorted  array");

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}

		}
	}
}
