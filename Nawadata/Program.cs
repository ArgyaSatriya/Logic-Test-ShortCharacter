using System;
using System.Collections.Generic;
using System.Linq;

namespace Nawadata
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Home();
			//SortCharacter();
			//PSBB();
		}
        static void Home()
        {
            Console.Clear();
            Console.WriteLine("Pilih MENU.");
            Console.WriteLine("===============================");
            Console.WriteLine("[Press 1] Soal 1. SortCharacter");
            Console.WriteLine("[Press 2] Soal 2. PSBB");
            Console.WriteLine("=================================");
            Console.Write("Pilih Program : ");

            int Pilih = int.Parse(Console.ReadLine());
            switch (Pilih)
            {
                case 1:
                    Console.Clear();
					SortCharacter();
                    Console.ReadLine();
                    Home();
                    break;
                case 2:
                    Console.Clear();
					PSBB();
                    Console.ReadLine();
                    Home();
                    break;
            }
        }
        public static void SortCharacter()
		{
            Console.Write("Input one line of words (S): ");
            string inputstring = Console.ReadLine().ToLower();

			string conso;
			string vowels;
			int i, len;
			vowels = "";
			conso = "";
			len = inputstring.Length;

			for (i = 0; i < len; i++)
			{
				if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
					inputstring[i] == 'i' || inputstring[i] == 'o' ||
					inputstring[i] == 'u' || inputstring[i] == 'A' ||
					inputstring[i] == 'E' || inputstring[i] == 'I' ||
					inputstring[i] == 'O' || inputstring[i] == 'U')
				{
					vowels +=inputstring[i];
				}
				else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
						 (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
				{

					conso+= inputstring[i];
				}
			}


			Console.WriteLine("Vowel Characters : " + vowels);
			Console.WriteLine("Consonant Characters : " + conso);

        }

		public static void PSBB()
		{
            Console.WriteLine("Input the number of families : ");
			int Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the number of members in the family\r\n(separated by a space) : ");
			List<int> Num2 =Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();
			
			if(Num2.Count == Num)
			{
				int SumOrang = Num2.Sum();
				int bus = SumOrang / 4;
				int mod = SumOrang % 4;
				if (mod == 0)
				{
					Console.WriteLine("Minimum bus required is :" + bus);
				}
				else
				{
					bus += 1;
                    Console.WriteLine("Minimum bus required is :" + bus);
                }
			}
			else
			{
				Console.WriteLine("Input must be equal with count of family");
			}
		}	
	}
}

