// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//süsteemi muuks osaks võib olla kas operatsioonisüsteemi võimalused või ka teised projektid. Teised projektid viidatakse tavaliselt solution (.sln) failist.

namespace EsimeneProjekt_LOGITge25_KF //<--- nimeruum, sisaldab {} sulgude vahel konteinerit kus asjub kogu programmi kood nime all "EsimeneProjekt"
{
	internal class Program //<--- programmi klass, mis on ka omakorda konteiner tüüp, kus sees on kogu programmi kood
	{
		static void Main(string[] args) //<--- "Main" on programmi sees olev meetod mis vaikeväärtusena alati käivitatakse, kui ei ole teist meetodit käivituseks määratud
		{

			/*näiteprogram 1*/
			//int palk = 2345;
			//int kulud = 1122;

			//Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
			//string kasutajaVastus = "";
			//kasutajaVastus = Console.ReadLine();
			//if (kasutajaVastus == "jah")
			//{
			//    Console.WriteLine("Sisesta kõik kulutused ühe arvuna");
			//    kulud = int.Parse(Console.ReadLine());
			//}

			//int kontojääk = palk - kulud;
			//Console.WriteLine(kontojääk + " puulehte on alles."); //print (kontojääk + "puulehte on alles")
			//    Console.WriteLine("Palun sisesta oma hästi tehtud töö boonus");
			//int boonus = int.Parse(Console.ReadLine()); //boonus =int (input("Palun sisesta oma hästi tehtud töö boonus: "))
			//kontojääk = kontojääk + boonus; //same python
			//Console.WriteLine("Sinu Lõppvälja võte on: " + kontojääk + " puulehte");

			/*
             * 
             * program küsib kasutajalt tema vanust
             * kui ta on noorem kui 18 öeldakse kasutajale "alaealiseid sisse ei lasta"
             * kui on vanem kui 18, pakutakse mojitot
             * 
             */

			//int kasutajaVanus = 0;
			// Console.WriteLine("Kui vana sa oled?");
			// kasutajaVanus = int.Parse(Console.ReadLine());
			// if (kasutajaVanus >= 18)
			// {
			//     Console.WriteLine("Tere, siin on sinu mojito");

			// }
			// else
			// {
			//     Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale või saa endale võltsdokument"); 
			// }


			/*
             * näiteprogram 3:
             
            klient tahab et programm teeks:
            -küsib kasutajalt tema kasutajaNime
            -küsib kasutajalt tema parooli
            -logib kasutaja sisse kui mõlemad on õiged
            */
			//hint : mida teeb &&?

			/* siia käib vooskeemi järgi kirjutatud kood näidisülesanne 3 kohta */

			////ctrl + k + c/u

			int mingiArv = 4;

			mingiArv = mingiArv + 15; //
			mingiArv = mingiArv * 15; //
			mingiArv = mingiArv - 15; //
			mingiArv = mingiArv / 15; //


			mingiArv += 15; //
			mingiArv -= 15; //
			mingiArv *= 15; //
			mingiArv /= 15; //

			///* näiteülesanne 4 */
			//Console.WriteLine("Palun siseta oma vanus"); // esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
			//int kasutajavanus = int.Parse(Console.ReadLine()); // tekitame muutuja kasutajavanus ning omistame sinna käsurealt int.Parse abiga täisarvu
			//Console.WriteLine("Palun sisesta oma vanavanema vanus"); // esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
			//int kasutajaVanavanemaVanus = int.Parse(Console.ReadLine()); // tekitame muutuja kasutajavanus ning omistame sinna käsurealt int.Parse abiga täisarvu
			//int vanusteVahe = kasutajaVanavanemaVanus - kasutajavanus; // tekitame uue täisarvu muutuja kuhu omistame avaldlise kasutajaVanavanaemaVanus - kasutajavanus tulemus
			//Console.WriteLine(kasutajaVanavanemaVanus - kasutajavanus); // saab ka otse kuvada, ilma muutujata
			//Console.WriteLine("Kui palju sa vanem oled?"); // esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
			//kasutajavanus += int.Parse(Console.ReadLine()); // kasutame omistusoperaatorit, et lisada muutujale kasutaja poolt esitatud täisarvu
			//Console.WriteLine("vanuste vahe on nüüd : "+(kasutajaVanavanemaVanus - kasutajavanus)); // kuvame uuesti vanuste vahe koos tekstiga









			/*
             *üleval harjutused
             *https://meet.google.com/qjt-wofj-gdb
             
          

            all teeoria*/


			/* -= S Ü N T A K S =-  */
			// ;         - iga koodilause koodiploki sees lõppeb lauselõpumärgiga
			// Console   - Console on Windowsi süsteemi/C# käsurea adresseerimise pakett, millega saab erinevaid käsutrs operatsioone teha.
			// .         - Kasutatakse adresseerimiseks et saada punktile eelnevast objektist mingisugune meetod funktsioon, mis kirjutatakse pärast punkti,
			//             võib mõelda kui kaustasuunas olevat / släshi. Antud juhul adresseeritakse reas  "1" Console tööriista.
			// Writeline -   Funktsioon mida parasjagu kasutatakse. Writeline kuvab käsureale teksti või kaasaantud parameetreid.
			// ()        - Sulupaar mis omab funktsiooni tööks vajalikku infot/parameetreid.
			// {}        - Tähistab koodiplokki konteineri jaoks.
			// []        - tähistab massiivi.
			// ""        - tähistavad sõne andmetüüpi andmeid. Andmed ise asuvad jutumärkide vahel.
			// "string"  - andmetüüp mis kirjutatakse alati muutuja ette. Andmetüübis endas asuvad ka aldmetüübile vajalikud funktsioonid.
			// "vastus"  - muutuja, mille nimi on "vastus" mis omab string-tüüpi andmeid mis omistatakse sinna sisse omistusoperaatoriga
			// Readline  - Funktsioon mida reas "2" kasutatakse. Readline loeb käsurea pealt väikeväärtusena sõne-tüüpi andmeid. (String= sõne eesti k.)
			// //        - tähistab üherealist kommentaari
			// /**/      - Tähistab plokk-kommentaari, kõik tärnide vahel olev on välja kommenteeritud
			//  ///      - Funktsiooni summary kommentaar, kirjeldab meetodeid mille tekst kuvatakse välja tooltipina
			//           - Taane - aitab arendala aru saada, kuskohas millise koodiploki sees kood parasjagu asub, ning aitab järge pidada.





			/* -= L I H T A N D M E T Ü Ü B I D=-         */
			//string tekst = "mingisugune inimloetav tekstike";
			//char täht = 'A';
			//int arv = 1; //täisarv
			//float komakohagaarv = 1.5f; //32bit
			//double suuremkomakohagaarv = 1.5d; //64bit
			//decimal kümendsüsteemiskomakohagaarv = 1.5M;
			//var X = 123; //Umbmäärase andmetüübiga ajutine muutuja
			//var Y = "ABC";
			//bool jahvõiei = false; //kas true või false

			///*Muutuja nime näide: */
			////string string ="abc"; //is bäd
			//string sõne ="abc";  //is gud

			// 1    2    3   4   5  
			string näidis = "def"; //1 - muutuja kirjutatakse alustades andmetüübist, ilma andmetüübita ei saa C# muutujat deklareerida
								   //2 - Seejärel kirjutatakse muutuja nimi mis väljendab andmed ja nende andmete eesmärki nimisõnana
								   //   soovitatavalt kasutada muutujate nimetamisel camelCase stiili. esimene täht on väike, ülejäänud sõnad muutuja nimes algavad suure tähega.
								   //3 - omistusoperaator mis annab muutujale andmed sisse
								   //4 - andmed mida omistatakse 
								   //5 - lauselõpumärk



			/*       -= O M I S T U S O P E R A A T O R I D=-             */
			// = -> üksik võrdmusmärk omistab muutja sisse väärtuse, mida adresseeritakse muutuja enda nimega
			int muutuja = 1;
			//+= -> võrdmusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
			muutuja += 2;
			//+= -> võrdmusmärk mille ees on miinus, automaatselt lahutab muutujas olevast väärtusest võrdusmärgi teisel pool oleva väärtuse
			muutuja -= 3;
			//+= -> võrdmusmärk mille ees on korrutusmärk, automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva väärtuse kordi
			muutuja *= 3;
			//+= -> võrdmusmärk mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva väärtuse osadeks
			muutuja /= 4;
			// %= -> võrdusmärk mille ees on modulus, automaatselt jätab muutujasse jäägi.
			muutuja %= 2;

			// ++ -> on kiirtehe, mis muutujale liidab ainult ühe juurde. 
			muutuja++;
			// -- -> on kiirtehe, mis muutujast lahutab ainult ühe maha.
			muutuja--;


			/*       -= V Õ R D L U S O P E R A A T O R I D=-             */
			// == -> "on võrdne/on täpselt sama" Võrdlusmärkide ühel pool olev objekt peab vastama oma olemuselt täpselt võrdusmärkide teisel pool oleva objektiga
			// > -> "on suurem kui" - Märgist vasakul pool olev objekt, peaks olema suurem kui paremal pool olev objekt
			// > -> "on väiksem kui" - Märgist vasakul pool olev objekt, peaks olema väiksem kui paremal pool olev objekt
			// >= -> "on suurem kui, või samavõrdne" - Märgist vasakul pool olev objekt peaks olema vähemalt sama suur või suurem 
			// kui parem pool olev objekt
			// <=  -> "on väiksem kui või samavõrdne" - Märgist vasakul pool olev objekt peaks olema maksimaalselt sama suur või väiksem kui paremal pool olev objekt
			// != -> "ei tohi olla" võrdusmärgi vasakul pool olev objekt ei tohi omada IDENTSET kuju paremal pool oleva objektiga, kõik muud väärtused on lubtatud.

			/* -= L O O G I L I S E D   T E H T E D */
			// && -> "AND" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
			// mõlemal pool märki "&&" (ehk AND AND ) olevad tingimused omakorda annavad oma avaldise tulemusena "true"
			// või teisisõnu: true + true = true

			// -> "OR" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
			// ühel pool märki "||" olev tingimus omakorda annavad oma avaldise tulemusena "true", ei ole vahet millisel pool märki
			// või teisisõnu: true + false = true

			// ! -> "NOT" loogiline tehe, mida kasutatakse tingimuse avaldise tulemuse inverteerimiseks. Tulemus mis muidu tagastaks "true",
			// hüümärgi abil nüüd tagastab false ja vastupidi - tulemus mis muidu tagastaks "false", nüüd tagastab "true".
			// ehk teisisõnu: true = false / false = true


			/* -= T I N G I M U S   L A U S E */
			if (true)  // Kaitstud sõna "if" kutsub esile tingimuslause, mille tingimuse avaldis on sellele järgnevate () sulgude vahel.
			{ // Järgneb {} loogeliste sulgude vahel koodiplokk, mis teostatakse siis, kui tingimuse avaldis annab tuleusena "true",
			  // "false" tulemuse puhul jäetakse kood vahele.

			}

			// else if //true // Kaitstudsõna "else" ja "if " (koos "else if") kutsuvad esile sekundaar tingimuslause, mille tingimus on samamoodi
			// Sellele järgnevate sulgude vahel, ning millele peab alati eelnema kas "if" või teine "else if". Else if tingimust 
			// Kontrollitakse ainult siis, kui sellele eelnev tingimus tagastab avaldise tulemusena "false".
			// Järgneb {} loogeliste sulgude vahel koodiplokk, mis teostatakse siis, kui tingimuse avaldis annab tuleusena "true",
			// "false" tulemuse puhul jäetakse kood vahele ning minnakse edasi järgneva tingimuse või teostatava koodi juurde.

			else   // Kaitstud sõna "else" kutsub esile järeltingimuslause, millele peab eelnema alati kas "if" või " else if" tingimuslause, ning
				   // mille koodiplokki sisu täidetakse ilma oma tingimuse avaldise kontrollita (ei oma avaldist) kuna else koodiplokk teostatakse 
				   // kõikide teiste tingimuste läbikukkumisel (kõik eelnevad tagastavad tulemusena "false").
			{ }


			/* =- T E I S E N D A M I N E / C A S T I M I N E =- */

			//castimine on arvu teisendamine ühest andmetüübist teise. Castimist on kahte eri liiki, Automaatne (implicit) ja manuaale (explicit)
			//Automaatne castimine toimub siis, kui teisendatakse väiksemast andmetüübist suuremasse, sellisel juhul programeerija spetsiifiliselt castima ei pea
			//Manuaalne castimine toimub siis, kui teisendatakse suuremast andmetüübist väiksemasse, sellisel juhul on vaja suurema andmetüübiga
			//muutuja ette, asetada sulupaar kus on soovitav andmetüüp sees.


			//Manuuaalne castimine (explicit)

			double newData2 = 1.23d; //tekitatakse või on olemas doubletüüpi andmeid muutujas newData2
			float newFloat2 = (float)newData2; // toimub teisendus väiksemasse float andmetüüpi, double andmetüübist
			long newLong2 = (long)newFloat2; // toimub teisendus väiksemasse long andmetüüpi, float andmetüübist
			int newInt2 = (int)newLong2; // toimub teisendus väiksemasse int andmetüüpi, long andmetüübist
			char newChar2 = (char)newInt2;// toimub teisendus väiksemasse char andmetüüpi, int andmetüübist

			//Automaatne castimine (implicit)
			int backToInt2 = newChar2;// toimub automaatne teisendus char andmetüübist int andmetüüpi
			long backToLong2 = backToInt2;  //toimub automaatne teisendus int andmetüübist long andmetüüpi
			float backToFloat2 = backToLong2; // toimub automaatne teisendus long andmetüübist float andmetüüpi
			double backToDouble2 = backToFloat2; // toimub automaatne teisendus float andmetüübist double andmetüüpi


			//suuremast väiksemasse teisendus kaotab andmeresolutsiooni
			//kaotatud andmeid ei saa tagasi suuremasse andmetüüpi castimisega tagasi


			//Parsimine on tekstist  katse teisendada mingit tüüpi arv andmeid. Teisendus toimub küsides mingist andmetüübist talle sisseehitatud meetodi "Parse () abil"
			// mingist sõnest arvandmeid. 
			//string seeonTekst = "1";                         // Mingisugune sõne mis omab endas potentsiaalselt mingit arvulist väärtust
			//int teisendatud = int.Parse(seeonTekst);         // Muutuja "teisendatud" kuhu omistatakse "Parse()" meetodi abil sõnest arvväärtust
			//Console.WriteLine(teisendatud);                  // teisenduse väljakuvamine


			// Parsimisel on olemas ka alternatiivne meetod "TryParse()". TryParse üritab teisendada, ning kui teisendus kukub läbi,
			// tagastatakse algneväärtus/false
			// 
			//string seeOnTekst2 = "2";
			//Console.WriteLine(int.TryParse(seeOnTekst2, out int result));

			//Konverteerimine on mingisuguse andme otsene teisendus ükskõik millisesse teise andmetüüpi. Selle jaoks on olemas moodul "Convert".
			//Convert moodulis on sarnaselt arvandmetüüpides olevale ToString() meetodile ka muude andmetüüpide vastavad konverteerimismeetodid.
			//string mingiInfo = "6.7";    //On olemas mingisugune teisendamist vajav info
			//string mingiInfoTekst = Convert.ToString(mingiInfo);       // Convert.ToString() teisendab tundmatust andmetüübist info stringiks/sõneks (eesti k.)
			//char mingiInfoChar = Convert.ToChar(mingiInfo);            // teisendus täheks
			//int mingInfoInt = Convert.ToInt32(mingiInfo);              // teisendus int andmetüüpi
			//long mingiInfoLong = Convert.ToInt64(mingiInfo);           // teisendus long andmetüüpi
			//decimal mingiInfoDecimal = Convert.ToDecimal(mingiInfo);   // teisendus decimaliks
			//double mingiInfoDouble = Convert.ToDouble(mingiInfo);      // teisendus double andmetüüpi
			//byte mingInfoByte = Convert.ToByte(mingiInfo);             // teisendus baidiks
			//bool mingiInfoBool = Convert.ToBoolean(mingiInfo);         // teisendus boolean andmetüüpi




			/* T S Ü K L I D */
			// Tsüklid on programeerimise viis, kuidas automatiseerida korduv tegevus ära, see aitab hoida andmemahtu kokku, programmeerija sama koodi mitu korda kirjutamist
			// ning väldib ka kordustest tekkinud vigu. C# on neli peamist tsükli liiki - 
			// 1. do-while
			// 2. while
			// 3. for
			// 4. foreach
			// Tsüklitel on kolm peamist komponenti - käsklus ise, tsükli tingimus ja tehtav kood

			/* T S Ü K L I D        DO-WHILE     */
			// Do-while tsükkel erineb kõigist teistest tsüklitest, sellega et tingimuse kontroll toimub pärast esimest tegevuseringi.
			// Kõikides teistes tsüklites toimub tingimusekontroll enne esimest ringi.
			int tsükliMuutuja1 = 0;                      // Mingisugune muutuja mis omab tsükli töö tingimuse abil kontrollimiseks vajalikku väärtust ehk tsüklimuutuja
														 // "do" on kaitstud sõna, mis alustab do while tsüklit, sellele järgneb tsüklis tehtav koodiplokk
														 // ning mis esimene ring täidetakse ilma tingimuse kontrollita.
			do
			{
				Console.WriteLine(tsükliMuutuja1);      //Koodiploki sees olev tegevus, antud juhul kuvatakse tsüklimuutuja arv välja
				tsükliMuutuja1++;                       // ning tsüklimuutujat suurendatakse
														// ILMA TSÜKLIMUUTUJA KAASAMISETA TSÜKLI TÖÖSE, KÄIB TSÜKKEL RINGI LÕPMATULT, TSÜKLIMUUTUJA TULEB MINGIL KUJUL MUUTA KAS KAUDSELT VÕI
														// OTSESELT, ET SÜSTEEM SAAKS EDASI TEISTE TEGEVUSTE JUURDE MINNA, ILMA SELLETA SEE EI OLE VÕIMALIK.
			}
			while (tsükliMuutuja1 != 5);              // "while" on kaitstud sõna mis do-while tsükli lõpetab, pärast seda toimub esimene tingimuse kontroll
													  // kus kontrollitakse tsükli töösse kaasatud muutuja olukorda. Kui tingimus täitub
													  // ehk tingimuse avaldise tulemus on "true" täidetakse veel üks ring, ning kontrollitakse tingimust uuesti.
													  //Antud juhul tsükkel toimib nii kaua, kuni tsüklimuutuja ei ole 5, ta saab olla 4 ja 6 jne aga mitte 5.



			/*           -= J U H U A R V=-            */
			//
			//Random klass annab võimaluse programmeerijale genereerida pseudo-random väärtusi.
			Random juhuArv = new Random();         //klassinimi "Random" on kasutatav kui andmetüüp, mis ütleb et järgnevas muutujas nimega "juhuArv" on
												   //uus random tüüpi objekt, mis omistatakse sinna "new Random()" käsuga. Konstruktor ulatab muutuja sisse
												   // Random tüüpi klassi. Antud muutuja nüüd ise ei ole see juhuArv, ta toimib kui juhuarvude generaatorina.
												   //Millest punkti abil saab adresseerida Random genereerimise tööriistu
			int a = juhuArv.Next();                // .Next() on meetod Random klassis, mis on genereeriv meetod juhuArv genereerimiseks. 
												   // seda saab kasutada kui väärtusena ning ta tagastab suvalise arvu . Ilma parameetrita tagastab
												   //andmetüübi maksimaalpiirides mingisuguse juhuArvu.



			int miski = juhuArv.Next(5);           //.Next() ühe parameetriga anname talle ülemise piiri, mille alumine piir on vaikeväärtusena 0
			int miski2 = juhuArv.Next(-5, 5); //.Next () kahe parameetriga kirjeldab ära täieliku vahemiku, olgu see siis negatiivne või positiivne
			double aDbl = juhuArv.NextDouble();     //.NextDouble() annab double-tüüpi väärtusi, parameetri kasutus on identne.
			float aLng = juhuArv.NextSingle();    //.NextSingle() annab float-tüüpi väärtuse mis on vahemikus 0.0 ja 1.0.


			//* -= K O M P O S I I T A N D M E T Ü Ü B I D -= */


			//// 
			//Console.WriteLine("Sisesta oma nimi");
			//string nimi = Console.ReadLine();
			//if (nimi == "Nipitiri")
			//{
			//    Console.WriteLine("Tere tulemast Nipitiri");
			//}
			//else
			//{
			//    Console.WriteLine("Ma ootan ainult Nipitirisi.");
			//}


			////
			//Console.WriteLine("Kas teile meeldivad tulbid");
			//string nimi2 = Console.ReadLine();
			//if (nimi2 == "Jah")
			//{
			//    Console.WriteLine("Mulle ka");
			//}
			//else
			//{
			//    Console.WriteLine("Ei saa teist aru");
			//}



			//// 
			//Console.WriteLine("Mis on teie viimase nädala mängitud tunnid? ");
			//float tunnid = float.Parse(Console.ReadLine());
			//if (tunnid == 0)
			//{
			//	Console.WriteLine("kahju et sul aega mängida pole :c");
			//}
			//else if (tunnid > 0 && tunnid <= 10)
			//{
			//	Console.WriteLine("Mõõdukas mängija, tubli!");
			//}
			//else if (tunnid > 10 && tunnid <= 20)
			//{
			//	Console.WriteLine("natuke paljuks läheb, kodutööd kannatavad");
			//}
			//else if (tunnid > 20 && tunnid <= 40)
			//{
			//	Console.WriteLine("Liiga palju mängid, kas sa kooli üldse nii jõuad?");
			//}
			//else
			//{
			//	Console.WriteLine("siin peaks juba sekkuma psühholoog");
			//}


			//////
			//Console.WriteLine("Mis on teie kõige hiljutisem jalgpallimängu tulemus? ");
			//int tund = int.Parse(Console.ReadLine());
			//if (tund <= 0)
			//{
			//    Console.WriteLine("PUDRUJALG OLED VÄ?!?! ");
			//}
			//else if (tund <= 1)
			//{

			//    Console.WriteLine("Täitsa ok");

			//}
			//else if (tund <= 2)
			//{
			//    Console.WriteLine("No see on juba parem");
			//}
			//else if (tund <= 3)
			//{
			//    Console.WriteLine("Wow Messi ");
			//}
			//else 
			//{
			//    Console.WriteLine(" Ei tunne sellist skoori, see liiga suur mu jaoks");
			//}

			////// #n1. "Tervitus"
			////// kirjuta programm mis,
			////// - küsib tsükliga kasutajalt tema eesnime
			//string eesNimi = string.Empty;
			//while (eesNimi == string.Empty)
			//{
			//    Console.WriteLine("Palun sisesta oma nimi siia: ");
			//    eesNimi = Console.ReadLine();
			//}
			//// - - küsitakse uuesti tühja sisendi korral
			//// - küsib kasutajalt tema keskmist nime
			//string keskmineNimi = string.Empty;
			//while (keskmineNimi == string.Empty)
			//{
			//    Console.WriteLine("Palun sisesta keskmine nimi siia: ");
			//    keskmineNimi = Console.ReadLine();
			//}
			//// - - küsitakse uuesti tühja sisendi korral
			//// - küsib kasutajalt tema perekonnanime
			//string perekonnaNimi = "";
			//while (!(perekonnaNimi != string.Empty))
			//{
			//    Console.WriteLine("Palun sisesta ka oma perekonnanimi siia: ");
			//    perekonnaNimi = Console.ReadLine();
			//}
			//// - - küsitakse uuesti tühja sisendi korral
			//// - tema vanust
			//int minuVanus = 0;
			//while (minuVanus < 1)
			//{
			//    Console.WriteLine("Palun sisesta ka oma vanus siia: ");
			//    minuVanus = int.Parse(Console.ReadLine());
			//}
			//// - - küsitakse uuesti tühja sisendi korral
			//// - ning väljastab talle tervituslause, kasutades kõiki muutujaid
			//Console.WriteLine($"Tere päevast {eesNimi} {perekonnaNimi}! Või kutsun sind {keskmineNimi}? Oled tublisti kasvanud, oled juba {minuVanus}-aastane");


			////// #n2. "Minu lemmiksnäkk"
			////// kirjuta programm mis
			////// küsib kasutajalt mis on ta lemmiksnäkk
			////// programm kontrollib tsükliga kas järjendis on snäkk olemas
			////// kui tsüklis leitakse snäkk, kuva tekst koos kasutajasisendiga, "jaa :D tean seda, {snäkk} on hea"
			////// kui tsükkel lõppeb ilma snäkki leidmata, kuva tekst "ei tunne kahjuks {snäkk}i :C"

			////// nimekiri snäkkidest
			//List<string> snäkid = new List<string>() { "limonaad", "kõrsikud", "ŠnikurŠ", "krõpsud", "popcorn" };
			//// kasutaja sisestuse jaoks muutuja
			//string kasutajaleMeeldib = string.Empty;
			//// kas snäkk on olemas või mitte, vaikeväärtusena ei ole
			//bool isPresent = false;
			//// tsükkel mis käib niikaua kuni leitakse kasutajale meeldiv snäkk mida programm teab
			//while (isPresent != true)
			//{
			//    // küsime kasutajalt infot
			//    Console.WriteLine("Sisesta oma lemmiksnäkk: ");
			//    kasutajaleMeeldib = Console.ReadLine();

			//    //kontrollime seda infot
			//    foreach (var snäkk in snäkid)
			//    {
			//        // kui leitakse vaste
			//        if (snäkk == kasutajaleMeeldib)
			//        {
			//            // seatakse muutujale väärtus true
			//            isPresent = true;
			//        }
			//    }
			//    // kuvame kasutajale sõnumi olenevalt infokontrolli tulemuse tagajärjel
			//    if (isPresent == true) // kui leitakse, kuvatakse sõnum a
			//    {
			//        Console.WriteLine($"jaa :D tean seda, {kasutajaleMeeldib} on hea");
			//    }
			//    else // muidu kuvatakse sõnum b
			//    {
			//        Console.WriteLine($"ei tunne kahjuks {kasutajaleMeeldib}i :C");
			//    }
			//}

			////// #n3. "Metsataimede välimääraja"
			////// kirjuta programm mis
			////// küsib kasutajalt kas ta otsib mingit seent või marja (tsüklis)
			////// kui seent, siis programm esitab seeneloendis olevad seened
			////// ja küsib millise seene kohta infot infojärjendist kuvada
			////// tsükkel siis käib ja otsib teisest järjendis seene infot ja kuvab selle
			////// kui marja, siis programm esitab marjaloendis olevad marja
			////// ja küsib millise marja kohta infot infojärjendist kuvada
			////// tsükkel siis käib ja otsib teisest järjendis marja infot ja kuvab selle
			////// siis küsitakse kas kasutaja tahab mõne marja kohta veel infot, ning tsükkel jätkub
			////// ⭐iseseisvalt lisa juurde puude tuvastamine ⭐

			//bool anuddaJuan = true; // hoiame meeles kas kasutaja tahab veel infot
			//string mida = string.Empty; // mida kasutaja täpselt tahab
			//List<string> valikud = new List<string>() { "seent", "marja", "puud" }; // loend võimalike valikutega
			//List<string> seeneNimed = new List<string> { "kukeseen", "puravik", "sitaseen" }; // seenevalikute loend nimedega
			//List<string> seeneInfod = new List<string>
			//{
			//    "Kukeseen on kollane ja näeb välja nagu keegi oleks pasuna maha \nmatnud ning siis mootorattaga üle sõitnud.",
			//    "Puravik on pealt pruun ja jalg on hele. Siuke ilus punsu.",
			//    "Sitaseen on pruun, keerlev ja tõenäoliselt lähima koera poolt tehtud kingitus."
			//}; // seente infode loend
			//List<string> marjaNimed = new List<string> { "astelpaju", "muulukas", "maasikas" }; // marjavalikute loend nimedega
			//List<string> marjaInfod = new List<string>
			//{
			//    "Astelpaju on kollane, maitseb nagu apelsin ja selle seeme on alfa-suurusega",
			//    "Kes seda teab milline muulukas välja näeb...",
			//    "Maasikas on maailma parim mari, kui sa leiad selle metsast, mitte poest."
			//};// marjade infode loend
			//List<string> puudeNimed = new List<string> { "Tamm", "Saar", "Banaanipalm" }; // puudevalikute loend nimedega
			//List<string> puudeInfod = new List<string>
			//{
			//    "Tamm on suur ja tugev ning võib elada mitmesaja aastaseks, lehed on sinkavonkalised.",
			//    "Saar on ka suur ja tugev, kuid erinevalt tammest ei ole mürgine.",
			//    "Banaanipalm on rohuline, mingi tohman pani selle puude hulka."
			//};// puude infode loend

			//while (anuddaJuan == true) // tsükkel käib niikaua kuni kasutaja tahab infot veel saada
			//{
			//    do // kusime kasutajalt selle tsükliga mida ta tahab
			//    {
			//        Console.WriteLine("Kas sa otsid seent, marja või puud?");
			//        mida = Console.ReadLine(); // omistame muutujasse väärtuse
			//    }
			//    //while (mida != "seent" || mida != "marja");
			//    //while (!new List<string>() { "seent", "marja"}.Contains(mida));
			//    while (!valikud.Contains(mida)); //ning kontrollime kas sisestatud väärtus on üks valikutest

			//    if (mida == "seent") // kui on valitud seent
			//    {
			//        List<int> seeneValikud = new List<int>() { 1, 2, 3 }; //tekitame võimalike sisestuste arvloendi
			//        int seeneArv = 0; // hetkel on valik väljaspool võimalikke arvude vahemikku
			//        do // küsime kasutajalt millist seent võimalikest ta tahab
			//        {
			//            Console.WriteLine("Palun vali seen, mille kohta tahad infot, valikus on " + seeneNimed.Count + " tükki");
			//            for (int i = 0; i < seeneNimed.Count; i++) //kuvame valikud arvudega
			//            {
			//                Console.WriteLine((i + 1) + ". " + seeneNimed.ElementAt(i));
			//            }
			//            seeneArv = int.Parse(Console.ReadLine()); //ja ootame kuni kasutaja sisestab arvu
			//        } while (!seeneValikud.Contains(seeneArv)); // küsime niikaua kuni sisestatud on üks valikutest

			//        Console.WriteLine(seeneInfod.ElementAt(seeneArv - 1)); // kui tsükkel saavutab tahetud tulemuse kuvame valiku
			//    }
			//    else if (mida == "marja") // kui on valitud marja siis -||-
			//    {
			//        List<int> marjaValikud = new List<int>() { 1, 2, 3 };
			//        int marjaArv = 0;
			//        do
			//        {
			//            Console.WriteLine("Palun vali mari, mille kohta tahad infot, valikus on " + marjaNimed.Count + " tükki");
			//            for (int i = 0; i < marjaNimed.Count; i++)
			//            {
			//                Console.WriteLine((i + 1) + ". " + marjaNimed.ElementAt(i));
			//            }
			//            marjaArv = int.Parse(Console.ReadLine());
			//        } while (!marjaValikud.Contains(marjaArv));

			//        Console.WriteLine(marjaInfod.ElementAt(marjaArv - 1));
			//    }
			//    else // kui on valitud midagi muud, antud juhul saab ainult puud olla, siis ka  -||-
			//    {
			//        List<int> puudeValikud = new List<int>() { 1, 2, 3 };
			//        int puudeArv = 0;
			//        do
			//        {
			//            Console.WriteLine("Palun vali mari, mille kohta tahad infot, valikus on " + puudeNimed.Count + " tükki");
			//            for (int i = 0; i < puudeNimed.Count; i++)
			//            {
			//                Console.WriteLine((i + 1) + ". " + puudeNimed.ElementAt(i));
			//            }
			//            puudeArv = int.Parse(Console.ReadLine());
			//        } while (!puudeValikud.Contains(puudeArv));

			//        Console.WriteLine(puudeInfod.ElementAt(puudeArv - 1));
			//    }
			//    string kasutajaOtsus = ""; // teeme muutuja kasutaja otsuse jaoks programmi kasutamise kohta
			//    do //küsime talt kas ta tahab infot veel
			//    {
			//        Console.WriteLine("Kas tahad veel infot? jah/ei");
			//        kasutajaOtsus = Console.ReadLine(); //ootame temalt vastuse
			//    } while ((kasutajaOtsus != "jah" && kasutajaOtsus != "ei")); //ning kui ta ei ole jah või ei, küsime uuesti
			//    if (kasutajaOtsus == "jah") // kui vastus on jah
			//    {
			//        anuddaJuan = true; //seame muutuja mis hoiab meeles kas kasutaja tahab veel infot väärtuseks true
			//    }
			//    else
			//    {
			//        anuddaJuan = false; //kõige muu puhul false
			//    }
			//}
			//Console.WriteLine("Head aega!"); //kui põhitsükkel katkeb, ütleme headaega


			//// #n4. "Stonksid"
			//// kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
			//// küsib kasutajalt temapoolse investeeritava summa ✅
			//// küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)✅
			//// valitud firma kohta otsustab programm kordaja. ✅
			//// kui selleks on Tesla, siis on kordaja fikseeritud -1.15 ✅
			//// kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde ✅
			//// kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne. ✅
			//// programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta ✅
			//// tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse ✅
			//// kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
			//// kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
			//// kuvatakse kasutajale tema portfelli lõppväärtus.
			//float teslaRate = -1.15f;
			//float msRate = 0f;
			//float wiseRate = 0f;
			//Random generator = new Random();
			//string reinvest = "";
			//while (reinvest != "ei")
			//{

			//	float investment = 0.0f;
			//	do
			//	{
			//		Console.WriteLine("Palun sisesta summa mida soovid investeerida");
			//		investment = float.Parse(Console.ReadLine());
			//	} while (investment <= 0f);
			//	List<string> companies = new List<string>() { "Tesla", "TransferWise", "Macro$lop" };
			//	string userOption = "";
			//	do
			//	{
			//		Console.WriteLine("Palun sisesta ka firma mille aktsiatesse soovid investeerida, kirjuta firma nimi,");
			//		foreach (var company in companies)
			//		{
			//			Console.WriteLine(" - " + company);
			//		}
			//		userOption = Console.ReadLine();

			//	} while (!companies.Contains(userOption));
			//	int investmentDays = 0;
			//	do
			//	{
			//		Console.WriteLine("Palun sisesta mitu päeva soovid oma investeeringut portfellis hoida");
			//		investmentDays = int.Parse(Console.ReadLine());
			//	} while (investmentDays < 0);
			//	int i = 0;
			//	float cycleRate = 0f;

			//	while (i < investmentDays)
			//	{

			//		double fixture = generator.Next(1, 100);
			//		double result = (fixture / 1000) + 1;
			//		wiseRate = (float)result;
			//		msRate = (float)(result - result * 2);
			//		switch (userOption)
			//		{
			//			case "Tesla":
			//				cycleRate = teslaRate;
			//				if (investment < 0)
			//				{
			//					investment = (investment - investment * 2);
			//				}
			//				break;
			//			case "Macro$lop":
			//				cycleRate = msRate;
			//				if (investment < 0)
			//				{
			//					investment = (investment - investment * 2);
			//				}
			//				break;
			//			case "TransferWise":
			//				cycleRate = wiseRate;
			//				break;
			//			default:
			//				break;
			//		}
			//		investment *= cycleRate;

			//		Console.WriteLine((i + 1) + ". päeva tulemus: Firma - " + userOption + " aktsia muutus kordajaga: " + cycleRate + "\nSinu portfellist on alles " + investment + " raha.");
			//		i++;
			//	}
			//	if (investment > 0)
			//	{
			//		Console.WriteLine("Kas tahad uuesti investeerida? sinu portfell on hetkel väärt: " + investment);
			//		List<string> vastused = new List<string>() { "jah", "ei" };

			//		do
			//		{
			//			Console.WriteLine("Palun sisesta ka firma mille aktsiatesse soovid investeerida, kirjuta firma nimi,");
			//			foreach (var answer in vastused)
			//			{
			//				Console.WriteLine(" - " + answer);
			//			}
			//			reinvest = Console.ReadLine();

			//		} while (!vastused.Contains(reinvest));
			//	}
			//	else
			//	{
			//		Console.WriteLine("Oled pankrotis, sinu portfell on väärt:" + investment);
			//		reinvest = "ei";
			//	}
			//}
			//Console.WriteLine("lõpparve");

			//4. Tuple




			/* 3- SÕNASTIK */
			//Dictionary <T, T>       -> Dictionary on komposiitandmetüüp, mis omab võtiväärtuspaare. Erinevalt eelnevatest komposiitandmetüüpidest, 
			// saab omada kahte erineevat andmetüüpi millest esimene väljendab võtme andmetüüpi ning teine võtme taga olevat 
			// väärtuse andmetüüpi. Need andmetüübid saavad üksteisest erineda või isegi omada klasse andmetüüpidena ning ka
			// muid komposiitandmetüüpe.
			//Esimene tekitusviis
			Dictionary<int, string> sõnastik = new Dictionary<int, string>();
			// Andmetüübi kirjeldus "Dictionary<>" näitab et tegu on sõnastikuga, ehk loendiga võtiväärtuspaaridest. Dictionary noolsulgude vahel asetatakse kaks andmetüüpi, esimene neid on võtme andmetüüp (antud juhul "int") teine neist on võtme taga oleva väärtuse andmetüüp (antud juhul "string).
			// Muutuja nimeks on "sõnastik" kuhu omistatakse käsusõnaga "new" uus tühi sõnastik vastavate andmetüüpidega.

			Dictionary<int, string> sõnastik2 = new Dictionary<int, string>() { { 1, "astelpaju" }, { 2, "muulukas" }, { 3, "maasikas" } };
			//Muutuja nimeks on "sõnastik" kuhu omistatakse käsusõnaga "new" uus sõnastik koos elementidega, mis asuvad sulgude taga olevates loogelistes
			//sulgudes ja iga element ise on veel omakorda loogelistes sulgudes infoga mis vastab dictionary andmetüüpide sätestusele.

			//Sõnastiku tööriistad
			sõnastik.Add(4, "tikker");         //.Add() võimaldab olemasoleva sõnaraamatu lõppu lisada elementi. Sulgude vahel on andmed, mille andmetüübid
											   //vastavad täiendatava sõnastiku andmetüüpide sätestusega.
			sõnastik.Remove(2);               //.Remove() eemaldab kindla võtme järgi sõnastikus oleva elemendi. Sulgude vahel on selle võtme andmetüübile vastav
											  // väärtus mitte võtme taga oleva väärtuse väärtus.
			sõnastik.Clear();                 //.Clear() teeb sõnastiku täielikult tühjaks

			sõnastik.ContainsKey(4);          //.ContainsKey() tagastab kas "true" või "false" vastavalt sellele kas ta leiab antud sõnastikust parameetrina 
											  // kaasa antud võtme.
			sõnastik.ContainsValue("tikker");   //.ContainsValue() tagastab kas "true" või "false" vastavalt sellele kas ta leiab antud sõnastikust parameetrina 
												// kaasa antud väärtuse.


			/* 4- TUPLE  /MITMIK/HULK   */
			//Andmetüübi kirjeldus "Tuple<>" näitab et siin on tegu erinevate andmete hulgaga ehk mitmikuga. Tuple noolsulgude vahele asetatakse
			//vajadusel erinevad andmetüübid mis väljendavad tupli sees väljenduvate andmete asukohtade andmetüüpe. Kui esimene andmetüüp on string, siis
			// Tuple esimene objekt on string tüüpi andmed, kui teine andmetüüp on List<int[]> hoitakse teises objektis loendeid mille sees on massivid
			//täisarvudega. Just nagu kõik teised komposiitandmetüübid, võtab ka Tuple vastu kõiki andmetüüpe kaasaarvatud iseennast. 
			//Erinevalt teistest komposiitandmetüüpidest, ei saa ühte Tuple elementi kohapeal muuta, vaid kogu Tuple tuleb protsessi käigus rekombineerida
			//muudetud andmetest ja olemasolevatest andmetest uuesti.
			Tuple<string, string> piparmünditupla = new Tuple<string, string>("vasak tupla", "parem tupla");
			//Esimene tekitusviis:
			Tuple<bool, int, string> someTuple = new Tuple<bool, int, string>(true, 1, "abc");
			//Andmetüübi kirjeldus "Tuple<>" ütleb et selles mutujas on mitmik. Selles mitmikus on esimeseks bool teiseks int ja kolmandaks string tüüpi
			//objektid. Tuple vajab ka kohe esmast omistust, seega kaitstud sõna new ja andmetüübi täiskirjeldus "Tuple<bool, int, string> vajab peale seda
			//sulgude vahele esmaseid andmeid.Antud juhul on siin ( true, 1, "abc" );

			//Tuple töötlemine:
			// Ütleme, et on olemas ülaltoodud piparmündiTupla. See on Tuple. Justnagu päris tupla, tahame sealt ühe ära süüa, ehk asendada ühest kahest
			//objektist uue sõnaga mis loeks "NJÄM NJÄM NJÄM".
			//Tuplet ei saa muuta, aga seda saab rekombineerida, seega me saame teha nii:
			string uuspool = "NJÄM NJÄM NJÄM";
			piparmünditupla = new Tuple<string, string>(piparmünditupla.Item1, uuspool);

			//Tupla adresseerimine:
			//just nagu eelnevalt näidatud, me saame adresseerida tuple erinevaid objekte siiski eraldi. Selle jaoks on iga tekitatud Tuple sees genereeritud
			// muutujuad ".Item#" millega me saame adresserida soovitud objekti.
			//NB! erinevalt loendist ja massiivist, algab lugemine arvust 1. ehk esimene Item ei ole Item0 vaid Item1.
			string pool1 = piparmünditupla.Item1; //siin aseetame muutujasse "pool1" valitud tuplest esimese objekti, ning
			string pool2 = piparmünditupla.Item2; // seal asetame muutujasse "pool2" valitud tuplest teise objekti 






			/* Do-while ülesanded*/

			// 1. "arvuta kuni summani"
			// tee muutuja "täisarv" mille sees on täisarv 0
			// kirjuta do while tsükkel
			// tsükli tegevusena lahuta muutujast "täisarv" maha 2
			// ja kuva muutuja "täisarv" välja
			// -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib kas muutujas "täisarv" on arv miinuses rohkem kui -31
			// peale tsüklit kuva sõnum "tsükkel lõppes"
			//int täisArv = 0;
			//do
			//{
			//    täisArv = täisArv - 2;
			//    Console.WriteLine(täisArv);
			//}
			//while (-31 < täisArv);
			//Console.WriteLine("Tsükkel lõppes");

			// 2. "pikenda sõnumit"
			// tee muutuja "sõnum" mille sees on tühi string, nt ""
			// kirjuta do while tsükkel
			// tsükli tegevusena küsi kasutajalt sõnumile lisa "palun lisa järgmine sõnumi osa
			// lisa muutujasse "sõnum" kasutaja poolt tehtud sisestus
			// kuva muutuja "sõnum" välja
			// -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib muutuja "sõnum" pikkust .Length abil, kui sõnum on pikem kui 140 tähte, siis tsükkel lõppeb
			// peale tsüklit kuva sõnum "see sõnum enam twitterisse ei mahuks, kirjuta vähem fam"

			//string sõnum = "";
			//do
			//{
			//	Console.WriteLine("palun lisa sõnumi järgmine osa");
			//	string sisestus = string.Empty;
			//	sisestus = Console.ReadLine();
			//	sõnum += sisestus;
			//	Console.WriteLine(sõnum);
			//}
			//while (sõnum.Length < 140);
			//Console.WriteLine("see sõnum enam X-i ei mahu, kirjuta vähem bucko");







			/* näiteülesanne 8 */
			//kirjuta programm mis
			//küsib kasutajatelt pikkust sentimeetrites
			//küsib tema teiste perekonnaliikmete pikkust (ema isa vend)
			// programm arvutab välja perekonna keskmise pikkuse, vanemate keskmise pikkuse, laste keskmise pikkuse ja kahe keskmise vahe,
			// kõik arvud peab programm esitama komakohtadega arvudena
			//int kasutajapikkus = 0;
			//int vennapikkus = 0;
			//int emapikkus = 0;
			//int isapikkus = 0;
			//List<int> vanused = new List<int>();
			//List<string> isikud = new List<string>() { "sinu", "oma venna", "oma isa", "oma ema" };
			//int i = 0;
			//do
			//{
			//    Console.WriteLine("Sisesta "+isikud.ElementAt(i)+" pikkus sentimeetrites");
			//    //kuvame kasutajale teate koos isikuga mida adresseeritakse tsüklimuutuja abil järjendist "isikud"
			//    vanused.Add(int.Parse(Console.ReadLine()));
			//    // .Add on listi meetod elemendi lisamiseks, lisatakse otse parsitud täisarv käsurea pealt
			//    i++;
			//    // suurendame i-d ühe võrra
			//}
			//while (i < isikud.Count);


			//float perekeskmine = ((float) (vanused.ElementAt(0) + vanused.ElementAt(3) + vanused.ElementAt(1) + vanused.ElementAt(2)) /4)/ 100;
			//float lastekeskmine = ((float) (vanused.ElementAt(0) + vanused.ElementAt(1)) / 2) / 100;
			//float vanematekeskmine = ((float)(vanused.ElementAt(3) + vanused.ElementAt(2)) / 2) / 100;
			//float vahe = 0;
			//if (vanematekeskmine > lastekeskmine)
			//{
			//    vahe = vanematekeskmine - lastekeskmine;
			//}
			//else
			//{
			//    vahe = lastekeskmine - vanematekeskmine;
			//}
			//Console.WriteLine("perekeskmine on "+Math.Round (perekeskmine,2)+"m. vanematekeskmine on "+Math.Round(vanematekeskmine,2)+"m./nlastekeskmine on "+Math.Round(lastekeskmine,2)+"m. kahe keskmise vahe on "+Math.Round(vahe,2)+"m.");



			///* näiteülesanne 5 */
			//Console.WriteLine("Kui kaugele oli su viimane kuulitõuge? sisesta meetrites");
			//float kaugus = float.Parse(Console.ReadLine());
			//if (kaugus <= 1.00 && kaugus >= 0.00 )
			//{
			//    Console.WriteLine("Sa suudad kindlasti rohkem, topis");
			//}
			//else if (kaugus<= 2.00 || kaugus >= 1.01)
			//{
			//    Console.WriteLine("Anna hagu juurde!");
			//}
			//else if (kaugus<= 3.00 && kaugus >= 2.01)
			//{
			//    Console.WriteLine("Normlana, kolm meetrit umbes");
			//}
			//else if (kaugus < 0)
			//{
			//    Console.WriteLine("Miks tagurpidi viskad? Loll oled vä??");
			//} 
			//else
			//{
			//    Console.WriteLine("Ossaraks, seda on arsti juba orbiidilt näha");
			//}



			/* näiteülesanne 6*/

			//Console.WriteLine("Palun sisesta oma vanus, kirjuta täisarvuna: ");
			//int isikuVanus = 0;
			//isikuVanus = int.Parse(Console.ReadLine());
			//if (isikuVanus <= 0)
			//{
			//    Console.WriteLine("Ajarändureid me ei teeninda");



			//}
			//else if (isikuVanus > 0 && isikuVanus < 18)
			//{
			//    Console.WriteLine("Palun sisesta oma nimi: ");
			//    string kasutajaNimi = "";
			//    kasutajaNimi = Console.ReadLine();
			//    Console.WriteLine($"Kallis {kasutajaNimi}, palun kutsu siia oma ilus emme. ");

			//}
			//else
			//{
			//    Console.WriteLine("Palun kirjuta siia oma Eesnimi");
			//    string eesNimi = "";
			//    eesNimi = Console.ReadLine();
			//    Console.WriteLine("Palun kirjuta siia oma Perekonnanimi");
			//    string perekonnaNimi = "";
			//    perekonnaNimi = Console.ReadLine();
			//    if (eesNimi == "" || perekonnaNimi == "")
			//    {
			//        Console.WriteLine("Sisestama pidi mõlemad nimed jobu!"); 
			//    }
			//    else
			//    {
			//        Console.WriteLine($"Tere lõunat {eesNimi} {perekonnaNimi} ! ");         



			/*näiteülesanne 7 - "Kalkulaator"  -asenda switchcase if-else-if-elseiga*/
			//    Console.WriteLine("Palun sisesta esimene arv");
			//float arv1 = 0.0f;
			//arv1 = float.Parse(Console.ReadLine());
			//Console.WriteLine("Palun sisesta teine arv");
			//float arv2 = 0.0f;
			//arv2 = float.Parse(Console.ReadLine());
			//Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V)");
			//string tehteTüüp = "";
			//tehteTüüp = (Console.ReadLine());

			//double tehteTulemus = 0.0d;

			//if (tehteTüüp != "")
			//{

			//}
			//switch (tehteTüüp)
			//{
			//    default:
			//        Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
			//        break;
			//    case "+":
			//        tehteTulemus = arv1 + arv2;
			//        break;
			//    case "-":
			//        tehteTulemus = arv1 - arv2;
			//        break;
			//    case "/":
			//        tehteTulemus = arv1 / arv2;
			//        break;
			//    case "*":
			//        tehteTulemus = arv1 * arv2;
			//        break;
			//    case "^":
			//        tehteTulemus = Math.Pow(arv1, arv2);
			//        break;
			//    case "V":
			//        tehteTulemus = Math.Pow(arv1, (1 / arv2));
			//        break;


			//}
			//Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tehteTulemus}");
		}
	}
}

