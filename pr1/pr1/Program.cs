class pr1
{

	static void task1()
	{
		int a = 1;
		int b = 6;
		int c = 15;

		int n = 11;

		if ( 1 <= a && a <= n )
		{
			Console.WriteLine( a );
		}
		if ( 1 <= b && b <= n )
		{
			Console.WriteLine( b );
		}
		if ( 1 <= c && c <= n )
		{
			Console.WriteLine( c );
		}
	}
	public static void task2()
	{
		double a = 8.5;
		double b = 5.2;
		double c = 10.8;
		double Per = a + b + c;
		double S = a * b * c;

		if ( a == b && b == c )
		{
			Console.WriteLine( "Рiвносторонiй" );
		}
		else if ( a != b && b != c )
		{
			Console.WriteLine( "Рiзносторонiй" );
		}
		else
		{
			Console.WriteLine( "Рiвнобедрений" );
		}
		if ( Math.Pow( a, 2 ) + Math.Pow( b, 2 ) > Math.Pow( c, 2 ) && Math.Pow( c, 2 ) + Math.Pow( b, 2 ) > Math.Pow( a, 2 ) && Math.Pow( c, 2 ) + Math.Pow( a, 2 ) > Math.Pow( b, 2 ) )
		{
			Console.WriteLine( "Трикутник iснує" );
		}
		else
		{
			Console.WriteLine( "Такий трикутник не iснує" );
		}
	}
	public static void task3()
	{
		int[] arc = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
		int min = arc.Min();
		int max = arc.Max();
		Console.WriteLine( "Min" + min );
		Console.WriteLine( "Max" + max );
	}
	static void task4()
	{
		int[] X = new int[11] { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10, 11 };
		int M = 5;
		int t = 0;
		for ( int i = 0; i < X.Length; i++ )
		{
			if ( Math.Abs( X[i] ) < M )
			{
				t++;
			}
		}

		int[] Y = new int[t];
		int j = 0;
		for ( int i = 0; i < X.Length; i++ )
		{
			if ( Math.Abs( X[i] ) > M )
			{
				Y[j] = X[i];
			}
		}
		Console.WriteLine( M );
		Console.WriteLine();
		for ( int i = 0; i < X.Length; i++ )
		{
			Console.Write( X[i] );
		}
		Console.WriteLine();
		for ( int i = 0; i < Y.Length; i++ )
		{
			Console.Write( Y[i] );
		}
	}

	public static void Main()
	{
		task1();
	}

}