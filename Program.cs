using System.ComponentModel.Design; // enne nimeruumi, viidatakse selles failis/klassis kasutatud pakettidele/moodulitele ja süsteemi muudele osadele
//süsteemi muuks osaks võib olla kas operatsioonisüsteemi võimalused või ka teised projektid. Teised projektid viidatakse tavaliselt solution (.sln) failist.
using System.Net.NetworkInformation;
using System.Threading.Channels;

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
             
          

            all teeoria*/


            /* -= S Ü N T A K S =-  */
            Console.WriteLine("Ommik"); //<-- "1" //Ommik on parameeter sulgude sees
            string vastus = Console.ReadLine(); //<--- "2""
            Console.WriteLine(":)");
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
            Console.WriteLine("Palun sisesta esimene arv");
            float arv1 = 0.0f;
            arv1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisesta teine arv");
            float arv2 = 0.0f;
            arv2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V)");
            string tehteTüüp = "";
            tehteTüüp = (Console.ReadLine());

            double tehteTulemus = 0.0d;

            if (tehteTüüp != "")
            {

            }
            switch (tehteTüüp)
            {
                default:
                    Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
                    break;
                case "+":
                    tehteTulemus = arv1 + arv2;
                    break;
                case "-":
                    tehteTulemus = arv1 - arv2;
                    break;
                case "/":
                    tehteTulemus = arv1 / arv2;
                    break;
                case "*":
                    tehteTulemus = arv1 * arv2;
                    break;
                case "^":
                    tehteTulemus = Math.Pow(arv1, arv2);
                    break;
                case "V":
                    tehteTulemus = Math.Pow(arv1, (1 / arv2));
                    break;


            }
            Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tehteTulemus}");



            
        }
    }
}

















        