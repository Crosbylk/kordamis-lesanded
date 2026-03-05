// See https://aka.ms/new-console-template for more information


using System.Drawing;

namespace _4_Mahukalkulaator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Kirjuta programm mis
			//küsib kasutajalt kas ta tahab arvutada oma kasti mahtu, või õlivaadi mahtu
			//sisendite küsimiseks on oma meetod, mis ei lase programmil edasi liikuda, kuni vastus ei ole tühi, ega üks võimalikest valikutest.
			//selle tegemiseks annate meetodile parameetrina valikud listis kaasa ja .Contains abil saate kontrollida kas ta on olemas või mitte
			//kui programm teab kumba ta arvutab toimuvad järgmised tegevused
			//  kasti puhul, küsitakse kas kast on kuubik või risttahukas.
			//    - kuubiku puhul küsitakse küljepikkus, antakse parameetrina meetodile KuubiRuumala() kaasa,
			//      ning kuubiruumala tagastab double tüüpi andmena muutujasse tehte tulemuse. valem otsi internetist.
			//    - risttahuka puhul lühima ja pikima külje pikkust ning kõrgust. samamoodi arvutab parameetrite abil 
			//      meetod RisttahukaRuumala() tulemuse double andmena ja tagastab selle muutujasse.
			//  Tünni puhul, küsitakse kas ta tünn on kaanega või kaaneta.
			//    - Kui tal on kaas olemas, siis küsi selle paksust, kui ei ole, määra paksuseks ise 0
			//      Küsi kasutajalt ka tünni põhja läbimõõtu ja kõrgust ning arvuta SilindriRuumala()
			//      meetodiga kus parameetrid ka kaasas double tulemus mille tagastad muutujasse
			//      NB! kaane paksuse arvutad kõrgusest maha, sest kaas võtab õlitünni sees mingi ruumala enda poolt ära.
			//Kuva kasutajale tema ruumala tulemus peaprogrammis, mitte arvutatavates meetodites.
			decimal result = 0;

			List<string> options = new List<string>() { "kast", "tünn" };
			Console.WriteLine("Mille mahtu arvutada tahad?: ");
			string userSelection = GetAnswer(options);
			if (userSelection == "kast")
			{
				List<string> options2 = new List<string>() { "kuubik", "risttahukas" };
				Console.WriteLine("Kas ta on üks neist?: ");
				string userSelection2 = GetAnswer(options2);
				if (userSelection2 == "kuubik")
				{
					Console.WriteLine("palun sisesta külje pikkus");
					decimal side = GetAnswer();

					result = RisttahukaRuumala(side, side, side);
				}
				else
				{
					Console.WriteLine("palun sisesta pika külje pikkus");
					decimal side = GetAnswer();
					Console.WriteLine("palun sisesta lühikese külje pikkus");
					decimal side2 = GetAnswer();
					Console.WriteLine("palun sisesta kõrgus");
					decimal height = GetAnswer();
					result = RisttahukaRuumala(side, side2, height);
				}
			}
			else if (userSelection == "tünn")
			{
				decimal lidThickness = 0;
				List<string> options3 = new List<string>() { "jah", "ei" };
				Console.WriteLine("Kas su tünn on lahtine või mitte?: ");
				string userSelection3 = GetAnswer(options3);
				if (userSelection3 == "ei")
				{
					Console.WriteLine("Palun kirjuta ka selle kaane paksus: ");
					lidThickness = GetAnswer();
				}
				Console.WriteLine("Mis on tünni läbimõõt?");
				decimal barrelRadius = (GetAnswer() / 2);
				Console.WriteLine("Kui kõrge on tünn?");
				decimal height = GetAnswer() - lidThickness;
				result = SilindriRuumala(barrelRadius, height);
			}
			Console.WriteLine($"Sinu {userSelection}i maht on {result} cm3");
		}

		private static decimal SilindriRuumala(decimal barrelRadius, decimal height)
		{
			double radius = (double)barrelRadius;
			return (decimal)(Math.PI * Math.Pow(radius, 2) * (double)height);
			//sitanikerdis
		}

		private static decimal RisttahukaRuumala(decimal a, decimal b, decimal c)
		{
			return a * b * c;
		}

		private static decimal GetAnswer()
		{
			decimal answer = 0;
			do
			{
				Console.Write("Kirjuta reaalne mõõt ->");
				answer = decimal.Parse(Console.ReadLine());
				Console.WriteLine();
			} while (answer <= 0);
			return answer;
		}
		private static string GetAnswer(List<string> options)
		{
			Console.WriteLine("Valikus on:");
			foreach (string option in options) { Console.WriteLine(option); }
			string thisOption = "";
			do
			{
				Console.Write("Kirjuta sobiv sisestus ->");
				thisOption = Console.ReadLine().ToLower();
				Console.WriteLine();
			} while (!options.Contains(thisOption));
			return thisOption;
		}
	}
}







