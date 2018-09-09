/*
 * Készítette a SharpDevelop.
 * Felhasználó: razgon
 * Dátum: 2018. 09. 09.
 * Idő: 17:25
 * 
 * A sablon megváltoztatásához használja az Eszközök | Beállítások | Kódolás | Szabvány Fejlécek Szerkesztését.
 */
using System;

namespace vonalkod_szamitas
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int beszam =13;
			int[] szamok=new int[beszam];
			
			Console.Write("Add meg a vonalkódot:");
			int ell=0;
			//Számolási hibát véthetünk!!
			for (int i = 0; i < beszam-1; i++) {
				
				szamok[i]=(int)Char.GetNumericValue(Console.ReadKey().KeyChar);
				
				if ((i+1)%2!=0) {
					ell=ell+(szamok[i]*1);
				}
				if ((i+1)%2==0) {
					ell=ell+(szamok[i]*3);
				}				
				
				
				
			}
			//A számjegy az a szám amit az ell értékéhez adva 10-el osztható számot kapunk.
			szamok[beszam-1]=10-(ell%10);
			
			Console.WriteLine("Az ellenőrzőjegy:{0},az összeg {1}",szamok[beszam-1],ell);
			
			Console.WriteLine();
			
			for (int i = 0; i < szamok.Length; i++) {
				Console.Write(szamok[i]+" ");
			}
			
			Console.ReadLine();
		}
	}
}