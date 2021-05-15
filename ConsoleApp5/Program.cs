using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter legth of an arra: ");
		

			
			int length = Int32.Parse(Console.ReadLine());
			int[] arr = new int[length];

			Console.Write("Enter diaposon from 0 to 'Your value': ");
			int diaposon = Int32.Parse(Console.ReadLine());


			Random rnd = new Random();

			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(0, diaposon);
			}

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

			Console.WriteLine("Sorted  array");

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}

		}
	}
}
