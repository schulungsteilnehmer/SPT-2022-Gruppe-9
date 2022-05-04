/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 03.05.2022
 * Time: 10:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zeugnis
{
	class Program
	{
		public static void Main(string[] args)
		{
			int Note;
			string Name;
			string Tag;
			string Monat;
			string Jahr;
			int t;
			int m;
			int j;
			string[] Faecher = new string[] {"Deutsch", "Englisch", "Mathe", "Physik", "Chemie", "Geschichte", "Kunst", "Politik"};
			int [] Noten = new int[8];
			int Leistungsfach1 = 0, Leistungsfach2;
			int Punkte;
			int x = 0;
			int gesammt = 0;
			int Fehltage, Entschuldigt, Unentschuldigt;
			double ergebnis, durchschnitt;
			int unterkurs = 0, versetzung = 0;
			string [] Buchstaben = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " ", "-"};
			
								
				
			Console.WriteLine("=======Zeugnis=======");
				Console.Write("Name des Schülers: ");
				Name = Console.ReadLine();
				Console.WriteLine("");
					
			
			Console.Write("Zeugnisausstellungsdatum; Tag: ");
			Tag = Console.ReadLine();
			t = Convert.ToInt32(Tag);
			Console.WriteLine("");
		
			while (x == 0) 
				
			{
				if (t > 0 && t < 32)
				{
					Console.WriteLine("");
					x = x + 1;
				}
				else
				{
					Console.WriteLine("Error -- Bitte geben sie einen korrekten Tag ein!");
					Console.WriteLine("");
					
			Console.Write("Zeugnisausstellungsdatum; Tag: ");
			Tag = Console.ReadLine();
			t = Convert.ToInt32(Tag);
			Console.WriteLine("");
		
					x = 0;
				} 
				
			} 
		
		
		
		
		Console.Write("Zeugnisausstellungsdatum; Monat: ");
			Monat = Console.ReadLine();
			m = Convert.ToInt32(Monat);
			Console.WriteLine("");
		
			while (x == 0) 
				
			{
				if (m > 0 && m < 13)
				{
					Console.WriteLine("");
					x = x + 1;
				}
				else
				{
					Console.WriteLine("Error -- Bitte geben sie einen korrekten Monat ein!");
					Console.WriteLine("");
					
			Console.Write("Zeugnisausstellungsdatum; Monat: ");
			Monat = Console.ReadLine();
			m = Convert.ToInt32(Monat);
			Console.WriteLine("");
		
					x = 0;
				} 
				
			} 
		
		
		Console.Write("Zeugnisausstellungsdatum; Jahr: ");
			Jahr = Console.ReadLine();
			j = Convert.ToInt32(Jahr);
			Console.WriteLine("");
		
			while (x == 0) 
				
			{
				if (j > 2021 && j < 4000)
				{
					Console.WriteLine("");
					x = x + 1;
				}
				else
				{
					Console.WriteLine("Error -- Bitte geben sie ein korrektes Jahr ein!");
					Console.WriteLine("");
					
			Console.Write("Zeugnisausstellungsdatum; Jahr: ");
			Jahr = Console.ReadLine();
			j = Convert.ToInt32(Jahr);
			Console.WriteLine("");
		
					x = 0;
				} 
				
			} 
			Console.WriteLine("===================");
		

		Console.WriteLine("Wählbare Fächer:");
		Console.WriteLine("");
		
		for (int i = 0; i < Faecher.Length; i++)
		{
			Console.WriteLine(" " + (i + 1) + "	" + Faecher[i]);
		}
		
		Console.WriteLine("");
		Console.WriteLine("Geben Sie die Leistungskurse als Zahl an");
		Console.WriteLine("");
		
		
		
		do {
			
			Console.Write("Leistungskurs 1: ");
			Leistungsfach1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			if (0 < Leistungsfach1 && Leistungsfach1 < 9)
			{
				Console.WriteLine(Faecher[Leistungsfach1 - 1]);
				Console.WriteLine("");
				x = x + 1;
			}
			else
			{
				Console.WriteLine("Error -- Bitte geben sie eine Zahl von 1 bis 8 ein!");
				Console.WriteLine("");
			}
		} while (x == 0);
		
		x = 0;
		
		do {
			
			Console.Write("Leistungskurs 2: ");
			Leistungsfach2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			
			if (0 < Leistungsfach2 && Leistungsfach2 < 9)
			{
				Console.WriteLine(Faecher[Leistungsfach2 - 1]);
				Console.WriteLine("");
				x = x + 1;
			}
			else
			{
				Console.WriteLine("Error -- Bitte geben sie eine Zahl von 1 bis 8 ein!");
				Console.WriteLine("");
			}
		} while (x == 0);
		
		x = 0;
		
		
		Console.WriteLine("Geben Sie die Notenpunkte iher Kurse an");
		Console.WriteLine("");
		
		for (int i = 0; i < Faecher.Length; i++)
		{
			x = 0;
			Console.Write(Faecher[i] + ": ");
			
			do {
				
				Punkte = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("");
				
				Noten[i] = Punkte;
				
				if (Punkte < 5)
				{
					unterkurs = unterkurs + 1;
				}
				
				
				if (0 <= Punkte && Punkte < 16)
				{
					if (i == (Leistungsfach1 - 1) || i == (Leistungsfach2 - 1)) {
						Punkte = Punkte * 2;
						gesammt = gesammt + Punkte;
					}
					
					else
					{
						gesammt = gesammt + Punkte;
					}
					x = x + 1;
				}
				else
				{
					Console.WriteLine("Error -- Bitte geben sie eine Zahl von 0 bis 15 ein!");
					Console.WriteLine("");
				}
			} while (x == 0);
			
		}
		
		if (unterkurs > 2)
		{
			versetzung = 1;
		}
		
		Console.WriteLine("");
		Console.WriteLine(Tag);
		Console.WriteLine("");
		
		Console.WriteLine("");
		
		for (int i = 0; i < Faecher.Length; i++)
		{
			Console.WriteLine("{1,-40}", Faecher[i], Noten[i]);
			Console.WriteLine("");
		}
		
		if (versetzung == 1)
		{
			Console.WriteLine("Der Schühler wird nicht versetzt");
			Console.WriteLine("");
		}
		
		Console.WriteLine("");
		
		ergebnis = gesammt / 10;
		durchschnitt = (17 - ergebnis) / 3;
		Console.WriteLine("Notendurschnitt " + "{0:F1}", durchschnitt);
		Console.WriteLine("");
		
				Console.Write("Geben Sie ihre Fehltage ein: ");
		Fehltage = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("");
		
		Console.Write("Davon entschuldigt: ");
		Entschuldigt = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("");
		
		Unentschuldigt = Fehltage - Entschuldigt;
		Console.WriteLine(Convert.ToString(Unentschuldigt) + " unentschuldigte Fehltage");
		Console.WriteLine("===================");
		
		if (Unentschuldigt > 30)
		{
			Console.WriteLine("Der Schüler wird nicht versetzt");
			Console.WriteLine("");
			versetzung = 1;
		}
		
		else
		{
			Console.WriteLine("Der Schüler wird versetzt");
			Console.WriteLine("");
		}
		
		
		
		
		
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		
	}
}
}