namespace _2_Sulgudega_kalkulaator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Kirjuta, koos sisendikontrolliga ja sisendi normaliseerimisega, programm
			//küsib kasutajalt kolme tehet, esimene ja kolmas peaksid olema sulgude vahel ✅
			//kasutaja saab määrata igale tehtele märgi ✅
			//programm kuvab vastuse vastavalt tehete järjekorrale ✅

			Console.WriteLine("Sulgudega kalkulaator:");
			string[] tehterida = new string[7];
			Console.WriteLine("(arv tehe arv) tehe (arv tehe arv)");
			for (int i = 0; i < tehterida.Length; i++)
			{
				//string displayLine = "( ";
				//foreach (var input in tehterida)
				//{
				//    if (input.Contains("0123456789"))
				//    {

				//    }
				//}
				string sisestus = "";
				do
				{
					if (i % 2 == 0)
					{
						Console.WriteLine($"Palun sisesta {i + 1}. element, milleks on arv:");
					}
					else
					{
						Console.WriteLine($"Palun sisesta {i + 1}. element, milleks on tehe:");
					}
					sisestus = Console.ReadLine();
					double checkSisestus = 0;


					//if ((Double.TryParse(sisestus, out checkSisestus) == false) || (sisestus != "-" && sisestus != "*" && sisestus != "/" && sisestus != "+"))
					//{
					//    bool thisResult = Double.TryParse(sisestus, out checkSisestus);
					//        Console.WriteLine(thisResult);
					//    sisestus = "";
					//    break;

					//}
					//else if (!Double.TryParse(sisestus, out checkSisestus) || (sisestus == "+" && sisestus == "-" && sisestus == "*" && sisestus == "/"))
					//{
					//    Console.WriteLine("ei ole arv, proovi uuesti");
					//    sisestus = "";
					//}
					//else if (Double.TryParse(sisestus, out checkSisestus) || (sisestus != "+" && sisestus != "-" && sisestus != "*" && sisestus != "/"))
					//{Mage
					//    Console.WriteLine("ei ole tehtemärk, proovi uuesti");
					//    sisestus = "";
					//}
					//else
					//{
					//    Console.WriteLine("eet pänt");
					//    sisestus = "";
					//}
					if ((Double.TryParse(sisestus, out checkSisestus) == false))
					{
						sisestus = "";
						//    Console.WriteLine("ei ole arv, proovi uuesti");
						if ((sisestus == "+" && sisestus == "-" && sisestus == "*" && sisestus == "/"))
						{
							break;
						}
					}
					if ((Double.TryParse(sisestus, out checkSisestus) == false))
					{
						sisestus = "";
						//    Console.WriteLine("ei ole arv, proovi uuesti");

					}

				} while (sisestus == "");


				tehterida[i] = sisestus;

			}

			double tehe = ÜksTehe(
				[
				ÜksTehe(
					[tehterida[0], tehterida[1], tehterida[2]]
					).ToString(),

					tehterida[3],

				ÜksTehe(
					[tehterida[4], tehterida[5], tehterida[6]]
					).ToString()
					]
				);

			Console.WriteLine("vastus on " + tehe);

		}

		private static double ÜksTehe(string[] tehterida)
		{
			switch (tehterida[1])
			{
				case "+":
					return Liitmine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
					break;
				case "-":
					return Lahutamine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
					break;
				case "*":
					return Korrutamine(double.Parse(tehterida[0]), double.Parse(tehterida[2])); ;
					break;
				case "/":
					return Jagamine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
					break;
				default:
					return 0;
					break;
			}

		}

		public static double Liitmine(double arv1, double arv2)
		{
			return arv1 + arv2;
		}
		public static double Lahutamine(double arv1, double arv2)
		{
			return arv1 - arv2;
		}
		public static double Korrutamine(double arv1, double arv2)
		{
			return arv1 * arv2;
		}
		public static double Jagamine(double arv1, double arv2)
		{
			return arv1 / arv2;
		}
	}
}




