/*
 * Készítette a SharpDevelop.
 * Felhasználó: razgon
 * Dátum: 2018. 09. 09.
 * Idő: 16:49
 * 
 * A sablon megváltoztatásához használja az Eszközök | Beállítások | Kódolás | Szabvány Fejlécek Szerkesztését.
 */
using System;

namespace tomb_gyak1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Hány számot kérünk be:");
			int beszam =Convert.ToInt32(Console.ReadLine());
			int[] szamok=new int[beszam];
			
			for (int i = 0; i < beszam; i++) {
				Console.Write("Adj egy számot:");
				szamok[i]=Convert.ToInt32(Console.ReadLine());
			}
			
			Console.Write("Mit keresünk:");
			int keresett =Convert.ToInt32(Console.ReadLine());
			bool megvan=false;
			
			for (int i = 0; i < szamok.Length; i++) {
				if (szamok[i]==keresett) {
					Console.WriteLine("A keresett szám:{0} a tömbben a(z) {1}. elem.",keresett,i);
					megvan=true;
					break;
				}
			}
			if(!megvan){
				Console.WriteLine("A keresett szám:{0} nem található",keresett);
			}
			
			
//			for (int i = 0; i < szamok.Length; i++) {
//				Console.Write(szamok[i]+" ");
//			}
			
			Console.ReadLine();
		}
	}
}