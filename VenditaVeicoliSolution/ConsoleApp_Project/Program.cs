using System;
using Microsoft.VisualBasic;
using VenditaVeicoliDllProject;

namespace ConsoleApp_Project
{
    class Program
    {
        public static string path = @"E:\Triennio\QUARTA_SUP\Informatica\Progetti\VenditaVeicoliSolution\fileStorage/";

        static void Main(string[] args)
        {
            char scelta;
            do
            {
                menu();
                Console.Write(" DIGITA LA TUA SCELTA: ");
                scelta = Console.ReadKey().KeyChar;
                switch (scelta)
                {
                    case '1':
                        DbActions.CreateTableVeicoli();
                        DbActions.CreateListCars();
                        break;
                    case '2':
                        #region inizializzazione campi
                        string targa = Interaction.InputBox("Inserisci la targa del veicolo"),
                               marca = Interaction.InputBox("Inserisci la marca del veicolo"),
                               modello = Interaction.InputBox("Inserisci il modello del veicolo"),
                               colore = Interaction.InputBox("Inserisci il colore del veicolo"),
                               cilindrata = Interaction.InputBox("Inserisci la cilindrata del veicolo"),
                               potenzaKw = Interaction.InputBox("Inserisci la potenza(Kw) del veicolo"),
                               dataImmatricolazione = DateTime.Now.Date.ToShortDateString(),
                               isUsato = "",
                               isKm0 = "",
                               kmPercorsi = Interaction.InputBox("Inserisci i km percorsi dal veicolo"),
                               str = Interaction.InputBox("Inserisci il numero di airbag o la marca della sella del veicolo");
                        if(Convert.ToInt32(kmPercorsi) > 0) {
                            isUsato = "True";
                            isKm0 = "false";
                        }
                        else
                        {
                            isUsato = "False";
                            isKm0 = "True";
                        }
                        #endregion
                        string parameters = targa + "|" + marca + "|" + modello + "|" + colore + "|" + cilindrata + "|" + potenzaKw + "|" + dataImmatricolazione + "|" + isUsato + "|" + isKm0 + "|" + kmPercorsi + "|" + str;

                        DbActions.AddNewItem(parameters);
                        Console.WriteLine("\n Item added to Auto!!");
                        System.Threading.Thread.Sleep(2000);

                        break;
                    case '3':
                        targa = Interaction.InputBox("Inserisci la targa dell'elemento da modificare");
                        marca = Interaction.InputBox("Inserisci la marca del veicolo da modificare");
                        str = Interaction.InputBox("Inserisci il campo che vuoi modificare");
                        string newVal = Interaction.InputBox("Inserisci il nuovo valore del campo");

                        DbActions.modifyItem(targa, marca, str, newVal);

                        break;
                    case '4':
                        targa = Interaction.InputBox("Inserisci la targa dell'elemento da eliminare");

                        DbActions.deleteItem(targa);

                        break;
                    case '5':
                        DbActions.bindingListVeicoli.Clear();
                        DbActions.CreateListCars();
                        DbActions.showList();
                        break;
                    case '6':
                        if (DbActions.bindingListVeicoli.Count == 0)
                            DbActions.CreateListCars();
                        Console.WriteLine("\n There are " + DbActions.bindingListVeicoli.Count + " vehicles");
                        Console.ReadKey();
                        break;
                    case '7':
                        DbActions.dropTable();
                        break;
                    case '8':
                        if (DbActions.bindingListVeicoli.Count == 0)
                            DbActions.CreateListCars();
                        string webPath = (@"E:\Triennio\QUARTA_SUP\Informatica\Progetti\VenditaVeicoliSolution\fileStorage/www/index.html");
                        Utils.createHtml(DbActions.bindingListVeicoli, webPath);
                        System.Diagnostics.Process.Start(webPath);
                        break;
                    default:
                        break;
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("*** CAR SHOP - DB MANAGEMENT ***\n");
            Console.WriteLine(" Menu:");
            Console.WriteLine(" 1 - CREATE TABLE");
            Console.WriteLine(" 2 - ADD NEW ITEM");
            Console.WriteLine(" 3 - MODIFY ITEM");
            Console.WriteLine(" 4 - DELETE ITEM");
            Console.WriteLine(" 5 - SHOW LIST");
            Console.WriteLine(" 6 - COUNT ELEMENTS");
            Console.WriteLine(" 7 - DROP TABLE");
            Console.WriteLine(" 8 - EXPORT DB IN A .HTML FILE");
            Console.WriteLine("\n X - FINE LAVORO\n\n");
        }
    }
}
