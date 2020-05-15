using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenditaVeicoliDllProject;

namespace WindowsFormsAppProject
{
    public partial class frmModifica : Form
    {
        private Veicolo v;

        public frmModifica()
        {
            InitializeComponent();
        }

        public frmModifica(Veicolo v)
        {
            this.v = v;
            InitializeComponent();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifica_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblTitolo.Text = v.Marca.ToString() + " " + v.Modello.ToString();
            lblTarga.Text = v.Targa.ToString();
            lblMarca.Text = v.Marca.ToString();
            lblModello.Text = v.Modello.ToString();
            lblColore.Text = v.Colore.ToString();
            lblTipo.Text = v.IsUsato ? "Usato" : "Km0";
            lblData.Text = v.Immatricolazione.ToShortDateString();
            lblCilindrata.Text = v.Cilindrata.ToString();
            lblPotenza.Text = v.PotenzaKw.ToString();
            lblKm.Text = v.KmPercorsi.ToString();
            if (v is Auto)
            {
                pcbImg.Image = Image.FromFile(DbActions.path + "www/img/Auto/auto" + (rnd.Next(0, 7) + 1) + ".jpg");
                lblSpecTitle.Text = "NUM-AIRBAG:";
                lblSpec.Text = trovaSpec("Auto");
            }
            else
            {
                pcbImg.Image = Image.FromFile(DbActions.path + "www/img/Moto/moto" + (rnd.Next(0, 7) + 1) + ".jpg");
                lblSpecTitle.Text = "MARCA-SELLA:";
                lblSpec.Text = trovaSpec("Moto");
            }
            pcbImg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string trovaSpec(string veicolo)
        {
            string str = "";

            if(veicolo == "Auto")
            {
                foreach (Veicolo item in DbActions.bindingListVeicoli)
                {
                    if (item.Targa == v.Targa)
                        str = (item as Auto).NumAirbag.ToString();
                }
            }
            else
            {
                foreach (Veicolo item in DbActions.bindingListVeicoli)
                {
                    if (item.Targa == v.Targa)
                        str = (item as Moto).MarcaSella;
                }
            }

            return str;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string oldVal = Interaction.InputBox("Inserisci il campo che vuoi modificare"),
                   newVal = Interaction.InputBox("Insersci il nuovo valore");
            if (oldVal != "" && newVal != "")
            {
                DbActions.modifyItem(v.Targa, v.Marca, oldVal, newVal);
                this.Close();
            }
            else
                MessageBox.Show("Input non valido!!");
        }
    }
}
