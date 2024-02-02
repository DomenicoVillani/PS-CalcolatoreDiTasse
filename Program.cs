using System.Text.RegularExpressions;

namespace ProgettoSettimanaleC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool verificaCiclo = true;
            int giornoNasc = 0;
            int annoNasc = 0;
            int meseNasc = 0;
            string codiceFiscale = "";
            string sesso = "";
            double reddito = 0;

            Console.WriteLine("\r\n _______   ________  __    __  __     __  ________  __    __  __    __  ________   ______  \r\n|       \\ |        \\|  \\  |  \\|  \\   |  \\|        \\|  \\  |  \\|  \\  |  \\|        \\ /      \\ \r\n| $$$$$$$\\| $$$$$$$$| $$\\ | $$| $$   | $$| $$$$$$$$| $$\\ | $$| $$  | $$ \\$$$$$$$$|  $$$$$$\\\r\n| $$__/ $$| $$__    | $$$\\| $$| $$   | $$| $$__    | $$$\\| $$| $$  | $$   | $$   | $$  | $$\r\n| $$    $$| $$  \\   | $$$$\\ $$ \\$$\\ /  $$| $$  \\   | $$$$\\ $$| $$  | $$   | $$   | $$  | $$\r\n| $$$$$$$\\| $$$$$   | $$\\$$ $$  \\$$\\  $$ | $$$$$   | $$\\$$ $$| $$  | $$   | $$   | $$  | $$\r\n| $$__/ $$| $$_____ | $$ \\$$$$   \\$$ $$  | $$_____ | $$ \\$$$$| $$__/ $$   | $$   | $$__/ $$\r\n| $$    $$| $$     \\| $$  \\$$$    \\$$$   | $$     \\| $$  \\$$$ \\$$    $$   | $$    \\$$    $$\r\n \\$$$$$$$  \\$$$$$$$$ \\$$   \\$$     \\$     \\$$$$$$$$ \\$$   \\$$  \\$$$$$$     \\$$     \\$$$$$$ \r\n                                                                                           \r\n                                                                                           \r\n                                                                                           \r\n");
            Console.WriteLine("\r\n _____       _           _       _                       _ _   _                     \r\n/  __ \\     | |         | |     | |                     | (_) | |                    \r\n| /  \\/ __ _| | ___ ___ | | __ _| |_ ___  _ __ ___    __| |_  | |_ __ _ ___ ___  ___ \r\n| |    / _` | |/ __/ _ \\| |/ _` | __/ _ \\| '__/ _ \\  / _` | | | __/ _` / __/ __|/ _ \\\r\n| \\__/\\ (_| | | (_| (_) | | (_| | || (_) | | |  __/ | (_| | | | || (_| \\__ \\__ \\  __/\r\n \\____/\\__,_|_|\\___\\___/|_|\\__,_|\\__\\___/|_|  \\___|  \\__,_|_|  \\__\\__,_|___/___/\\___|\r\n                                                                                     \r\n                                                                                     \r\n");
            Console.WriteLine("Premi un qualsiasi tasto nella tastiera per andare avanti ...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Inserisci il tuo nome");
            string nome =Console.ReadLine();
            nome =nome.ToUpper();
            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine();
            cognome =cognome.ToUpper();
            while (verificaCiclo)
            {
                Console.WriteLine("Inserisci il giorno in cui sei nat* (GG)");
                giornoNasc = int.Parse(Console.ReadLine());
                if(giornoNasc <= 0)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Non esiste questo giorno!");
                }
                else
                {
                    if(giornoNasc > 31)
                    {
                        Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                        Console.WriteLine("Non esiste questo giorno!");
                    }
                    else
                    {
                        verificaCiclo=false;
                    }
                }
            }
            verificaCiclo = true;
            while (verificaCiclo)
            {
                Console.WriteLine("Inserisci il mese in cui sei nat* (MM)");
                meseNasc = int.Parse(Console.ReadLine());
                if (meseNasc <=0)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Non esiste questo mese");
                }
                else if (meseNasc >12)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Non esiste questo mese");
                }
                else if(meseNasc == 02 && giornoNasc>30)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Febbraio non ha 30 o piu' giorni!! ");
                }
                else if(meseNasc == 04 && giornoNasc > 30)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Marzo non ha 31 o piu' giorni!! ");
                }
                else if (meseNasc == 06 && giornoNasc > 30)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Giugno non ha 31 o piu' giorni!! ");
                }
                else if (meseNasc == 09 && giornoNasc > 30)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Settembre non ha 31 o piu' giorni!! ");
                }
                else if (meseNasc == 11 && giornoNasc > 30)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Novembre non ha 31 o piu' giorni!! ");
                }
                else
                {
                    verificaCiclo = false;
                }
            }
            verificaCiclo = true;
            while(verificaCiclo)
            {
                Console.WriteLine("Inserisci l'anno in cui sei nat* (AAAA)");
                annoNasc = int.Parse(Console.ReadLine());
                if(annoNasc > 2024)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Siamo nel 2024 e' impossibile che sei nat* in quell'anno!");
                }
                else
                {
                    verificaCiclo = false;
                }
            }
            verificaCiclo = true;
            while (verificaCiclo)
            {
                Console.WriteLine("Inserisci il codice fiscale (16 caratteri/cifre)");
                codiceFiscale = Console.ReadLine();
                if(codiceFiscale.Length == 16)
                {
                    codiceFiscale = codiceFiscale.ToUpper();
                    verificaCiclo = false;
                }
                else
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Errore nel recupero del codice fiscale");
                }
            }
            verificaCiclo = true;
            while (verificaCiclo)
            {
                Console.WriteLine("Inserisci il tuo genere (M/F/*)");
                sesso = Console.ReadLine();
                sesso = sesso.ToUpper();
                if(sesso.Equals("M") || sesso.Equals("F") || sesso.Equals("*"))
                {
                    verificaCiclo = false;
                }
                else
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Genere non trovato!");
                }
            }
            Console.WriteLine("Inserisci il tuo comune di residenza");
            string comune = Console.ReadLine();
            comune = comune.ToUpper();
            verificaCiclo = true;
            while (verificaCiclo)
            {
                Console.WriteLine("Inserisci il tuo reddito annuo");
                reddito = double.Parse(Console.ReadLine());
                if(reddito <= 0)
                {
                    Console.WriteLine("\r\n  _____ ____  ____   ___  ____  _____ \r\n | ____|  _ \\|  _ \\ / _ \\|  _ \\| ____|\r\n |  _| | |_) | |_) | | | | |_) |  _|  \r\n | |___|  _ <|  _ <| |_| |  _ <| |___ \r\n |_____|_| \\_\\_| \\_\\\\___/|_| \\_\\_____|\r\n                                      \r\n");
                    Console.WriteLine("Reddito non valido");
                }
                else
                {
                    verificaCiclo = false;
                }
            }
            Contribuente contribuente1 = new Contribuente(nome,cognome,giornoNasc,meseNasc,annoNasc,codiceFiscale,sesso,comune,reddito);
            switch (reddito)
            {
                case double n when (n > 0 && n <= 15000):
                    Console.Clear();
                    contribuente1.CalcolatoreTasse(0, 23, 0);
                    Console.WriteLine("\r\n    _____   ____________     ____  ___    _   ______________\r\n   /  _/ | / / ____/ __ \\   / __ \\/   |  / | / / ____/ ____/\r\n   / //  |/ / /_  / / / /  / /_/ / /| | /  |/ / / __/ __/   \r\n _/ // /|  / __/ / /_/ /  / _, _/ ___ |/ /|  / /_/ / /___   \r\n/___/_/ |_/_/    \\____/  /_/ |_/_/  |_/_/ |_/\\____/_____/   \r\n                                                            \r\n");
                    Console.WriteLine("Range 0€ - 15000€ ");
                    Console.WriteLine("Parte fissa da pagare: 0€, Aliquota: 23%");
                    Console.WriteLine("*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€");
                    break;

                case double n when (n > 15000 && n <= 28000):
                    Console.Clear();
                    contribuente1.CalcolatoreTasse(15001, 27, 3450);
                    Console.WriteLine("\r\n    _____   ____________     ____  ___    _   ______________\r\n   /  _/ | / / ____/ __ \\   / __ \\/   |  / | / / ____/ ____/\r\n   / //  |/ / /_  / / / /  / /_/ / /| | /  |/ / / __/ __/   \r\n _/ // /|  / __/ / /_/ /  / _, _/ ___ |/ /|  / /_/ / /___   \r\n/___/_/ |_/_/    \\____/  /_/ |_/_/  |_/_/ |_/\\____/_____/   \r\n                                                            \r\n");
                    Console.WriteLine("Range 15001€ - 28000€");
                    Console.WriteLine("Parte fissa da pagare: 3450€, Aliquota: 27% sull'eccedente dei 15000€");
                    Console.WriteLine("*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€");
                    break;

                case double n when (n > 28000 && n <= 55000):
                    Console.Clear();
                    contribuente1.CalcolatoreTasse(28001, 38, 6960);
                    Console.WriteLine("\r\n    _____   ____________     ____  ___    _   ______________\r\n   /  _/ | / / ____/ __ \\   / __ \\/   |  / | / / ____/ ____/\r\n   / //  |/ / /_  / / / /  / /_/ / /| | /  |/ / / __/ __/   \r\n _/ // /|  / __/ / /_/ /  / _, _/ ___ |/ /|  / /_/ / /___   \r\n/___/_/ |_/_/    \\____/  /_/ |_/_/  |_/_/ |_/\\____/_____/   \r\n                                                            \r\n");
                    Console.WriteLine("Range 28001€ - 55000€");
                    Console.WriteLine("Parte fissa da pagare: 6960€, Aliquota: 38% sull'eccedente dei 28000€");
                    Console.WriteLine("*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€");
                    break;

                case double n when (n > 55000 && n <= 75000):
                    Console.Clear();
                    contribuente1.CalcolatoreTasse(55001, 41, 17220);
                    Console.WriteLine("\r\n    _____   ____________     ____  ___    _   ______________\r\n   /  _/ | / / ____/ __ \\   / __ \\/   |  / | / / ____/ ____/\r\n   / //  |/ / /_  / / / /  / /_/ / /| | /  |/ / / __/ __/   \r\n _/ // /|  / __/ / /_/ /  / _, _/ ___ |/ /|  / /_/ / /___   \r\n/___/_/ |_/_/    \\____/  /_/ |_/_/  |_/_/ |_/\\____/_____/   \r\n                                                            \r\n");
                    Console.WriteLine("Range 55001€ - 75000€");
                    Console.WriteLine("Parte fissa da pagare: 17220€, Aliquota: 41% sull'eccedente dei 55000€");
                    Console.WriteLine("*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€");
                    break;

                case double n when (n > 75000):
                    Console.Clear();
                    contribuente1.CalcolatoreTasse(75001, 43, 25420);
                    Console.WriteLine("\r\n    _____   ____________     ____  ___    _   ______________\r\n   /  _/ | / / ____/ __ \\   / __ \\/   |  / | / / ____/ ____/\r\n   / //  |/ / /_  / / / /  / /_/ / /| | /  |/ / / __/ __/   \r\n _/ // /|  / __/ / /_/ /  / _, _/ ___ |/ /|  / /_/ / /___   \r\n/___/_/ |_/_/    \\____/  /_/ |_/_/  |_/_/ |_/\\____/_____/   \r\n                                                            \r\n");
                    Console.WriteLine("Range 75001€ o superiore");
                    Console.WriteLine("Parte fissa da pagare: 25420€, Aliquota: 43% sull'eccedente dei 75000€");
                    Console.WriteLine("*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€");
                    break;
            }
        }


        class Contribuente
        {
            string _nome;
            string _cognome;
            int _giornoDataNascita;
            int _meseDataNascita;
            int _annoDataNascita;
            string _codiceFiscale;
            string _sesso;
            string _comuneResidenza;
            double _redditoAnnuale;


            public string Nome
            {
                get {return _nome; }
                set {_nome = value; }
            }
            public string Cognome
            {
                get { return _cognome; }
                set { _cognome = value; }
            }
            public int GiornoDataNascita
            {
                get { return _giornoDataNascita; }
                set { _giornoDataNascita = value; }
            }
            public int MeseDataNascita
            {
                get { return _meseDataNascita; }
                set { _meseDataNascita = value; }
            }
            public int AnnoDataNascita
            {
                get { return _annoDataNascita; }
                set { _annoDataNascita = value; }
            }
            public string CodiceFiscale
            {
                get { return _codiceFiscale; }
                set { _codiceFiscale = value; }
            }
            public string Sesso
            {
                get { return _sesso; }
                set { _sesso = value; }
            }
            public string ComuneResidenza
            {
                get { return _comuneResidenza; }
                set { _comuneResidenza = value; }
            }
            public double RedditoAnnuale
            {
                get { return _redditoAnnuale; }
                set { _redditoAnnuale = value; }
            }

            public Contribuente(string nome, string cognome, int giornoDataNascita, int meseDataNascita, int annoDataNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale)
            {
                Nome = nome;
                Cognome = cognome;
                GiornoDataNascita = giornoDataNascita;
                MeseDataNascita = meseDataNascita;
                AnnoDataNascita = annoDataNascita;
                CodiceFiscale = codiceFiscale;
                Sesso = sesso;
                ComuneResidenza = comuneResidenza;
                RedditoAnnuale = redditoAnnuale;
            }
            public void MostraDati()
            {
                Console.WriteLine("*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€");
                Console.WriteLine("\r\n                                                                   \r\n,--.      ,--.                 ,--.       ,--.          ,--.  ,--. \r\n`--'    ,-'  '-.,--.,--. ,---. `--'     ,-|  | ,--,--.,-'  '-.`--' \r\n,--.    '-.  .-'|  ||  || .-. |,--.    ' .-. |' ,-.  |'-.  .-',--. \r\n|  |      |  |  '  ''  '' '-' '|  |    \\ `-' |\\ '-'  |  |  |  |  | \r\n`--'      `--'   `----'  `---' `--'     `---'  `--`--'  `--'  `--' \r\n                                                                   \r\n");
                Console.WriteLine("Contribuente: "+Nome+ " " +Cognome+ ",");
                Console.WriteLine("Nat* il " +GiornoDataNascita+ "/" +MeseDataNascita+ "/" +AnnoDataNascita+ " (" +Sesso+ "),");
                Console.WriteLine("Residente in "+ComuneResidenza+ ",");
                Console.WriteLine("Codice fiscale: "+CodiceFiscale+ ",");
                Console.WriteLine("Reddito dichiarato: "+RedditoAnnuale+ "€,");
            }
            public void CalcolatoreTasse(int range, int aliquota, int tassaFissa)
            {
                double eccedenza = RedditoAnnuale - range;
                double tasse = eccedenza * aliquota / 100;
                double tasseTotali = tasse + tassaFissa;
                MostraDati();
                Console.WriteLine("Imposte da versare: "+tasseTotali+ "€");
                Console.WriteLine("*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€*€");
            }
        }
    }
}
