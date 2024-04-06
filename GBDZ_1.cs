using System;

class Program
{
	static void PrintNumbers(int m, int n)
	{
    	Console.Write(m);
    	if (m < n)
    	{
        	Console.Write(", ");
        	PrintNumbers(m + 1, n);
    	}
	}

	static void Main()
	{
    	PrintNumbers(1, 5);
	}
}
