using System;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading;
using VenditaVeicoliDllProject;

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        public static string path = @"E:\Triennio\QUARTA_SUP\Informatica\Progetti\VenditaVeicoliSolution\fileStorage/";

        public FormMain()
        {
            InitializeComponent();
            listBoxVeicoli.DataSource = DbActions.bindingListVeicoli;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(DbActions.bindingListVeicoli.Count == 0)
                DbActions.CreateListCars();
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            frmAggiungiVeicolo dialogAggiungi = new frmAggiungiVeicolo(DbActions.bindingListVeicoli);
            dialogAggiungi.ShowDialog();
        }

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            Utils.SerializeToCsv(DbActions.bindingListVeicoli, path + "Veicoli.csv");

            Utils.SerializeToXml(DbActions.bindingListVeicoli, path + "Veicoli.xml");

            Utils.SerializeToJson(DbActions.bindingListVeicoli, path + "Veicoli.json");
        }

        private void stampaToolStripButton_Click(object sender, EventArgs e)
        {
            string webPath = (path + "www/index.html");
            Utils.createHtml(DbActions.bindingListVeicoli, webPath);
            System.Diagnostics.Process.Start(webPath);
        }
    }
}
