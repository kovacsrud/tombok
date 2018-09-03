/*
 * Készítette a SharpDevelop.
 * Felhasználó: razgon
 * Dátum: 2018. 09. 03.
 * Idő: 16:47
 * 
 * A sablon megváltoztatásához használja az Eszközök | Beállítások | Kódolás | Szabvány Fejlécek Szerkesztését.
 */
using System;

namespace tomb_1dim
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Deklaráció, ez a tömb 30 integer típusú számot tud tárolni
			int[] szamok=new int[30];
				
			
			//Feltöltés adatokkal (véletlen számokkal ebben a példában)
			Random veletlenszam=new Random();
			
			for (int i = 0; i < szamok.Length; i++) {
				szamok[i]=veletlenszam.Next(-100,100);
			}
			
			//A tömb elemeinek kiíratása
			for (int i = 0; i < szamok.Length; i++) {
				Console.WriteLine("Index:{0},elem:{1}",i,szamok[i]);
			}
			
			
			Console.ReadLine();
		}
	}
}