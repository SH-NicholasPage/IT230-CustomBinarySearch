/*
 * Name: [YOUR NAME HERE]
 * South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
 */

using System;
using System.Linq;

namespace CustomBinarySearch
{
	public class Program
	{
		private const uint ARRAY_SIZE = 16;

		private static int BinarySearch(int[] arr, int match)
		{
			//TODO
			return -1;
		}

		//DO NOT MODIFY THE MAIN METHOD
		public static void Main()
		{
			Random rand = new Random();
			int[] randNums = new int[ARRAY_SIZE];

			for (int i = 0; i < randNums.Length; i++)
			{
				int randNum = rand.Next(0, 100);

				while (randNums.Contains(randNum))
				{
					randNum = rand.Next(0, 100);
				}

				randNums[i] = randNum;
			}

			Array.Sort(randNums);

			Console.WriteLine($"Numbers generated {String.Join(", ", randNums)}");
			Console.Write("Enter a number to search for: ");
			int searchNum = int.Parse(Console.ReadLine()!);

			int index = BinarySearch(randNums, searchNum);

			if(index != -1)
			{
				Console.WriteLine($"Number found at index {index}");
			}
			else
			{
				Console.WriteLine("Number not found");
			}
		}
	}
}