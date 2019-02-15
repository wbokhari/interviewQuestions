using System;
					
public class Program
{
	public static void Main()
	{
		var input1 = new int[] {2,3,4,9};
		var input2 = new int[] {3,6,8};
		var output = MergeTwoSortedArrays(input1, input2);
		for(int j = 0; j< output.Length; j++)
		{
			Console.WriteLine(output[j]);
		}
	}
	
	public static int[] MergeTwoSortedArrays(int[] arr1, int[] arr2)
	{
		var size = arr1.Length + arr2.Length;
		var sortedArray = new int[size];
		int i = 0,j = 0, k = 0;
		while(j < arr2.Length && i < arr1.Length )
		{
			if(arr1[i] >= arr2[j])
			{
				sortedArray[k] = arr2[j];
				j++;
			}
			else
			{
				sortedArray[k] = arr1[i];
				i++;
			}
			k++;
		}
		
        while (i < arr1.Length) 
            sortedArray[k++] = arr1[i++]; 
      
        while (j < arr2.Length) 
            sortedArray[k++] = arr2[j++]; 
		
	return sortedArray;
	}
}
