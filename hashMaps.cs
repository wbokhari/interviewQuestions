using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var input = new int[] {2,3,2,5, 6,5,2,5,5};
		var output = FindMostFrequentNumberUsingDict(input);
		Console.WriteLine(output);
	}
	
	public static int FindMostFrequentNumberUsingDict(int[] input)
	{
		var hash = new Dictionary<int, int>();
		foreach(var x in input)
		{
			if (hash.ContainsKey(x)){
				hash[x] = hash[x]+1;
			}
			else
				hash.Add(x, 1);
		}
		var maxVal = 0;
		var maxKey = 0;
		foreach (var item in hash)  
		{  
			Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);  
			if (item.Value > maxVal){
				maxKey = item.Key;
				maxVal = item.Value;
			}
		} 
		return maxKey;
	}
}
