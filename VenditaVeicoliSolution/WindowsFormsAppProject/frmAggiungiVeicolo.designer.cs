namespace WindowsFormsAppProject
{
    partial class frmAggiungiVeicolo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAggiungiVeicolo));
            this.pnlControlli = new System.Windows.Forms.Panel();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbKm0 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.txtMarcaSella = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nupNAirbag = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nupKm = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nupPotenza = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nupCilindrata = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAggiungiVeicolo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVeicolo = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMarginTop = new System.Windows.Forms.Panel();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.pcbIcona = new System.Windows.Forms.PictureBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.pnlControlli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNAirbag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPotenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCilindrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlMarginTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcona)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlli
            // 
            this.pnlControlli.Controls.Add(this.txtTarga);
            this.pnlControlli.Controls.Add(this.label13);
            this.pnlControlli.Controls.Add(this.cmbKm0);
            this.pnlControlli.Controls.Add(this.label12);
            this.pnlControlli.Controls.Add(this.rdbNo);
            this.pnlControlli.Controls.Add(this.rdbSi);
            this.pnlControlli.Controls.Add(this.txtMarcaSella);
            this.pnlControlli.Controls.Add(this.label11);
            this.pnlControlli.Controls.Add(this.nupNAirbag);
            this.pnlControlli.Controls.Add(this.label10);
            this.pnlControlli.Controls.Add(this.btnSelectColor);
            this.pnlControlli.Controls.Add(this.label9);
            this.pnlControlli.Controls.Add(this.nupKm);
            this.pnlControlli.Controls.Add(this.label8);
            this.pnlControlli.Controls.Add(this.dtpDataImmatricolazione);
            this.pnlControlli.Controls.Add(this.label7);
            this.pnlControlli.Controls.Add(this.nupPotenza);
            this.pnlControlli.Controls.Add(this.label6);
            this.pnlControlli.Controls.Add(this.nupCilindrata);
            this.pnlControlli.Controls.Add(this.label5);
            this.pnlControlli.Controls.Add(this.label4);
            this.pnlControlli.Controls.Add(this.txtModello);
            this.pnlControlli.Controls.Add(this.label3);
            this.pnlControlli.Controls.Add(this.txtMarca);
            this.pnlControlli.Controls.Add(this.label2);
            this.pnlControlli.Location = new System.Drawing.Point(12, 93);
            this.pnlControlli.Name = "pnlControlli";
            this.pnlControlli.Size = new System.Drawing.Size(669, 205);
            this.pnlControlli.TabIndex = 33;
            this.pnlControlli.Visible = false;
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(95, 21);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(125, 20);
            this.txtTarga.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Targa:";
            // 
            // cmbKm0
            // 
            this.cmbKm0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKm0.FormattingEnabled = true;
            this.cmbKm0.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbKm0.Location = new System.Drawing.Point(570, 134);
            this.cmbKm0.Name = "cmbKm0";
            this.cmbKm0.Size = new System.Drawing.Size(74, 21);
            this.cmbKm0.TabIndex = 53;
            this.cmbKm0.SelectedIndexChanged += new System.EventHandler(this.cmbKm0_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(506, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "E km0:";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.Location = new System.Drawing.Point(421, 133);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(46, 22);
            this.rdbNo.TabIndex = 51;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSi.Location = new System.Drawing.Point(376, 133);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(39, 22);
            this.rdbSi.TabIndex = 50;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // txtMarcaSella
            // 
            this.txtMarcaSella.Enabled = false;
            this.txtMarcaSella.Location = new System.Drawing.Point(353, 174);
            this.txtMarcaSella.Name = "txtMarcaSella";
            this.txtMarcaSella.Size = new System.Drawing.Size(74, 20);
            this.txtMarcaSella.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(254, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Marca sella:";
            // 
            // nupNAirbag
            // 
            this.nupNAirbag.Enabled = false;
            this.nupNAirbag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNAirbag.Location = new System.Drawing.Point(136, 173);
            this.nupNAirbag.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupNAirbag.Name = "nupNAirbag";
            this.nupNAirbag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupNAirbag.Size = new System.Drawing.Size(85, 22);
            this.nupNAirbag.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Numero airbag:";
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectColor.Location = new System.Drawing.Point(524, 54);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(119, 23);
            this.btnSelectColor.TabIndex = 42;
            this.btnSelectColor.Text = "Colore";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Veicolo usato:";
            // 
            // nupKm
            // 
            this.nupKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupKm.Location = new System.Drawing.Point(137, 133);
            this.nupKm.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupKm.Name = "nupKm";
            this.nupKm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupKm.Size = new System.Drawing.Size(85, 22);
            this.nupKm.TabIndex = 40;
            this.nupKm.ValueChanged += new System.EventHandler(this.nupKm_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Chilometraggio:";
            // 
            // dtpDataImmatricolazione
            // 
            this.dtpDataImmatricolazione.Location = new System.Drawing.Point(392, 19);
            this.dtpDataImmatricolazione.Name = "dtpDataImmatricolazione";
            this.dtpDataImmatricolazione.Size = new System.Drawing.Size(251, 20);
            this.dtpDataImmatricolazione.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Immatricolazione:";
            // 
            // nupPotenza
            // 
            this.nupPotenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPotenza.Location = new System.Drawing.Point(366, 93);
            this.nupPotenza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupPotenza.Name = "nupPotenza";
            this.nupPotenza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupPotenza.Size = new System.Drawing.Size(60, 22);
            this.nupPotenza.TabIndex = 36;
            this.nupPotenza.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Potenza(KW):";
            // 
            // nupCilindrata
            // 
            this.nupCilindrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCilindrata.Location = new System.Drawing.Point(96, 93);
            this.nupCilindrata.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupCilindrata.Name = "nupCilindrata";
            this.nupCilindrata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupCilindrata.Size = new System.Drawing.Size(125, 22);
            this.nupCilindrata.TabIndex = 34;
            this.nupCilindrata.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cilindrata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Colore:";
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(327, 56);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(99, 20);
            this.txtModello.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Modello:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(95, 56);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(125, 20);
            this.txtMarca.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Marca:";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(547, 304);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(133, 35);
            this.btnAnnulla.TabIndex = 32;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAggiungiVeicolo
            // 
            this.btnAggiungiVeicolo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAggiungiVeicolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiVeicolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiVeicolo.Location = new System.Drawing.Point(404, 304);
            this.btnAggiungiVeicolo.Name = "btnAggiungiVeicolo";
            this.btnAggiungiVeicolo.Size = new System.Drawing.Size(133, 35);
            this.btnAggiungiVeicolo.TabIndex = 31;
            this.btnAggiungiVeicolo.Text = "AGGIUNGI";
            this.btnAggiungiVeicolo.UseVisualStyleBackColor = true;
            this.btnAggiungiVeicolo.Click += new System.EventHandler(this.btnAggiungiVeicolo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Scegli il tipo di veicolo:";
            // 
            // cmbVeicolo
            // 
            this.cmbVeicolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeicolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeicolo.FormattingEnabled = true;
            this.cmbVeicolo.Items.AddRange(new object[] {
            "Auto",
            "Moto"});
            this.cmbVeicolo.Location = new System.Drawing.Point(338, 51);
            this.cmbVeicolo.Name = "cmbVeicolo";
            this.cmbVeicolo.Size = new System.Drawing.Size(204, 23);
            this.cmbVeicolo.TabIndex = 29;
            this.cmbVeicolo.SelectedIndexChanged += new System.EventHandler(this.CmbVeicolo_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlMarginTop
            // 
            this.pnlMarginTop.Controls.Add(this.btnChiudi);
            this.pnlMarginTop.Controls.Add(this.pcbIcona);
            this.pnlMarginTop.Controls.Add(this.lblTitolo);
            this.pnlMarginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMarginTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMarginTop.Name = "pnlMarginTop";
            this.pnlMarginTop.Size = new System.Drawing.Size(691, 37);
            this.pnlMarginTop.TabIndex = 34;
            // 
            // btnChiudi
            // 
            this.btnChiudi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChiudi.BackgroundImage")));
            this.btnChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChiudi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiudi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChiudi.FlatAppearance.BorderSize = 0;
            this.btnChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiudi.Location = new System.Drawing.Point(650, 0);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(41, 37);
            this.btnChiudi.TabIndex = 4;
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // pcbIcona
            // 
            this.pcbIcona.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcona.Image")));
            this.pcbIcona.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbIcona.InitialImage")));
            this.pcbIcona.Location = new System.Drawing.Point(3, 3);
            this.pcbIcona.Name = "pcbIcona";
            this.pcbIcona.Size = new System.Drawing.Size(26, 26);
            this.pcbIcona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcona.TabIndex = 3;
            this.pcbIcona.TabStop = false;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitolo.Location = new System.Drawing.Point(35, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(150, 18);
            this.lblTitolo.TabIndex = 3;
            this.lblTitolo.Text = "AGGIUNGI VEICOLO";
            // 
            // frmAggiungiVeicolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(691, 351);
            this.Controls.Add(this.pnlMarginTop);
            this.Controls.Add(this.pnlControlli);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnAggiungiVeicolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVeicolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAggiungiVeicolo";
            this.Text = "AGGIUNGI VEICOLO";
            this.pnlControlli.ResumeLayout(false);
            this.pnlControlli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNAirbag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPotenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCilindrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlMarginTop.ResumeLayout(false);
            this.pnlMarginTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlli;
        private System.Windows.Forms.TextBox txtMarcaSella;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nupNAirbag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupKm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataImmatricolazione;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupPotenza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupCilindrata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnAggiungiVeicolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVeicolo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbKm0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlMarginTop;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.PictureBox pcbIcona;
        private System.Windows.Forms.Label lblTitolo;
    }
}