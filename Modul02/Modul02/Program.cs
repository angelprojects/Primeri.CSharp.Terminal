using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string programe_name = "Модул02 - Примери";
			string programe_version = "1.0";

			//Събиране на числа
			a = 7;
			b = 4;
			sum = a + b;

			//За програмата
			Console.WriteLine ( programe_name );
			Console.WriteLine ( "Версия: " + programe_version + "\n\n" );

			//Писане в конзола
			Console.Write ( a );
			Console.Write ( " + " );
			Console.Write ( b );
			Console.Write ( " = " );

			Console.WriteLine (sum);

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b; //a = a + b
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b; 
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b; 
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на ++");
			a ++; 
			Console.WriteLine ( a );

			a = 15; b = 10; 
			Console.WriteLine ("\nСтандартно делене");
			Console.WriteLine (a / b);	//1

			Console.WriteLine ("\nХващане на остатък");
			Console.WriteLine ( a % b);	//5, 1.5

			Console.WriteLine ( programe_name );

		}
	}
}
