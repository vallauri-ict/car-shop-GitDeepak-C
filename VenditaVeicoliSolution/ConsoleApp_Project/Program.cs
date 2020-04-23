using System;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using VenditaVeicoliDllProject;

namespace ConsoleApp_Project
{
    class Program
    {
        public static string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CarShop.accdb";
        //SerializableBindingList<Veicolo> bindingListVeicoli;

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
                        CreateTableCars();
                        break;
                    case '2':
                        string marca = Interaction.InputBox("Inserisci la marca del veicolo"),
                               prezzo = Interaction.InputBox("Inserisci il prezzo del veicolo");
                        AddNewCar(marca, prezzo);
                        break;
                    case '3':
                        ListCars();
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

        private static void AddNewCar(string carName, string carPrice)
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    string query = "INSERT INTO cars(name, price) VALUES(@name, @price)";
                    cmd.CommandText = query;

                    cmd.Parameters.Add("@name", OleDbType.VarChar, 255).Value = carName;
                    cmd.Parameters.Add("@price", OleDbType.Integer).Value = carPrice;
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\n Car added!!");
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }

        private static void CreateTableCars()
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
                        cmd.CommandText = @"CREATE TABLE cars(
                                        id int identity(1, 1) NOT NULL PRIMARY KEY,
                                        name VARCHAR(255) NOT NULL,
                                        price INT
                                      )";
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException exc)
                    {
                        Console.WriteLine("\n" + exc.Message);
                        System.Threading.Thread.Sleep(3000);
                        return;
                    }

                    cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes', 571200)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Bmw', 202100)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi', 543789)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volvo', 987654)";
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\n Cars table created!!");
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("*** CAR SHOP - DB MANAGEMENT ***\n");
            Console.WriteLine(" Menu:");
            Console.WriteLine(" 1 - CREATE TABLE: Cars");
            Console.WriteLine(" 2 - ADD NEW ITEM: Cars");
            Console.WriteLine(" 3 - LIST: Cars");
            Console.WriteLine(" 4 - ...");
            Console.WriteLine(" 5 - ...");
            Console.WriteLine("\n X - FINE LAVORO\n\n");
        }
    }
}
