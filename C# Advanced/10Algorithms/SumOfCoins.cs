using System;
using System.Collections.Generic;
using System.Linq;

namespace _10Algorithms
{
public class SumOfCoins
	{
		public static void Main(string[] args)
		{
			string[] inputCoins = Console.ReadLine()
				.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

			string[] inputSum = Console.ReadLine()
				.Split();

			var availableCoins = inputCoins[1].Split(',').Select(int.Parse).ToArray();
			int targetSum = int.Parse(inputSum[1]);

			Dictionary<int, int> selectedCoins = new Dictionary<int, int>();;
			
			try
			{
				selectedCoins = ChooseCoins(availableCoins, targetSum);

				Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
				
				foreach (var selectedCoin in selectedCoins)
				{
					Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
				}
			}
			catch (System.Exception)
			{
				Console.WriteLine("Error");
			}
		}

		public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
		{
			int sum = 0;
			Dictionary<int, int> result = new Dictionary<int, int>();

			var sortedCoins = coins.OrderByDescending(x => x).ToArray();
			int currentTarget = targetSum;

			for (int i = 0; i < sortedCoins.Count(); i++)
			{
				// while (sum + sortedCoins[i] <= targetSum)
				// {
				// 	sum += sortedCoins[i];

				// 	if (!result.ContainsKey(sortedCoins[i]))
				// 	{
				// 		result.Add(sortedCoins[i], 0);             
				// 	}
				// 	result[sortedCoins[i]]++;
				// }

				int currentCoinCount = currentTarget / sortedCoins[i];

				if (currentCoinCount > 0)
				{
					sum += currentCoinCount * sortedCoins[i];
					result.Add(sortedCoins[i], currentCoinCount);
					currentTarget = targetSum - sum;
				}

				if (sum == targetSum)
				{
					break;
				}
			}

			if (sum == targetSum)
			{
				return result;
			}

			throw new Exception();
		}
	}
}