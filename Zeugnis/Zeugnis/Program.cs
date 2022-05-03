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
			string Datum;
			string[] Faecher = new string[] {"Deutsch", "Englisch", "Mathe", "Physik", "Chemie", "Geschichte", "Kunst", "Politik"};
			int Leistungsfach1 = 0, Leistungsfach2;
			int Punkte;
			int x = 0;
			
			
			
			Console.Write("Name des Schülers: ");
			Name = Console.ReadLine();
			
			Console.Write("Zeugnisausstellungsdatum: ");
			Datum = Console.ReadLine();
			
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
			
			
			Console.WriteLine("Geben Sie die Notenpunkte iher Kurse an");
			Console.WriteLine("");
			
			for (int i = 0; i < Faecher.Length; i++)
			{
				Console.WriteLine(Faecher[i] + ": ");
				
				
			}
			
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}