using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairShare
{
	public static class FairShare
	{
		static Dictionary<int, string> sequences = new Dictionary<int, string>();

		static string Rotate(this string s, int count = 1)
		{
			count = count % s.Length;
			return s.Substring(count, s.Length - count) + s.Substring(0, count);
		}

		public static string Get(int n, int count)
		{
			// sanitise
			if (n < 2) return "groups must be larger than 1";
			if (n > 9) return "groups must be smaller than 10";
			if (count < 1) return "number of picks must be larger than 0";

			// seed
			if(!sequences.ContainsKey(n))
			{
				var sb = new StringBuilder(n);
				for (int i = 0; i < n; ++i)
				{
					sb.Append(i.ToString());
				}
				sequences.Add(n, sb.ToString());
			}

			// if we don't have it already, generate it
			// its inefficient (generates all previous sequences) but it should work
			while (count > sequences[n].Length)
			{
				// gets the first n digits, which is the seed
				var seed = sequences[n].Substring(0, n);

				// generate permutations
				var seedPermutations = new Dictionary<char, string>();
				for (int i = 0; i < seed.Length; ++i)
				{
					seedPermutations.Add(seed[i], seed.Rotate(i));
				}

				// generate, and always do power of n lengths, ie do the full replacement
				var sb = new StringBuilder();
				for (int i = 0; i < sequences[n].Length; ++i)
				{
					sb.Append(seedPermutations[sequences[n][i]]);
				}

				// write finished string to dictionary
				sequences[n] = sb.ToString();
			}

			// return it
			return sequences[n].Substring(0, count);
		}
	}
}
