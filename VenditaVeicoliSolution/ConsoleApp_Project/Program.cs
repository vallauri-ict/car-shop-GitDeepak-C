using System;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using VenditaVeicoliDllProject;
using System.Runtime.InteropServices;
using System.Data;
using System.IO;

namespace ConsoleApp_Project
{
    class Program
    {
        public static string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        public static string path = @"E:\Triennio\QUARTA_SUP\Informatica\Progetti\VenditaVeicoliSolution\fileStorage/";
        static Random rnd = new Random();

        static SerializableBindingList<Veicolo> bindingListVeicoli = new SerializableBindingList<Veicolo>();

        static void Main(string[] args)
        {
            connStr += path + "CarShop.accdb";

            char scelta;
            do
            {
                menu();
                Console.Write(" DIGITA LA TUA SCELTA: ");
                scelta = Console.ReadKey().KeyChar;
                switch (scelta)
                {
                    case '1':
                        CreateTableVeicoli();
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

                        AddNewItem(parameters);
                        Console.WriteLine("\n Item added to Auto!!");
                        System.Threading.Thread.Sleep(2000);

                        break;
                    case '3':
                        string id = Interaction.InputBox("Inserisci l'id del elemento da modificare");
                        marca = Interaction.InputBox("Inserisci la marca del veicolo da modificare");
                        str = Interaction.InputBox("Inserisci il campo che vuoi modificare");
                        string newVal = Interaction.InputBox("Inserisci il nuovo valore del campo");

                        modifyItem(id, marca, str, newVal);

                        break;
                    case '4':
                        id = Interaction.InputBox("Inserisci l'id del elemento da eliminare");
                        
                        deleteItem(id);

                        break;
                    case '5':
                        bindingListVeicoli.Clear();
                        ListCars();
                        showList();
                        break;
                    case '6':
                        if (bindingListVeicoli.Count == 0)
                            ListCars();
                        Console.WriteLine("\n There are " + bindingListVeicoli.Count + " vehicles");
                        Console.ReadKey();
                        break;
                    case '7':
                        dropTable();
                        break;
                    case '8':
                        if (bindingListVeicoli.Count == 0)
                            ListCars();
                        string webPath = (@"E:\Triennio\QUARTA_SUP\Informatica\Progetti\VenditaVeicoliSolution\fileStorage/www/index.html");
                        Utils.createHtml(bindingListVeicoli, webPath);
                        System.Diagnostics.Process.Start(webPath);
                        break;
                    default:
                        break;
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void dropTable()
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    try
                    {
                        cmd.CommandText = "DROP TABLE Veicoli";
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("\n Veichles table dropped!!");
                        System.Threading.Thread.Sleep(2500);
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n " + exc.Message);
                        System.Threading.Thread.Sleep(4000);
                        return;
                    }
                }
            }
        }

        private static void deleteItem(string id)
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    try
                    {
                        cmd.CommandText = "DELETE FROM Veicoli WHERE id = " + id + "";

                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n " + exc.Message);
                        System.Threading.Thread.Sleep(5000);
                        return;
                    }

                    Console.WriteLine("\n Item deleted!!");
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }

        private static void modifyItem(string id, string marca, string str, string newVal)
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    try
                    {
                        string query = "UPDATE Veicoli " +
                                   "SET " + str + " = @newVal WHERE id = " + id + " and marca = '" + marca + "'";

                        cmd.Parameters.AddWithValue("@newVal", newVal);

                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n " + exc.Message);
                        System.Threading.Thread.Sleep(5000);
                        return;
                    }

                    Console.WriteLine("\n Item modified!!");
                    System.Threading.Thread.Sleep(1500);
                }
            }
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

                    try
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Veicoli", con);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow item in table.Rows)
                        {
                            if (int.TryParse(item.ItemArray[10].ToString(), out _))
                            {
                                Auto a = new Auto(item.ItemArray[1].ToString(), item.ItemArray[2].ToString(), item.ItemArray[3].ToString(), Convert.ToInt32(item.ItemArray[4]), Convert.ToDouble(item.ItemArray[5]),
                                                 Convert.ToDateTime(item.ItemArray[6]), Convert.ToBoolean(item.ItemArray[7]), Convert.ToBoolean(item.ItemArray[8]), Convert.ToInt32(item.ItemArray[9]),
                                                 Convert.ToInt32(item.ItemArray[10]));
                                bindingListVeicoli.Add(a);
                            }
                            else
                            {
                                Moto m = new Moto(item.ItemArray[1].ToString(), item.ItemArray[2].ToString(), item.ItemArray[3].ToString(), Convert.ToInt32(item.ItemArray[4]), Convert.ToDouble(item.ItemArray[5]),
                                                 Convert.ToDateTime(item.ItemArray[6]), Convert.ToBoolean(item.ItemArray[7]), Convert.ToBoolean(item.ItemArray[8]), Convert.ToInt32(item.ItemArray[9]),
                                                 item.ItemArray[10].ToString());
                                bindingListVeicoli.Add(m);
                            }
                        }
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n " + exc.Message);
                        System.Threading.Thread.Sleep(4000);
                        return;
                    }
                }
            }
        }

        private static void showList()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < bindingListVeicoli.Count; i++)
            {
                Console.WriteLine(" *" + bindingListVeicoli[i].Marca + " | " + bindingListVeicoli[i].Modello + " | " + bindingListVeicoli[i].Colore + "*");
            }
            Console.ReadKey();
        }

        private static void AddNewItem(string dati)
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    string query = "INSERT INTO Veicoli(marca, modello, colore, cilindrata, potenzaKw, dataImmatricolazione, isUsato, isKm0, kmPercorsi, cmpSpec) " +
                                   "VALUES(@marca, @modello, @colore, @cilindrata, @potenzaKw, @dataImmatricolazione, @isUsato, @isKm0, @kmPercorsi, @cmpSpec)";
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
                    cmd.Parameters.Add("@cmpSpec", OleDbType.VarChar, 255).Value = vet[9];
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void CreateTableVeicoli()
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    string[] datiProva = new string[20];
                    caricaDatiProva(datiProva);

                    try
                    {

                        cmd.CommandText = @"CREATE TABLE Veicoli(
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
                                        cmpSpec VARCHAR(16)
                                      )";
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n " + exc.Message);
                        System.Threading.Thread.Sleep(2000);
                        return;
                    }

                    for (int i = 0; datiProva[i] != null; i++)
                    {
                        AddNewItem(datiProva[i]);
                    }

                    Console.WriteLine("\n Vehicles table created!!");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private static void caricaDatiProva(string[] datiProva)
        {
            StreamReader sr = new StreamReader(path + "datiProva.txt");
            string s = "";
            int len = -1;

            while(sr.Peek() != -1)
            {
                len++;
                s = sr.ReadLine();
                datiProva[len] = ""+s+"";
            }
            sr.Close();
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
