using Microsoft.Win32;

namespace Stoperica
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.btnKreni = new System.Windows.Forms.Button();
            this.btnStani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUkupnoVrijeme = new System.Windows.Forms.Label();
            this.btnDatoteka = new System.Windows.Forms.Button();
            this.lblTrenutnoVrijeme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerTrenutnoVrijeme = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.txtPredmetOstali = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazivOstalo = new System.Windows.Forms.TextBox();
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSati = new System.Windows.Forms.Label();
            this.txtZadatak = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFunkcionalnost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKreni
            // 
            this.btnKreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreni.Location = new System.Drawing.Point(365, 12);
            this.btnKreni.Name = "btnKreni";
            this.btnKreni.Size = new System.Drawing.Size(127, 100);
            this.btnKreni.TabIndex = 7;
            this.btnKreni.Text = "Kreni";
            this.btnKreni.UseVisualStyleBackColor = true;
            this.btnKreni.Click += new System.EventHandler(this.btnKreni_Click);
            // 
            // btnStani
            // 
            this.btnStani.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStani.Location = new System.Drawing.Point(549, 12);
            this.btnStani.Name = "btnStani";
            this.btnStani.Size = new System.Drawing.Size(127, 100);
            this.btnStani.TabIndex = 8;
            this.btnStani.Text = "Stani";
            this.btnStani.UseVisualStyleBackColor = true;
            this.btnStani.Click += new System.EventHandler(this.btnStani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(360, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ukupno vrijeme:";
            // 
            // lblUkupnoVrijeme
            // 
            this.lblUkupnoVrijeme.AutoSize = true;
            this.lblUkupnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnoVrijeme.Location = new System.Drawing.Point(544, 222);
            this.lblUkupnoVrijeme.Name = "lblUkupnoVrijeme";
            this.lblUkupnoVrijeme.Size = new System.Drawing.Size(129, 25);
            this.lblUkupnoVrijeme.TabIndex = 3;
            this.lblUkupnoVrijeme.Text = "00:00:00:00";
            // 
            // btnDatoteka
            // 
            this.btnDatoteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDatoteka.Location = new System.Drawing.Point(20, 12);
            this.btnDatoteka.Name = "btnDatoteka";
            this.btnDatoteka.Size = new System.Drawing.Size(284, 74);
            this.btnDatoteka.TabIndex = 1;
            this.btnDatoteka.Text = "Odaberi datoteku";
            this.btnDatoteka.UseVisualStyleBackColor = true;
            this.btnDatoteka.Click += new System.EventHandler(this.btnDatoteka_Click);
            // 
            // lblTrenutnoVrijeme
            // 
            this.lblTrenutnoVrijeme.AutoSize = true;
            this.lblTrenutnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutnoVrijeme.Location = new System.Drawing.Point(544, 183);
            this.lblTrenutnoVrijeme.Name = "lblTrenutnoVrijeme";
            this.lblTrenutnoVrijeme.Size = new System.Drawing.Size(129, 25);
            this.lblTrenutnoVrijeme.TabIndex = 6;
            this.lblTrenutnoVrijeme.Text = "00:00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(345, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trenutno vrijeme:";
            // 
            // timerTrenutnoVrijeme
            // 
            this.timerTrenutnoVrijeme.Interval = 1000;
            this.timerTrenutnoVrijeme.Tick += new System.EventHandler(this.timerTrenutnoVrijeme_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(544, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "dd:HH:mm:ss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Predmet";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.AllowDrop = true;
            this.cmbPredmeti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbPredmeti.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Items.AddRange(new object[] {
            "NWTiS",
            "Web DiP",
            "Ostalo"});
            this.cmbPredmeti.Location = new System.Drawing.Point(20, 149);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(121, 24);
            this.cmbPredmeti.TabIndex = 2;
            this.cmbPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbPredmeti_SelectedIndexChanged);
            // 
            // txtPredmetOstali
            // 
            this.txtPredmetOstali.Location = new System.Drawing.Point(20, 187);
            this.txtPredmetOstali.Name = "txtPredmetOstali";
            this.txtPredmetOstali.Size = new System.Drawing.Size(121, 22);
            this.txtPredmetOstali.TabIndex = 3;
            this.txtPredmetOstali.TextChanged += new System.EventHandler(this.txtPredmetOstali_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(179, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Naziv";
            // 
            // txtNazivOstalo
            // 
            this.txtNazivOstalo.Location = new System.Drawing.Point(183, 187);
            this.txtNazivOstalo.Name = "txtNazivOstalo";
            this.txtNazivOstalo.Size = new System.Drawing.Size(121, 22);
            this.txtNazivOstalo.TabIndex = 5;
            this.txtNazivOstalo.TextChanged += new System.EventHandler(this.txtNazivOstalo_TextChanged);
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.AllowDrop = true;
            this.cmbNaziv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbNaziv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Items.AddRange(new object[] {
            "Zadaća_1",
            "Zadaća_2",
            "Zadaća_3",
            "Zadaća_4",
            "Zadaća_5",
            "Projekt",
            "Ostalo"});
            this.cmbNaziv.Location = new System.Drawing.Point(183, 149);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(121, 24);
            this.cmbNaziv.TabIndex = 4;
            this.cmbNaziv.SelectedIndexChanged += new System.EventHandler(this.cmbNaziv_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(393, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ukupno sati:";
            // 
            // lblSati
            // 
            this.lblSati.AutoSize = true;
            this.lblSati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSati.ForeColor = System.Drawing.Color.Red;
            this.lblSati.Location = new System.Drawing.Point(544, 257);
            this.lblSati.Name = "lblSati";
            this.lblSati.Size = new System.Drawing.Size(24, 25);
            this.lblSati.TabIndex = 12;
            this.lblSati.Text = "0";
            // 
            // txtZadatak
            // 
            this.txtZadatak.Location = new System.Drawing.Point(20, 261);
            this.txtZadatak.Name = "txtZadatak";
            this.txtZadatak.Size = new System.Drawing.Size(284, 22);
            this.txtZadatak.TabIndex = 6;
            this.txtZadatak.Text = "Sve";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(16, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Zadatak";
            // 
            // txtFunkcionalnost
            // 
            this.txtFunkcionalnost.Location = new System.Drawing.Point(20, 259);
            this.txtFunkcionalnost.Name = "txtFunkcionalnost";
            this.txtFunkcionalnost.Size = new System.Drawing.Size(284, 22);
            this.txtFunkcionalnost.TabIndex = 10;
            this.txtFunkcionalnost.Text = "Sve";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZadatak);
            this.Controls.Add(this.lblUkupnoVrijeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivOstalo);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.lblTrenutnoVrijeme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPredmetOstali);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDatoteka);
            this.Controls.Add(this.btnStani);
            this.Controls.Add(this.btnKreni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Štoperica za zadaće i projekte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pocetna_FormClosing);
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreni;
        private System.Windows.Forms.Button btnStani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUkupnoVrijeme;
        private System.Windows.Forms.Button btnDatoteka;
        private System.Windows.Forms.Label lblTrenutnoVrijeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerTrenutnoVrijeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.TextBox txtPredmetOstali;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazivOstalo;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSati;
        private System.Windows.Forms.TextBox txtFunkcionalnost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtZadatak;
    }
}

