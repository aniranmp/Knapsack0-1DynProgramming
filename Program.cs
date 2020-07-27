using System;

namespace Knapsack0_1DynProgramming
{
	// A Dynamic Programming based solution for 
	// 0-1 Knapsack problem 
	// this code is Done by help of sam07 And Repolish and republished by me
	using System;

	class Program
	{
		// maximum number of two given arrays and values 
		static int Max(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			else
			{
				return b;
			}
		}

		// Returns the maximum value that 
		// can be put in a knapsack of 
		// capacity W 
		static int knapSack(int W, int[] wt,int[] val, int n)
		{
			int i, w;
			int[,] K = new int[n + 1, W + 1];

			for (i = 0; i <= n; i++)
			{
				for (w = 0; w <= W; w++)
				{
					if (i == 0 || w == 0)
						K[i, w] = 0;
					else if (wt[i - 1] <= w)
						K[i, w] = Math.Max(val[i - 1] + K[i - 1, w - wt[i - 1]]   ,   K[i - 1, w]); // From Algorithm In Articles of Dr.Sadoon Azizi
					else
						K[i, w] = K[i - 1, w];
				}
			}

			return K[n, W];
		}
		static void Main()
		{
			int[] val = new int[] { 60, 100, 120 }; //Values
			int[] wt = new int[] { 10, 20, 30 }; // Weights
			int W = 50; //Weight of Bag
			int n = val.Length; //Number of Weights 

			Console.WriteLine(knapSack(W, wt, val, n));
		}
	}
}
