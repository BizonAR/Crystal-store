using System;

namespace CrystalStore
{
	internal class CrystalStore
	{
		static void Main(string[] args)
		{
			int priceCrystal = 10;

			Console.Write("Сколько у вас золота? ");
			int gold = Convert.ToInt32(Console.ReadLine());
			Console.Write("Сколько кристаллов вы хотите купить? ");
			int numberCrystals = Convert.ToInt32(Console.ReadLine());
			gold -= numberCrystals * priceCrystal;

			Console.WriteLine($"У вас осталось золота: {gold} и вы купили {numberCrystals} кристаллов");
		}
	}
}