namespace _1_Tänavanimed
		{
			internal class Program
			{
				static void Main(string[] args)
				{
					//kasutades meetodeid ja sõnetöötlemisvahendeid sisendi kontrolli jaoks, kirjuta programm mis:
					/*
					 * küsib kasutajalt tema kodukandi tänavanimesid ✅
					 * küsib kasutajalt milline tähestiku täht talle ei meeldi ✅
					 * programm otsib järjendist üles kõik tänavanimed milles ebameeldiv täht esineb ✅
					 * eemaldab need järjendist ✅
					 * ja kuvab järjendi välja ✅
					 * programm loendab ka kokku eemaldatud nimede arvu, ning tagastab sõnumi koos loendiga mitu sõna eemaldati. ✅
					 */
					//// debugimise kood
					//Console.WriteLine("Sisesta tänavanimi");
					//string tänavanimi = SisendiVõttJaKontroll();
					//Console.WriteLine(tänavanimi);
					List<string> tänavaNimed = new List<string>();
					Console.WriteLine("Kirjuta siia oma kodukandi tänavanimed, kui rohkem ei ole, kirjuta ei-ole");
					string sisestus = "";
					do
					{
						Console.WriteLine("Sisesta tänavanimi");
						sisestus = SisendiVõttJaKontroll();
						if (sisestus != "Ei-ole")
						{
							tänavaNimed.Add(sisestus);
						}
					} while (sisestus != "Ei-ole");

					//// debugimise kood
					//foreach (var nimi in tänavaNimed)
					//{
					//    Console.WriteLine(nimi);
					//}
					Console.WriteLine("Kirjuta täht mis sulle ei meeldi");
					string ebameeldivTäht = SisendiVõttJaKontroll(" ");
					List<string> uusJärjend = JärjendiFiltreerimine(tänavaNimed, ebameeldivTäht);
					KuvaAndmed(uusJärjend);

				}

				private static void KuvaAndmed(List<string> kuvatavadAndmed)
				{
					if (kuvatavadAndmed.Count > 0)
					{
						for (int i = 0; i < kuvatavadAndmed.Count; i++)
						{
							Console.WriteLine((i + 1) + ". " + kuvatavadAndmed[i]);
						}
						return;
					}
					Console.WriteLine("Järjend on tühi");
					return;
				}

				private static List<string> JärjendiFiltreerimine(List<string> filtreeritavadAndmed, string filter)
				{
					int loendur = 0;
					List<string> töödeldudAndmed = new List<string>();
					foreach (var anne in filtreeritavadAndmed)
					{
						if (!anne.ToLower().Contains(filter.Substring(0, 1).ToLower()))
						{
							töödeldudAndmed.Add(anne);
						}
						else
						{
							loendur++;
						}
					}
					Console.WriteLine($"Eemaldati {loendur} elementi");
					return töödeldudAndmed;
				}

				public static string SisendiVõttJaKontroll()
				{
					string sisestus = "";
					string töödeldudsisestus = "";
					do
					{
						Console.WriteLine("Kirjuta siia: ");
						sisestus = Console.ReadLine();

						if (sisestus.Length > 1)
						{
							töödeldudsisestus = (sisestus.Substring(0, 1).ToUpper() + sisestus.Substring(1).ToLower());
						}
						else
						{
							Console.WriteLine("Tänavanimi ei saa olla lühem kui 2 tähte!");
							sisestus = "";
						}
					} while (string.IsNullOrEmpty(sisestus));
					return töödeldudsisestus;
				}



				public static string SisendiVõttJaKontroll(string addition)
				{
					string sisestus = "";
					string töödeldudsisestus = "";
					do
					{
						Console.WriteLine("Kirjuta siia: ");
						sisestus = Console.ReadLine() + addition;

						if (sisestus.Length > 1)
						{
							töödeldudsisestus = (sisestus.Substring(0, 1).ToUpper() + sisestus.Substring(1).ToLower());
						}
						else
						{
							Console.WriteLine("Tänavanimi ei saa olla lühem kui 2 tähte!");
							sisestus = "";
						}
					} while (string.IsNullOrEmpty(sisestus));
					return töödeldudsisestus;
				}
			}
		}
	
		
