
using System;

class Program
{
	static int Ackermann(int m, int n)
	{
    	if (m == 0)
    	{
        	return n + 1;
    	}
    	else if (m > 0 && n == 0)
    	{
        	return Ackermann(m - 1, 1);
    	}
    	else if (m > 0 && n > 0)
    	{
        	return Ackermann(m - 1, Ackermann(m, n - 1));
    	}
    	return 0;
	}

	static void Main()
	{
    	Console.WriteLine($"A(2, 3) = {Ackermann(2, 3)}");
	}
}
