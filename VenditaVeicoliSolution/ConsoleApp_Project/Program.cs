using System;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using VenditaVeicoliDllProject;

namespace ConsoleApp_Project
{
    class Program
    {
        public static string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CarShop.accdb";

        static Random rnd = new Random();

        #region datiProva
        public static string[] autoProva = new string[] 
                                           { "BMW|M4|Giallo|3000|370|12/02/2002|True|False|70000|7",
                                             "Audi|A1|Blu|3000|120|12/02/2012|True|False|70000|8",
                                             "Ford|Focus|Grigio Metallico|1500|70|12/02/2003|True|False|70000|5",
                                             "Opel|Corsa|Bianca|1200|75|12/02/2002|True|False|120000|3",
                                             "Hyundai|Tucson|Nera|1800|110|12/02/2016|True|False|80000|4",
                                             "Volvo|XC90|Azzura|2000|150|12/02/2019|False|True|0|10" };
        public static string[] motoProva = new string[]
                                           { "Harley Davinson|Iron 883|Grigio Scuro|800|20|12/02/2020|False|True|0|Harley Dainson",
                                             "BMW|F 900 R|Rosso|900|25|12/08/2019|True|False|1000|Bmw",
                                             "Kawasaki|Ninja 250 R|Verde|250|22|12/02/2003|True|False|70000|Kawasaki",
                                             "Yamaha|YZF R125|Blu|125|11|12/02/2018|True|False|120|Yamaha",
                                             "Aprilia|RS 125|Bianca|125|12|12/02/2017|True|False|8000|Aprilia",
                                             "Honda|CBR|Arancione|125|11|12/02/2019|False|True|0|Honda" };
        #endregion

        SerializableBindingList<Veicolo> bindingListVeicoli = new SerializableBindingList<Veicolo>();

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
                        CreateTableAuto();
                        CreateTableMoto();
                        break;
                    case '2':
                        #region inizializzazione campi
                        string marca = Interaction.InputBox("Inserisci la marca del veicolo"),
                               modello = Interaction.InputBox("Inserisci il modello del veicolo"),
                               colore = Interaction.InputBox("Inserisci il colore del veicolo"),
                               cilindrata = Interaction.InputBox("Inserisci la cilindrata del veicolo"),
                               potenzaKw = Interaction.InputBox("Inserisci la potenza(Kw) del veicolo"),
                               dataImmatricolazione = DateTime.Now.Date.ToShortDateString(),
                               isUsato = "",
                               isKm0 = "",
                               kmPercorsi = Interaction.InputBox("Inserisci i km percorsi dal veicolo"),
                               str = Interaction.InputBox("Inserisci il numero di airbag o la marca della sella del veicolo");
                        int n = n = rnd.Next(0, 2);
                        if(n == 0) {
                            isUsato = "False";
                            isKm0 = "True";
                        }
                        else
                        {
                            isUsato = "True";
                            isKm0 = "False";
                        }
                        #endregion
                        string parameters = marca + "|" + modello + "|" + colore + "|" + cilindrata + "|" + potenzaKw + "|" + dataImmatricolazione + "|" + isUsato + "|" + isKm0 + "|" + kmPercorsi + "|" + str;
                        if (int.TryParse(str, out _))
                        {
                            AddNewItem(parameters, "numAirbag", "Auto");
                            Console.WriteLine("\n Item added to Auto!!");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            AddNewItem(parameters, "marcaSella", "Moto");
                            Console.WriteLine("\n Item added to Moto!!");
                            System.Threading.Thread.Sleep(2000);
                        }
                        break;
                    case '3':
                        //modifyItem();                        
                        ListCars();
                        break;
                    case '4':
                        //deleteItem();
                        ListCars();
                        break;
                    case '5':
                        ListCars();
                        break;
                    case '6':
                        //exportJson();
                        ListCars();
                        break;
                    case '7':
                        //exportXml();
                        ListCars();
                        break;
                    case '8':
                        string webPath = (@"www\index.html");
                        //Utils.createHtml(bindingListVeicoli, webPath);
                        System.Diagnostics.Process.Start(webPath);
                        break;
                    default:
                        break;
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void ListCars()
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    Console.WriteLine("\n List created!!");
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }

