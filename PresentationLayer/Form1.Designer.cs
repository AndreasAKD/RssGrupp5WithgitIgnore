
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
            this.richTextBoxBeskrivning = new System.Windows.Forms.RichTextBox();
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
            this.columnFinnsNyaAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxAvsnitt = new System.Windows.Forms.ListBox();
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
            this.lblBeskrivning.Location = new System.Drawing.Point(814, 517);
            this.lblBeskrivning.Name = "lblBeskrivning";
            this.lblBeskrivning.Size = new System.Drawing.Size(88, 18);
            this.lblBeskrivning.TabIndex = 67;
            this.lblBeskrivning.Text = "Beskrivning:";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(814, 56);
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
            this.lblLaggTillPodd.Size = new System.Drawing.Size(150, 20);
            this.lblLaggTillPodd.TabIndex = 64;
            this.lblLaggTillPodd.Text = "Lägg till en podcast:";
            // 
            // btnFiltreraKategorier
            // 
            this.btnFiltreraKategorier.Location = new System.Drawing.Point(1088, 228);
            this.btnFiltreraKategorier.Name = "btnFiltreraKategorier";
            this.btnFiltreraKategorier.Size = new System.Drawing.Size(75, 23);
            this.btnFiltreraKategorier.TabIndex = 63;
            this.btnFiltreraKategorier.Text = "Filtrera";
            this.btnFiltreraKategorier.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBeskrivning
            // 
            this.richTextBoxBeskrivning.Location = new System.Drawing.Point(817, 540);
            this.richTextBoxBeskrivning.Name = "richTextBoxBeskrivning";
            this.richTextBoxBeskrivning.Size = new System.Drawing.Size(276, 237);
            this.richTextBoxBeskrivning.TabIndex = 62;
            this.richTextBoxBeskrivning.Text = "";
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(987, 416);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortKategori.TabIndex = 61;
            this.btnTaBortKategori.Text = "Ta Bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // btnUppdateraKategorier
            // 
            this.btnUppdateraKategorier.Location = new System.Drawing.Point(898, 416);
            this.btnUppdateraKategorier.Name = "btnUppdateraKategorier";
            this.btnUppdateraKategorier.Size = new System.Drawing.Size(75, 23);
            this.btnUppdateraKategorier.TabIndex = 60;
            this.btnUppdateraKategorier.Text = "Uppdatera";
            this.btnUppdateraKategorier.UseVisualStyleBackColor = true;

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
            this.listBoxKategorier.FormattingEnabled = true;
            this.listBoxKategorier.Location = new System.Drawing.Point(817, 86);
            this.listBoxKategorier.Name = "listBoxKategorier";
            this.listBoxKategorier.Size = new System.Drawing.Size(245, 251);
            this.listBoxKategorier.TabIndex = 52;
            this.listBoxKategorier.SelectedIndexChanged += new System.EventHandler(this.listBoxKategorier_SelectedIndexChanged);
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
            this.dataGridAllaPoddar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllaPoddar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAntalAvsnitt,
            this.columnPodNamn,
            this.columnKategori,
            this.columnUppdateringsIntervall,
            this.columnFinnsNyaAvsnitt});
            this.dataGridAllaPoddar.Location = new System.Drawing.Point(137, 52);
            this.dataGridAllaPoddar.Name = "dataGridAllaPoddar";
            this.dataGridAllaPoddar.Size = new System.Drawing.Size(545, 271);
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
            // columnFinnsNyaAvsnitt
            // 
            this.columnFinnsNyaAvsnitt.HeaderText = "Nya avsnitt";
            this.columnFinnsNyaAvsnitt.Name = "columnFinnsNyaAvsnitt";
            // 
            // listBoxAvsnitt
            // 
            this.listBoxAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBoxAvsnitt.FormattingEnabled = true;
            this.listBoxAvsnitt.ItemHeight = 17;
            this.listBoxAvsnitt.Location = new System.Drawing.Point(141, 540);
            this.listBoxAvsnitt.Name = "listBoxAvsnitt";
            this.listBoxAvsnitt.Size = new System.Drawing.Size(602, 191);
            this.listBoxAvsnitt.TabIndex = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 828);
            this.Controls.Add(this.listBoxAvsnitt);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lblBeskrivning);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lblLaggTillKategori);
            this.Controls.Add(this.lblLaggTillPodd);
            this.Controls.Add(this.btnFiltreraKategorier);
            this.Controls.Add(this.richTextBoxBeskrivning);
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

    

        #endregion

        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label lblBeskrivning;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Label lblLaggTillKategori;
        private System.Windows.Forms.Label lblLaggTillPodd;
        private System.Windows.Forms.Button btnFiltreraKategorier;
        private System.Windows.Forms.RichTextBox richTextBoxBeskrivning;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAntalAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPodNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUppdateringsIntervall;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFinnsNyaAvsnitt;
        private System.Windows.Forms.ListBox listBoxAvsnitt;
    }
}

