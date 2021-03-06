
using System;

namespace PresentationLayer
{
    partial class Form1
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
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lblBeskrivning = new System.Windows.Forms.Label();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblLaggTillKategori = new System.Windows.Forms.Label();
            this.lblLaggTillPodd = new System.Windows.Forms.Label();
            this.btnFiltreraKategorier = new System.Windows.Forms.Button();
            this.textBoxBeskrivning = new System.Windows.Forms.RichTextBox();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnUppdateraKategorier = new System.Windows.Forms.Button();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.cbValdKategori = new System.Windows.Forms.ComboBox();
            this.cbUppdateringsfrekvens = new System.Windows.Forms.ComboBox();
            this.btnUppdateraPoddlsita = new System.Windows.Forms.Button();
            this.btnTaBortPodd = new System.Windows.Forms.Button();
            this.btnLaggTillPodd = new System.Windows.Forms.Button();
            this.textBoxKategorier = new System.Windows.Forms.TextBox();
            this.listBoxKategorier = new System.Windows.Forms.ListBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.txtBoxNamn = new System.Windows.Forms.TextBox();
            this.dataGridAllaPoddar = new System.Windows.Forms.DataGridView();
            this.columnAntalAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPodNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUppdateringsIntervall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxAvsnitt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVirtualPodcast = new System.Windows.Forms.Button();
            this.btnVirtualAvsnitt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllaPoddar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(137, 485);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(55, 18);
            this.lblAvsnitt.TabIndex = 68;
            this.lblAvsnitt.Text = "Avsnitt:";
            // 
            // lblBeskrivning
            // 
            this.lblBeskrivning.AutoSize = true;
            this.lblBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeskrivning.Location = new System.Drawing.Point(814, 485);
            this.lblBeskrivning.Name = "lblBeskrivning";
            this.lblBeskrivning.Size = new System.Drawing.Size(88, 18);
            this.lblBeskrivning.TabIndex = 67;
            this.lblBeskrivning.Text = "Beskrivning:";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(814, 20);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(80, 18);
            this.lblKategorier.TabIndex = 66;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // lblLaggTillKategori
            // 
            this.lblLaggTillKategori.AutoSize = true;
            this.lblLaggTillKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaggTillKategori.Location = new System.Drawing.Point(814, 356);
            this.lblLaggTillKategori.Name = "lblLaggTillKategori";
            this.lblLaggTillKategori.Size = new System.Drawing.Size(138, 18);
            this.lblLaggTillKategori.TabIndex = 65;
            this.lblLaggTillKategori.Text = "Lägg till en kategori:";
            // 
            // lblLaggTillPodd
            // 
            this.lblLaggTillPodd.AutoSize = true;
            this.lblLaggTillPodd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaggTillPodd.Location = new System.Drawing.Point(137, 339);
            this.lblLaggTillPodd.Name = "lblLaggTillPodd";
            this.lblLaggTillPodd.Size = new System.Drawing.Size(280, 20);
            this.lblLaggTillPodd.TabIndex = 64;
            this.lblLaggTillPodd.Text = "Lägg till en ny podcast eller ändra vald:";
            // 
            // btnFiltreraKategorier
            // 
            this.btnFiltreraKategorier.Location = new System.Drawing.Point(1068, 52);
            this.btnFiltreraKategorier.Name = "btnFiltreraKategorier";
            this.btnFiltreraKategorier.Size = new System.Drawing.Size(118, 39);
            this.btnFiltreraKategorier.TabIndex = 63;
            this.btnFiltreraKategorier.Text = "Filtrera pod av kategori";
            this.btnFiltreraKategorier.UseVisualStyleBackColor = true;
            this.btnFiltreraKategorier.Click += new System.EventHandler(this.btnFiltreraKategorier_Click);
            // 
            // textBoxBeskrivning
            // 
            this.textBoxBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxBeskrivning.Location = new System.Drawing.Point(817, 517);
            this.textBoxBeskrivning.Name = "textBoxBeskrivning";
            this.textBoxBeskrivning.Size = new System.Drawing.Size(276, 284);
            this.textBoxBeskrivning.TabIndex = 62;
            this.textBoxBeskrivning.Text = "";
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(987, 416);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortKategori.TabIndex = 61;
            this.btnTaBortKategori.Text = "Ta Bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnUppdateraKategorier
            // 
            this.btnUppdateraKategorier.Location = new System.Drawing.Point(898, 416);
            this.btnUppdateraKategorier.Name = "btnUppdateraKategorier";
            this.btnUppdateraKategorier.Size = new System.Drawing.Size(75, 23);
            this.btnUppdateraKategorier.TabIndex = 60;
            this.btnUppdateraKategorier.Text = "Uppdatera";
            this.btnUppdateraKategorier.UseVisualStyleBackColor = true;
            this.btnUppdateraKategorier.Click += new System.EventHandler(this.btnUppdateraKategorier_Click);
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(817, 416);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(75, 23);
            this.btnNyKategori.TabIndex = 59;
            this.btnNyKategori.Text = "Lägg till...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // cbValdKategori
            // 
            this.cbValdKategori.FormattingEnabled = true;
            this.cbValdKategori.Location = new System.Drawing.Point(528, 388);
            this.cbValdKategori.Name = "cbValdKategori";
            this.cbValdKategori.Size = new System.Drawing.Size(121, 21);
            this.cbValdKategori.TabIndex = 58;
            // 
            // cbUppdateringsfrekvens
            // 
            this.cbUppdateringsfrekvens.FormattingEnabled = true;
            this.cbUppdateringsfrekvens.Location = new System.Drawing.Point(376, 388);
            this.cbUppdateringsfrekvens.Name = "cbUppdateringsfrekvens";
            this.cbUppdateringsfrekvens.Size = new System.Drawing.Size(121, 21);
            this.cbUppdateringsfrekvens.TabIndex = 57;
            // 
            // btnUppdateraPoddlsita
            // 
            this.btnUppdateraPoddlsita.Location = new System.Drawing.Point(476, 433);
            this.btnUppdateraPoddlsita.Name = "btnUppdateraPoddlsita";
            this.btnUppdateraPoddlsita.Size = new System.Drawing.Size(75, 23);
            this.btnUppdateraPoddlsita.TabIndex = 56;
            this.btnUppdateraPoddlsita.Text = "Uppdatera";
            this.btnUppdateraPoddlsita.UseVisualStyleBackColor = true;
            this.btnUppdateraPoddlsita.Click += new System.EventHandler(this.btnUppdateraPoddlsita_Click_1);
            // 
            // btnTaBortPodd
            // 
            this.btnTaBortPodd.Location = new System.Drawing.Point(557, 433);
            this.btnTaBortPodd.Name = "btnTaBortPodd";
            this.btnTaBortPodd.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortPodd.TabIndex = 55;
            this.btnTaBortPodd.Text = "Ta Bort...";
            this.btnTaBortPodd.UseVisualStyleBackColor = true;
            this.btnTaBortPodd.Click += new System.EventHandler(this.btnTaBortPodd_Click);
            // 
            // btnLaggTillPodd
            // 
            this.btnLaggTillPodd.Location = new System.Drawing.Point(376, 433);
            this.btnLaggTillPodd.Name = "btnLaggTillPodd";
            this.btnLaggTillPodd.Size = new System.Drawing.Size(94, 23);
            this.btnLaggTillPodd.TabIndex = 54;
            this.btnLaggTillPodd.Text = "Lägg till...";
            this.btnLaggTillPodd.UseVisualStyleBackColor = true;
            this.btnLaggTillPodd.Click += new System.EventHandler(this.btnLaggTillPodd_Click);
            // 
            // textBoxKategorier
            // 
            this.textBoxKategorier.Location = new System.Drawing.Point(817, 390);
            this.textBoxKategorier.Name = "textBoxKategorier";
            this.textBoxKategorier.Size = new System.Drawing.Size(245, 20);
            this.textBoxKategorier.TabIndex = 53;
            // 
            // listBoxKategorier
            // 
            this.listBoxKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKategorier.FormattingEnabled = true;
            this.listBoxKategorier.ItemHeight = 18;
            this.listBoxKategorier.Location = new System.Drawing.Point(817, 52);
            this.listBoxKategorier.Name = "listBoxKategorier";
            this.listBoxKategorier.Size = new System.Drawing.Size(245, 274);
            this.listBoxKategorier.TabIndex = 52;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(137, 420);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 50;
            this.lblURL.Text = "URL:";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(137, 374);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(38, 13);
            this.lblNamn.TabIndex = 49;
            this.lblNamn.Text = "Namn:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(137, 436);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(200, 20);
            this.textBoxURL.TabIndex = 48;
            // 
            // txtBoxNamn
            // 
            this.txtBoxNamn.Location = new System.Drawing.Point(137, 390);
            this.txtBoxNamn.Name = "txtBoxNamn";
            this.txtBoxNamn.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNamn.TabIndex = 47;
            // 
            // dataGridAllaPoddar
            // 
            this.dataGridAllaPoddar.AllowUserToAddRows = false;
            this.dataGridAllaPoddar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllaPoddar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAntalAvsnitt,
            this.columnPodNamn,
            this.columnKategori,
            this.columnUppdateringsIntervall});
            this.dataGridAllaPoddar.Location = new System.Drawing.Point(141, 52);
            this.dataGridAllaPoddar.Name = "dataGridAllaPoddar";
            this.dataGridAllaPoddar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAllaPoddar.Size = new System.Drawing.Size(443, 271);
            this.dataGridAllaPoddar.TabIndex = 46;
            this.dataGridAllaPoddar.SelectionChanged += new System.EventHandler(this.dataGridAllaPoddar_SelectionChanged);
            // 
            // columnAntalAvsnitt
            // 
            this.columnAntalAvsnitt.HeaderText = "Antal avsnitt";
            this.columnAntalAvsnitt.Name = "columnAntalAvsnitt";
            // 
            // columnPodNamn
            // 
            this.columnPodNamn.HeaderText = "Namn";
            this.columnPodNamn.Name = "columnPodNamn";
            // 
            // columnKategori
            // 
            this.columnKategori.HeaderText = "Kategori";
            this.columnKategori.Name = "columnKategori";
            // 
            // columnUppdateringsIntervall
            // 
            this.columnUppdateringsIntervall.HeaderText = "Upd.Intervall";
            this.columnUppdateringsIntervall.Name = "columnUppdateringsIntervall";
            // 
            // listBoxAvsnitt
            // 
            this.listBoxAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBoxAvsnitt.FormattingEnabled = true;
            this.listBoxAvsnitt.ItemHeight = 20;
            this.listBoxAvsnitt.Location = new System.Drawing.Point(141, 517);
            this.listBoxAvsnitt.Name = "listBoxAvsnitt";
            this.listBoxAvsnitt.Size = new System.Drawing.Size(602, 284);
            this.listBoxAvsnitt.TabIndex = 70;
            this.listBoxAvsnitt.SelectedIndexChanged += new System.EventHandler(this.listBoxAvsnitt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Uppdateringsintervall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Välj kategori:";
            // 
            // btnVirtualPodcast
            // 
            this.btnVirtualPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVirtualPodcast.Location = new System.Drawing.Point(141, 832);
            this.btnVirtualPodcast.Name = "btnVirtualPodcast";
            this.btnVirtualPodcast.Size = new System.Drawing.Size(175, 36);
            this.btnVirtualPodcast.TabIndex = 74;
            this.btnVirtualPodcast.Text = "Virtual override Podcast";
            this.btnVirtualPodcast.UseVisualStyleBackColor = true;
            this.btnVirtualPodcast.Click += new System.EventHandler(this.btnVirtualPodcast_Click);
            // 
            // btnVirtualAvsnitt
            // 
            this.btnVirtualAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVirtualAvsnitt.Location = new System.Drawing.Point(352, 832);
            this.btnVirtualAvsnitt.Name = "btnVirtualAvsnitt";
            this.btnVirtualAvsnitt.Size = new System.Drawing.Size(160, 36);
            this.btnVirtualAvsnitt.TabIndex = 75;
            this.btnVirtualAvsnitt.Text = "Virtual override Avsnitt";
            this.btnVirtualAvsnitt.UseVisualStyleBackColor = true;
            this.btnVirtualAvsnitt.Click += new System.EventHandler(this.btnVirtualAvsnitt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(480, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 76;
            this.button1.Text = "Uppdatera poddlistan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 898);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVirtualAvsnitt);
            this.Controls.Add(this.btnVirtualPodcast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAvsnitt);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lblBeskrivning);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lblLaggTillKategori);
            this.Controls.Add(this.lblLaggTillPodd);
            this.Controls.Add(this.btnFiltreraKategorier);
            this.Controls.Add(this.textBoxBeskrivning);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnUppdateraKategorier);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.cbValdKategori);
            this.Controls.Add(this.cbUppdateringsfrekvens);
            this.Controls.Add(this.btnUppdateraPoddlsita);
            this.Controls.Add(this.btnTaBortPodd);
            this.Controls.Add(this.btnLaggTillPodd);
            this.Controls.Add(this.textBoxKategorier);
            this.Controls.Add(this.listBoxKategorier);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.txtBoxNamn);
            this.Controls.Add(this.dataGridAllaPoddar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllaPoddar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUppdateraPoddlsita_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label lblBeskrivning;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Label lblLaggTillKategori;
        private System.Windows.Forms.Label lblLaggTillPodd;
        private System.Windows.Forms.Button btnFiltreraKategorier;
        private System.Windows.Forms.RichTextBox textBoxBeskrivning;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnUppdateraKategorier;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.ComboBox cbValdKategori;
        private System.Windows.Forms.ComboBox cbUppdateringsfrekvens;
        private System.Windows.Forms.Button btnUppdateraPoddlsita;
        private System.Windows.Forms.Button btnTaBortPodd;
        private System.Windows.Forms.Button btnLaggTillPodd;
        private System.Windows.Forms.TextBox textBoxKategorier;
        private System.Windows.Forms.ListBox listBoxKategorier;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox txtBoxNamn;
        private System.Windows.Forms.DataGridView dataGridAllaPoddar;
        private System.Windows.Forms.ListBox listBoxAvsnitt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAntalAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPodNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUppdateringsIntervall;
        private System.Windows.Forms.Button btnVirtualPodcast;
        private System.Windows.Forms.Button btnVirtualAvsnitt;
        private System.Windows.Forms.Button button1;
    }
}