        private static void showList()
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    Console.WriteLine("\n List created!!");
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }

        private static void AddNewItem(string dati, string str, string dbName)
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    string query = "INSERT INTO " + dbName + "(marca, modello, colore, cilindrata, potenzaKw, dataImmatricolazione, isUsato, isKm0, kmPercorsi," + str + ") " +
                                   "VALUES(@marca, @modello, @colore, @cilindrata, @potenzaKw, @dataImmatricolazione, @isUsato, @isKm0, @kmPercorsi, @" + str + ")";
                    cmd.CommandText = query;

                    string[] vet = dati.Split('|');
                    cmd.Parameters.Add("@marca", OleDbType.VarChar, 255).Value = vet[0];
                    cmd.Parameters.Add("@modello", OleDbType.VarChar, 255).Value = vet[1];
                    cmd.Parameters.Add("@colore", OleDbType.VarChar, 16).Value = vet[2];
                    cmd.Parameters.Add("@cilindrata", OleDbType.Integer).Value = vet[3];
                    cmd.Parameters.Add("@potenzaKw", OleDbType.Integer).Value = vet[4];
                    cmd.Parameters.Add("@dataImmatricolazione", OleDbType.Date).Value = vet[5];
                    cmd.Parameters.Add("@isUsato", OleDbType.Boolean).Value = vet[6];
                    cmd.Parameters.Add("@isKm0", OleDbType.Boolean).Value = vet[7];
                    cmd.Parameters.Add("@kmPercorsi", OleDbType.Integer).Value = vet[8];
                    cmd.Parameters.Add("@" + str + "", OleDbType.VarChar, 255).Value = vet[9];
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void CreateTableAuto()
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    /*cmd.CommandText = "DROP TABLE IF EXITS cars";
                    cmd.ExecuteNonQuery();*/

                    try
                    {
                        cmd.CommandText = @"CREATE TABLE Auto(
                                        id int identity(1, 1) UNIQUE NOT NULL PRIMARY KEY,
                                        marca VARCHAR(255) NOT NULL,
                                        modello VARCHAR(255) NOT NULL,
                                        colore VARCHAR(16) NOT NULL,
                                        cilindrata INT NOT NULL,
                                        potenzaKw INT NOT NULL,
                                        dataImmatricolazione DATETIME,
                                        isUsato BIT,
                                        isKm0 BIT,
                                        kmPercorsi INT NOT NULL,
                                        numAirbag INT
                                      )";
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n" + exc.Message);
                        System.Threading.Thread.Sleep(3000);
                        return;
                    }

                    for (int i = 0; i < autoProva.Length; i++)
                    {
                        AddNewItem(autoProva[i], "numAirbag", "Auto");
                    }

                    Console.WriteLine("\n\n Cars table created!!");
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private static void CreateTableMoto()
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    /*cmd.CommandText = "DROP TABLE IF EXITS cars";
                    cmd.ExecuteNonQuery();*/

                    try
                    {
                        cmd.CommandText = @"CREATE TABLE Moto(
                                        id int identity(1, 1) UNIQUE NOT NULL PRIMARY KEY,
                                        marca VARCHAR(255) NOT NULL,
                                        modello VARCHAR(255) NOT NULL,
                                        colore VARCHAR(16) NOT NULL,
                                        cilindrata INT NOT NULL,
                                        potenzaKw INT NOT NULL,
                                        dataImmatricolazione DATETIME,
                                        isUsato BIT,
                                        isKm0 BIT,
                                        kmPercorsi INT NOT NULL,
                                        marcaSella VARCHAR(255)
                                      )";
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n" + exc.Message);
                        System.Threading.Thread.Sleep(3000);
                        return;
                    }

                    for (int i = 0; i < motoProva.Length; i++)
                    {
                        AddNewItem(motoProva[i], "marcaSella", "Moto");
                    }

                    Console.WriteLine(" Moto table created!!");
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("*** CAR SHOP - DB MANAGEMENT ***\n");
            Console.WriteLine(" Menu:");
            Console.WriteLine(" 1 - CREATE TABLE: Veicoli");
            Console.WriteLine(" 2 - ADD NEW ITEM");
            Console.WriteLine(" 3 - MODIFY ITEM");
            Console.WriteLine(" 4 - DELETE ITEM");
            Console.WriteLine(" 5 - SHOW LIST: Veicoli");
            Console.WriteLine(" 6 - EXPORT DB IN A .JSON FILE");
            Console.WriteLine(" 7 - EXPORT DB IN A .XML FILE");
            Console.WriteLine(" 8 - EXPORT DB IN A .HTML FILE");
            Console.WriteLine("\n X - FINE LAVORO\n\n");
        }
    }
}
