using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using VenditaVeicoliDllProject;

namespace WindowsFormsAppProject
{
    public partial class frmAggiungiVeicolo : Form
    {
        string color,
               veicolo;
        BindingList<Veicolo> lista;
        public frmAggiungiVeicolo()
        {
            InitializeComponent();
        }

        public frmAggiungiVeicolo(BindingList<Veicolo> bindListaVeicolo)
        {
            InitializeComponent();
            lista = bindListaVeicolo;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAggiungiVeicolo_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (veicolo != null)
            {
                if (veicolo == "Auto")
                {
                    Auto a = new Auto(txtMarca.Text, txtModello.Text, color, Convert.ToInt32(nupCilindrata.Value), Convert.ToDouble(nupPotenza.Value), dtpDataImmatricolazione.Value, rdbNo.Checked ? false : true, cmbKm0.SelectedIndex == 0 ? true : false, Convert.ToInt32(nupKm.Value), Convert.ToInt32(nupNAirbag.Value));
                    lista.Add(a);
                    pulisciCampi();
                    aggioraCampi(cmbVeicolo.Text);
                }
                else
                {
                    Moto m = new Moto(txtMarca.Text, txtModello.Text, color, Convert.ToInt32(nupCilindrata.Value), Convert.ToDouble(nupPotenza.Value), dtpDataImmatricolazione.Value, rdbNo.Checked ? false : true, cmbKm0.SelectedIndex == 0 ? true : false, Convert.ToInt32(nupKm.Value), txtMarcaSella.Text);
                    lista.Add(m);
                    pulisciCampi();
                    aggioraCampi(cmbVeicolo.Text);
                }
            }
            else
            {
                if (pnlControlli.Visible == true)
                    MessageBox.Show("Compilare prima i campi!!");
                else
                    errorProvider1.SetError(cmbVeicolo, "Selezionare un opzione!!!");
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                color = colorDialog1.Color.Name.ToString();
        }

        private void CmbVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlControlli.Visible = true;
            pulisciCampi();
            aggioraCampi(cmbVeicolo.Text);
        }

        private void pulisciCampi()
        {
            txtMarca.Text = "";
            txtModello.Text = "";
            nupCilindrata.Value = 0;
            nupKm.Value = 0;
            nupPotenza.Value = 0;
            rdbSi.Checked = false;
            rdbNo.Checked = false;
            nupNAirbag.Value = 0;
            nupNAirbag.Enabled = false;
            txtMarcaSella.Text = "";
            txtMarcaSella.Enabled = false;
            cmbKm0.SelectedIndex = -1;
            veicolo = "";
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNo.Checked)
                cmbKm0.Enabled = true;
            else
                cmbKm0.Enabled = false;
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSi.Checked)
                cmbKm0.Enabled = false;
            else
                cmbKm0.Enabled = true;
        }

        private void aggioraCampi(string type)
        {
            switch (type)
            {
                case "Auto":
                    nupNAirbag.Enabled = true;
                    veicolo = "Auto";
                    break;
                case "Moto":
                    txtMarcaSella.Enabled = true;
                    veicolo = "Moto";
                    break;
            }
        }
    }
}
