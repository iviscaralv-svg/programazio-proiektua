using System.Net.NetworkInformation;

namespace Proiektua;

// ⦁	Eskari bat sortu
// ⦁	Aurreko eskariak kontsultatu
// ⦁	Irten


public class Program
{
    public static void Main(string[] args)
    {
        // hauek bilatu ditut koloreak emateko terminalean:
        // orduan aldagaiari deitzen diozu string batean eta gero non bukatzeko reset jartzen diozu
        // colors
        string verde = "\u001b[32m";
        string reset = "\u001b[0m";
        string rojo = "\u001b[31m";
        string amarillo = "\u001b[33m";


        // eskaerak gordetuko dituen lista sortu
        List<string> lista = new List<string>();
        bool running = true;

        while (running)
        {
            // lehen menua erakusten dugu
            Console.WriteLine($"{verde}Aukeratu funtzionalitatea:{reset}");
            Console.WriteLine(" 1) Eskari bat sortu");
            Console.WriteLine(" 2) Aurreko eskariak kontsultatu");
            Console.WriteLine(" 3) Irten");
        
            // erabiltzailearen inputa jaso (int.Parse(Console.ReadLine() -> hau ez dut egin erabiltzailearek okerrak errore bezala artuko dituelako);
            string? user = Console.ReadLine();
        
            // erabiltzaileak jarri duena 3 aukera posibleekin egiaztatus
            if (user == "1" || user == "2" || user == "3")
            {
                int userInt = int.Parse(user);

                // lehen aukeraren eskera menua egin
                switch (userInt)
                {
                    case 1:
                        string izena = "";

                        Console.WriteLine($"{amarillo}Izena{reset} - Lehenengo - Bigarren - Postreak - Edariak");
                        Console.WriteLine("Bezeroaren izena: ");
                        string userName = Console.ReadLine()!;
                        izena = userName;

                        // erabiltzailearen aukereak gordetuko dituen aldagaiak
                        string lehenengo = "";
                        string bigarren = "";
                        string postrea = "";
                        string edaria = "";

                        
                        // aukerak erakutsi
                        Console.WriteLine("");
                        Console.WriteLine($"Izena - {amarillo}Lehenengo{reset} - Bigarren - Postreak - Edariak");
                        Console.WriteLine(" 1) Ensalada");
                        Console.WriteLine(" 2) Spaghetti");
                        Console.WriteLine(" 3) Arroz zopa");
                        Console.WriteLine(" 4) Tomate eta mozzarella entsalada");
                        Console.WriteLine(" 5) Kalabaza-krema");
                        Console.WriteLine(" 6) Gazpatxoa");

                        // erabiltzaileari galdetu
                        int userLehenengo = int.Parse(Console.ReadLine()!);

                        // erabiltzailearen aukeraren arabera legenengo aldagia definitu
                        switch (userLehenengo)
                        {
                            case 1:
                                lehenengo = "Ensalada";
                                break;
                            case 2:
                                lehenengo = "Spaghetti";
                                break;
                            case 3:
                                lehenengo = "Arroz zopa";
                                break;
                            case 4:
                                lehenengo = "Tomate eta mozzarella entsalada";
                                break;
                            case 5:
                                lehenengo = "Kalabaza-krema";
                                break;
                            case 6:
                                lehenengo = "Gazpatxoa";
                                break;
                            default:
                                Console.WriteLine($"{rojo}Error: Aukera ez da ulertzen{reset}");
                                break;
                        }

                        Console.WriteLine($"Izena - Lehenengo - {amarillo}Bigarren{reset} - Postreak - Edariak");
                        Console.WriteLine(" 1) Hamburguesa");
                        Console.WriteLine(" 2) Merluza");
                        Console.WriteLine(" 3) Oilaskoa");
                        Console.WriteLine(" 4) Txuleta plantxan");
                        Console.WriteLine(" 5) Bakailao al pil-pil");
                        Console.WriteLine(" 6) Barazki-tarta salda batekin");

                        // erabiltzaileari galdetu
                        int userBigarren = int.Parse(Console.ReadLine()!);

                        // erabiltzailearen aukeraren arabera bigarren aldagia definitu
                        switch (userBigarren)
                        {
                            case 1:
                                bigarren = "Hamburguesa";
                                break;
                            case 2:
                                bigarren = "Merluza";
                                break;
                            case 3:
                                bigarren = "Oilaskoa";
                                break;
                            case 4:
                                bigarren = "Txuleta plantxan";
                                break;
                            case 5:
                                bigarren = "Bakailao al pil-pil";
                                break;
                            case 6:
                                bigarren = "Barazki-tarta salda batekin";
                            break;
                            default:
                                Console.WriteLine($"{rojo}Error: Aukera ez da ulertzen{reset}");
                                break;
                        }

                        Console.WriteLine($"Izena - Lehenengo - Bigarren - {amarillo}Postreak{reset} - Edariak");
                        Console.WriteLine(" 1) Flan");
                        Console.WriteLine(" 2) Gazta");
                        Console.WriteLine(" 3) Vanilla");
                        Console.WriteLine(" 4) Tiramisú");
                        Console.WriteLine(" 5) Banillazko flana");
                        Console.WriteLine(" 6) Fruta-makedonia");

                        // erabiltzaileari galdetu
                        int userHirugarren = int.Parse(Console.ReadLine()!);

                        // erabiltzailearen aukeraren arabera postrea aldagia definitu
                        switch (userHirugarren)
                        {
                            case 1:
                                postrea = "Flan";
                                break;
                            case 2:
                                postrea = "Gazta";
                                break;
                            case 3:
                                postrea = "Vanilla";
                                break;
                            default:
                                Console.WriteLine($"{rojo}Error: Aukera ez da ulertzen{reset}");
                                break;
                        }

                        Console.WriteLine($"Izena - Lehenengo - Bigarren - Postreak - {amarillo}Edariak{reset}");
                        Console.WriteLine(" 1) Ura");
                        Console.WriteLine(" 2) Freskagarria");
                        Console.WriteLine(" 3) Laranja zukua");
                        Console.WriteLine(" 4) Kafea");
                        Console.WriteLine(" 5) Coca-Cola");
                        Console.WriteLine(" 6) Kas Laranja");
                        Console.WriteLine(" 7) Kas Limoia");

                        // erabiltzaileari galdetu
                        int userEdaria = int.Parse(Console.ReadLine()!);

                        // erabiltzailearen aukeraren arabera edaria aldagia definitu
                        switch (userEdaria)
                        {
                            case 1:
                                edaria = "Ura";
                                break;
                            case 2:
                                edaria = "Freskagarria";
                                break;
                            case 3:
                                edaria = "Laranja zukua";
                                break;
                            default:
                                Console.WriteLine($"{rojo}Error: Aukera ez da ulertzen{reset}");
                                break;
                        }

                        // gordetako aldagaien bidez eskaera sortu, funtzioa deituz
                        SortuEskaera(lista, izena, lehenengo, bigarren, postrea, edaria);
                        break;

                    case 2:
                        Console.WriteLine($"{amarillo}Aurreko eskaerak:{reset}");
                        //Console.WriteLine(lista.Last());
                        // egiten dena da listatik 0 hasita i lista.Count (lista zenbatu zenbat elementu dauzkan) baino txikiago denean exekutatuko da.
                        for (int i = 0; i < lista.Count; i++)
                        {
                            // listatik zenbakiak pasatzen joaten da
                            Console.WriteLine($"{i}) {lista[i]}");
                        }

                        Console.WriteLine("Ezabatzeko jarri id zenbakia edo x ez ezabatzeko: ");
                        string? userDelete = Console.ReadLine().ToLower();

                        switch (userDelete)
                        {
                            case "no": 
                                Console.WriteLine("Ez da ezer ezabatuko.");
                                break;
                            case "": 
                                Console.WriteLine("Ez da ezer ezabatuko.");
                                break;
                            case "x":
                                Console.WriteLine("Ez da ezer ezabatuko.");
                                break;
                            default:
                                EzabatuEskera(lista, int.Parse(userDelete));
                                break;
                        }

                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.WriteLine($"{amarillo}Irten...{reset}");
                        running = false;
                        break;
                }
            }
            // ez ba horrela errore mezu bat erakutsi
            else
            {
                Console.WriteLine($"{rojo}Error: Aukera ez da ulertzen{reset}");
            }
        }

    }

    // lehen menuan egindako sortutako listan gordetzeko funtzioa
    public static void SortuEskaera(List<string> lista, string izena, string lehenengo, string bigarren, string postrea, string edaria)
    {
        // Add bidez eskera gehitu -> funtzioari pasatutako aldagaiak erabiliz
        lista.Add($"Izena: {izena} | Lehenengo: {lehenengo} | Bigarren: {bigarren} | Postrea: {postrea} | Edaria: {edaria} | Sortuta: {DateTime.Now}");
    }

    public static void EzabatuEskera(List<string> lista, int index)
    {
        lista.RemoveAt(index);
    }

}