using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			int length = 20;
			int[] arr = new int[length];
			bool isNumberOk = false;
			int diaposon = 0;
			int numverToSearch = 0;

			while (!isNumberOk)
			{
				try
				{
					Console.Write("Enter diaposon from 0 to 'Your value': ");
					diaposon = Int32.Parse(Console.ReadLine());

					isNumberOk = true;

					Console.Write("Enter number to search for: ");
					numverToSearch = Int32.Parse(Console.ReadLine());
				}

				catch
				{
					Console.WriteLine("Enter a number: ");
				}
			}

			int position = -1;

			bool found = false;		

			Random rnd = new Random();

			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(0, diaposon);
			}

			Console.WriteLine();
			Console.WriteLine("Origin array");

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}

			Console.WriteLine();

			
			for (int i = 0; i < arr.Length; i++)
			{
				if(arr[i] == numverToSearch)
				{
					found = true;
					position = i;
					break;
				}			
			}
			

			if(found == true)
			{
				switch (position)
				{
					case 1:
						Console.WriteLine($"The number {numverToSearch} is located at {position}st position");
						break;

					case 2:
						Console.WriteLine($"The number {numverToSearch} is located at {position}nd position");
						break;

					case 3:
						Console.WriteLine($"The number {numverToSearch} is located at {position}rd position");
						break;

					default:
						Console.WriteLine($"The number {numverToSearch} is located at {position}th position");
						break;
				}
			}

			if(found == false)
			{
				Console.WriteLine("This number doesn't exist int this array!!");
			}
		}
	}
}
