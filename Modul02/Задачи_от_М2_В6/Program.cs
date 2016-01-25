using System;

namespace Задачи_от_М2_В6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			

			//Задачи 1 от Модул 02, видео 06. Две роменливи от тип стринг.



			string първа_променлива = "Hello";
			string втора_променлива = "World";
			object one =  (първа_променлива + " " + втора_променлива + "\n\n");
			Console.Write (one);



			//задача 2
			int a= 0;
			string forth = "";

			Console.Write ("Моля въведете число: ");
				a = Convert.ToInt32 (Console.ReadLine());

			Console.Write ("Моля въведете една дума: ");
				forth = (Console.ReadLine());

			Console.Write ("Общо знаци: ");Console.WriteLine (a.ToString ().Length + forth.Length);

	


		}
	}
}
