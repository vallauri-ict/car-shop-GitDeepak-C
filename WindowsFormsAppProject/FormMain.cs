using System;
using System.Windows.Forms;
using VenditaVeicoliDllProject;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading;

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        SerializableBindingList<Veicolo> bindingListVeicoli;

        public FormMain()
        {
            InitializeComponent();
            bindingListVeicoli = new SerializableBindingList<Veicolo>();
            listBoxVeicoli.DataSource = bindingListVeicoli;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CaricaDatiDiTest();
        }

        private void CaricaDatiDiTest()
        {
            Moto m = new Moto();
            bindingListVeicoli.Add(m);
            m = new Moto("Aprilia", "125", "Rosso", 600, 70, DateTime.Now, false, false, 0, "Harley Davison");
            bindingListVeicoli.Add(m);

            Auto a = new Auto();
            a = new Auto("Audi", "A1", "Blu", 1400, 75, DateTime.Now, false, false, 0, 7);
            bindingListVeicoli.Add(a);
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            frmAggiungiVeicolo dialogAggiungi = new frmAggiungiVeicolo(bindingListVeicoli);
            dialogAggiungi.ShowDialog();
        }

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"Veicoli.json");
            string jsonString = sr.ReadToEnd();
            var items = JsonConvert.DeserializeObject<object>(jsonString);
            SerializableBindingList<object> lst = JsonConvert.DeserializeObject<SerializableBindingList<object>>(jsonString);
            SerializableBindingList<Veicolo> lsti = Utils.deserializeObject(lst);
            MessageBox.Show(items.ToString());
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            Utils.SerializeToCsv(bindingListVeicoli, @".\Veicoli.csv");

            Utils.SerializeToXml(bindingListVeicoli, @".\Veicoli.xml");

            Utils.SerializeToJson(bindingListVeicoli, @".\Veicoli.json");
        }

        private void stampaToolStripButton_Click(object sender, EventArgs e)
        {
            string webPath = (@"www\index.html");
            Utils.createHtml(bindingListVeicoli, webPath);
            System.Diagnostics.Process.Start(webPath);
        }
    }
}
