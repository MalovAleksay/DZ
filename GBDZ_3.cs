
using System;

class Program
{
	static void PrintArrayReverse(int[] array, int index)
	{
    	if (index < 0) return;
    	Console.Write(array[index] + " ");
    	PrintArrayReverse(array, index - 1);
	}

	static void Main()
	{
    	int[] array = new int[] { 1, 2, 5, 0, 10, 34 };
    	PrintArrayReverse(array, array.Length - 1);
	}
}
