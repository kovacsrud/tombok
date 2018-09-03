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
			int szamok_min=int.MaxValue;
			int szamok_max=int.MinValue;
			int szamok_osszeg=0;
			double szamok_atlag;
			
			//Feltöltés adatokkal (véletlen számokkal ebben a példában)
			Random veletlenszam=new Random();
			
			for (int i = 0; i < szamok.Length; i++) {
				szamok[i]=veletlenszam.Next(-100,100);
			}
			
			//A tömb elemeinek kiíratása
			for (int i = 0; i < szamok.Length; i++) {
				Console.WriteLine("Index:{0},elem:{1}",i,szamok[i]);
			}
			
			//Minimum, maximum kiválasztás, összeg gyűjtése
			for (int i = 0; i < szamok.Length; i++) {
				
				if (szamok[i]<szamok_min) {
					szamok_min=szamok[i];
				}
				if (szamok[i]>szamok_max) {
					szamok_max=szamok[i];
				}
				szamok_osszeg=szamok_osszeg+szamok[i];
			}
			//double-ként kell számolni a változókkal
			szamok_atlag=(double)szamok_osszeg/(double)szamok.Length;
			
			Console.WriteLine("Darab:{0},Min:{1},Max:{2},Összeg:{3},Átlag:{4:0.000}"
			                  ,szamok.Length,szamok_min,szamok_max
			                  ,szamok_osszeg,szamok_atlag);
			
			Console.ReadLine();
		}
	}
}