using System;

public class Example {
    public static void Main() 
    {
		/*float floatPI = 3.141592653589793238f;
		double doublePI = 3.141592653589793238;
		// Print the results on the console
		Console.WriteLine("Float PI is: " + floatPI);
		Console.WriteLine("Double PI is: " + doublePI);
		char symbol = 'a';
		// Print the results on the console
		Console.WriteLine("The code of '" + symbol + "' is: " + (int)symbol);
		symbol = 'b';
		Console.WriteLine("The code of '" + symbol + "' is: " + (int)symbol);
		symbol = 'A';
		Console.WriteLine("The code of '" + symbol + "' is: " + (int)symbol);*/
		int i = 5;
		int? ni = i;
		Console.WriteLine(ni);
		//i = ni; // this will fail to compile
		Console.WriteLine(ni.HasValue); // True
		i = ni.Value;
		Console.WriteLine(i); // 5
		ni = null;
		Console.WriteLine(ni.HasValue); // False
		//i = ni.Value; // System.InvalidOperationException
		i = ni.GetValueOrDefault();
		Console.WriteLine(i); // 0
	}
}