﻿using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дфиниране на променливи

			int a = 5, b = 0;

			//Въвеждане на входни данни
			Console.Write ( "Моля въведете b: ");
			b = Convert.ToInt32 ( Console.ReadLine () );

			//Печат на резултат
			Console.WriteLine ("Резултата a + b е " + (a + b).ToString () + "\n\n\n");

			string test = "1";
			test += ", 2";
			test += ", 55";
			test += ", 4";
			test += ", 5";

			Console.WriteLine ("Събиране с += :" + test + "\n");
			test = test.Replace (", ", ";");
			Console.WriteLine ("Работа с Replace " + test + "\n"); 
			Console.WriteLine ("3ти знак: " + test.Split (';') [2]);


		}
	}
}
