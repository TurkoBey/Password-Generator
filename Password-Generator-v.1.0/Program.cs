using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator_v._1._0
{
	class Program
	{
		static void Main(string[] args)
		{
		Again:
			Console.ForegroundColor = ConsoleColor.Cyan;
			string TUMKARAKTERLER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&'()*+-/:;<=?@[_{|~";
			string KKARAKTERLER = "abcdefghijklmnopqrstuvwxyz";
			char[] lettersArr = KKARAKTERLER.ToCharArray();
			char[] allCharactersArr = TUMKARAKTERLER.ToCharArray();
			string sonuc = "";
			Console.WriteLine("\t\t*****************************");
			Console.WriteLine("\t\t* RANDOM PASSWORD GENERATOR *");
			Console.WriteLine("\t\t*****************************");
			Console.Write("Parola uzunluğunu girin  : ");
			int numOfChar = Convert.ToInt32(Console.ReadLine());
			sonuc = Generatesonuc(sonuc, numOfChar, TUMKARAKTERLER, allCharactersArr);
			Console.WriteLine("\nSonuc\t:" + sonuc);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("==========================================================================================");
			Console.ForegroundColor = ConsoleColor.Cyan;
			goto Again;
			Console.ReadKey();
		}
		static string Generatesonuc(string sonuc, int numberOfCharacters, string charactersToUse, char[] ArrayToUse)
		{
			Random rand = new Random();
			for (int y = 0; y < numberOfCharacters; y++)
			{
				sonuc += Convert.ToString(ArrayToUse[rand.Next(0, charactersToUse.Length - 1)]);
			}
			return sonuc;
		}
	}
}
