using System;
using System.Windows.Forms;
using VenditaVeicoliDllProject;
using Microsoft.VisualBasic;

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        public static string path = @"E:\Triennio\QUARTA_SUP\Informatica\Progetti\VenditaVeicoliSolution\fileStorage/";
        public int tick;

        public FormMain()
        {
            InitializeComponent();
            dgvVeicoli.DataSource = DbActions.bindingListVeicoli;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(DbActions.bindingListVeicoli.Count == 0)
                DbActions.CreateListCars();
            loadVehicles();
        }

        private void loadVehicles()
        {
            foreach (Veicolo v in DbActions.bindingListVeicoli)
            {
                PictureBox pcb = new PictureBox();
                //pcb.Size = Size(50, 50);
            }
        }

        private void btnAggiungiVeicolo_Click(object sender, EventArgs e)
        {
            frmAggiungiVeicolo dialogAggiungi = new frmAggiungiVeicolo(DbActions.bindingListVeicoli);
            dialogAggiungi.ShowDialog();
        }

        private void btnAggiornaDB_Click(object sender, EventArgs e)
        {
            DbActions.CreateListCars();

            timer1.Start();
            lblEvent.Text = "Dati aggiornati!!";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Utils.SerializeToXml(DbActions.bindingListVeicoli, path + "Veicoli.xml");

            Utils.SerializeToJson(DbActions.bindingListVeicoli, path + "Veicoli.json");

            timer1.Start();
            lblEvent.Text = "Data saved!!";
        }

        private void btnWebPage_Click(object sender, EventArgs e)
        {
            string webPath = (path + "www/index.html");
            Utils.createHtml(DbActions.bindingListVeicoli, webPath);
            System.Diagnostics.Process.Start(webPath);
        }

        private void btnModificaVeicolo_Click(object sender, EventArgs e)
        {
            string targa = Interaction.InputBox("Inserisci la targa dell'elemento da modificare");

            if (targa != "")
            {
                Veicolo v = DbActions.searchElement(targa.ToUpper());
                if (v != null)
                {
                    frmModifica frm = new frmModifica(v);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Controllare la targa inserita!!");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            WordUtilities.createDocument(path + "Veicoli.docx", "Car-Shop Solution");

            timer1.Start();
            lblEvent.Text = "Word document \ncreated!!";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Utils.SerializeToCsv(DbActions.bindingListVeicoli, path + "Veicoli.csv");

            timer1.Start();
            lblEvent.Text = "Excel file created!!";
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteVeicolo_Click(object sender, EventArgs e)
        {
            string targa = Interaction.InputBox("Inserisci la targa del veicolo da eliminare");
            if (targa != "")
            {
                if (isPresent(targa))
                {
                    DbActions.deleteItem(targa);
                    timer1.Start();
                    lblEvent.Text = "Item Deleted!!";
                }
                else
                    MessageBox.Show("Elemento non presente!!");
            }
        }

        private bool isPresent(string targa)
        {
            bool trovato = false;
            foreach (Veicolo v in DbActions.bindingListVeicoli)
            {
                if (v.Targa == targa)
                {
                    trovato = true;
                    break;
                }
            }

            return trovato;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick == 15)
            {
                lblEvent.Text = "";
                timer1.Stop();
                tick = 0;
            }
        }

        private void dgvVeicoli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVeicoli.SelectedCells.Count > 0)
            {
                string targa = dgvVeicoli.SelectedRows[0].Cells[0].Value.ToString();
                Veicolo v = DbActions.searchElement(targa.ToUpper());
                frmModifica frm = new frmModifica(v);
                frm.ShowDialog();
            }
        }
    }
}
