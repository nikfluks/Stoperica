using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Stoperica
{
    public partial class Pocetna : Form
    {
        string datoteka = string.Empty;
        DateTime pocetak;
        DateTime kraj;
        TimeSpan trenutno = TimeSpan.Zero;
        TimeSpan ukupno = TimeSpan.Zero;
        bool pokrenuta = false;
        int pozicijaPocetkaUkupnogVremena;
        bool postojiZaglavlje = false;
        int sati = 0;
        int satiPozicija;
        string podaciIzDatoteke = string.Empty;
        string odabraniPredmet = string.Empty;
        string odabraniNaziv = string.Empty;

        public Pocetna()
        {
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(PromjenaStanja);
            Onemoguci();
            cmbPredmeti.SelectedIndex = 0;
            cmbNaziv.SelectedIndex = 0;
            txtZadatak.Enabled = false;
        }

        private void btnDatoteka_Click(object sender, EventArgs e)
        {
            if (!pokrenuta)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Odaberi log datoteku";
                ofd.RestoreDirectory = false;
                ofd.ShowDialog();
                string dat = ofd.FileName;

                if (dat != string.Empty && datoteka != dat)
                {
                    this.Text = "Štoperica [" + dat + "]";
                    datoteka = ofd.FileName;
                    ukupno = TimeSpan.Zero;
                    trenutno = TimeSpan.Zero;
                    lblTrenutnoVrijeme.Text = "00:00:00:00";
                }
                if (datoteka != string.Empty)
                {
                    UcitajUkupnoVrijemeIzDatoteke();
                }
                ProvjeriZaglavlje();
            }
            else
            {
                MessageBox.Show("Prvo me zaustavi!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProvjeriZaglavlje()
        {
            if (postojiZaglavlje)
            {
                Onemoguci();
            }
            else
            {
                Omoguci();
            }
        }

        private void Onemoguci()
        {
            cmbPredmeti.Enabled = false;
            txtPredmetOstali.Enabled = false;
            cmbNaziv.Enabled = false;
            txtNazivOstalo.Enabled = false;
            txtZadatak.Enabled = true;
        }

        private void Omoguci()
        {
            cmbPredmeti.Enabled = true;
            cmbNaziv.Enabled = true;
            txtZadatak.Enabled = true;
        }

        private void btnKreni_Click(object sender, EventArgs e)
        {
            if (datoteka == null || datoteka.Length == 0)
            {
                MessageBox.Show("Prvo odaberi datoteku!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!pokrenuta)
            {
                pokrenuta = true;
                pocetak = DateTime.Now;
                trenutno = TimeSpan.Zero;

                timerTrenutnoVrijeme.Enabled = true;
                timerTrenutnoVrijeme.Interval = 1000;
                timerTrenutnoVrijeme.Start();
            }
            else
            {
                MessageBox.Show("Već štopam!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void UcitajUkupnoVrijemeIzDatoteke()
        {
            bool ispravnoUkupnoVrijeme = false;
            podaciIzDatoteke = ucitajSadrzajDatoteke();
            string ukupnoVrijeme = string.Empty;

            if (podaciIzDatoteke != string.Empty && podaciIzDatoteke.Length > 0)
            {
                ukupnoVrijeme = pronadiUkupnoVrijeme(podaciIzDatoteke);
                PostojiLiZaglavlje(podaciIzDatoteke);

                //ukupno vrijeme ne postoji u datoteki
                if (ukupnoVrijeme == null)
                {
                    ispravnoUkupnoVrijeme = false;
                }
                else if (ukupnoVrijeme.Length < 7)//mora biti >= 7 jer format 0:0:0:0 ima 7 znakova
                {
                    MessageBox.Show("Neispravna vrijednost ukupnog vremena!" +
                        "\nMijenjali ste datoteku, tj. vrijednost ukupnog vremena?!", "Pogreška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ispravnoUkupnoVrijeme = false;
                }
                else
                {
                    try
                    {
                        ukupno = TimeSpan.ParseExact(ukupnoVrijeme, "g", null);
                        sati = ukupno.Days * 24 + ukupno.Hours;
                        ispravnoUkupnoVrijeme = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Greška kod učitavanja ukupnog vremena iz datoteke!",
                            "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ispravnoUkupnoVrijeme = false;
                    }
                }
            }
            else
            {
                postojiZaglavlje = false;
            }
            if (!ispravnoUkupnoVrijeme)
            {
                ukupno = TimeSpan.Zero;
                ukupnoVrijeme = "00:00:00:00";
                sati = 0;
            }
            lblUkupnoVrijeme.Text = ukupnoVrijeme;
            lblSati.Text = sati.ToString();
        }

        private void PostojiLiZaglavlje(string podaciIzDatoteke)
        {
            int predmet = podaciIzDatoteke.LastIndexOf("PREDMET");
            int naslov = podaciIzDatoteke.LastIndexOf("NAZIV");
            satiPozicija = podaciIzDatoteke.IndexOf("SATI");

            if (predmet == -1 || naslov == -1 || satiPozicija == -1)
            {
                postojiZaglavlje = false;
            }
            else
            {
                postojiZaglavlje = true;
            }
        }

        private string ucitajSadrzajDatoteke()
        {
            string sadrzajDatoteke;
            try
            {
                sadrzajDatoteke = File.ReadAllText(datoteka, Encoding.UTF8);
                return sadrzajDatoteke;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška kod čitanja iz datoteke!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private string pronadiUkupnoVrijeme(string podaciIzDatoteke)
        {
            pozicijaPocetkaUkupnogVremena = podaciIzDatoteke.LastIndexOf("ukupno");

            if (pozicijaPocetkaUkupnogVremena != -1)
            {
                //moglo bi se staviti pozicijaPocetkaUkupnogVremena +=10 
                //jer je padding 10, tj od "u" do "0" (tj broj dana) je 10 znakova u datoteci
                //ali ako neko obrisi razmak u datoteci onda naravno nebu šljakalo
                int duljinaDatoteke = podaciIzDatoteke.Length;
                StringBuilder ukupnoVrijeme = new StringBuilder();
                char znak;

                for (int i = pozicijaPocetkaUkupnogVremena; i < duljinaDatoteke; i++)
                {
                    znak = podaciIzDatoteke[i];

                    if (char.IsDigit(znak) || znak == ':')
                    {
                        ukupnoVrijeme.Append(znak);
                    }
                }
                return ukupnoVrijeme.ToString();
            }
            else
            {
                return null;
            }
        }

        private void btnStani_Click(object sender, EventArgs e)
        {
            Zaustavi();
        }

        private void Zaustavi()
        {
            if (pokrenuta)
            {
                podaciIzDatoteke = ucitajSadrzajDatoteke();

                if (podaciIzDatoteke != string.Empty && podaciIzDatoteke.Length > 0)
                {
                    PostojiLiZaglavlje(podaciIzDatoteke);
                }
                else
                {
                    postojiZaglavlje = false;
                }
                ZapisiUDatoteku();
                pokrenuta = false;
            }
            else
            {
                MessageBox.Show("Prvo me pokreni!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void timerTrenutnoVrijeme_Tick(object sender, EventArgs e)
        {
            if (pokrenuta)
            {
                trenutno = trenutno.Add(TimeSpan.ParseExact("00:00:01", "g", null));
                string trenutnoFormatirano = trenutno.Days + ":" + trenutno.Hours + ":"
                    + trenutno.Minutes + ":" + trenutno.Seconds;
                lblTrenutnoVrijeme.Text = trenutnoFormatirano;

                ukupno = ukupno.Add(TimeSpan.ParseExact("00:00:01", "g", null));
                string ukupnoFormatirano = ukupno.Days + ":" + ukupno.Hours + ":"
                    + ukupno.Minutes + ":" + ukupno.Seconds;
                lblUkupnoVrijeme.Text = ukupnoFormatirano;

                sati = ukupno.Days * 24 + ukupno.Hours;
                lblSati.Text = sati.ToString();
            }
        }

        private void ZapisiUDatoteku()
        {
            kraj = DateTime.Now;
            StringBuilder zapis = new StringBuilder();
            string zadatak = txtZadatak.Text;

            if (!postojiZaglavlje)
            {
                zapis.AppendLine("============================");
                zapis.Append("PREDMET:".PadRight(10)).Append(odabraniPredmet);
                zapis.AppendLine();
                zapis.Append("NAZIV:".PadRight(10)).Append(odabraniNaziv);
                zapis.AppendLine();
                zapis.Append("SATI:".PadRight(10)).Append(sati);
                zapis.AppendLine();
                zapis.AppendLine("============================");
            }
            else
            {
                zapis = ZamjeniSate();
            }
            zapis.Append("ZADATAK".PadRight(10)).Append(zadatak);
            zapis.AppendLine();
            zapis.Append("početak".PadRight(10)).Append(pocetak);
            zapis.AppendLine();
            zapis.Append("kraj".PadRight(10)).Append(kraj);
            zapis.AppendLine();
            zapis.Append("trenutno".PadRight(10)).Append(trenutno.Days).Append(":").Append(trenutno.Hours).Append(":").Append(trenutno.Minutes).Append(":").Append(trenutno.Seconds);
            zapis.AppendLine();
            zapis.Append("ukupno".PadRight(10)).Append(ukupno.Days).Append(":").Append(ukupno.Hours).Append(":").Append(ukupno.Minutes).Append(":").Append(ukupno.Seconds);
            zapis.AppendLine();
            zapis.Append("****************************");
            zapis.AppendLine();

            try
            {
                File.WriteAllText(datoteka, zapis.ToString(), Encoding.UTF8);
                Onemoguci();
            }
            catch (Exception)
            {
                MessageBox.Show("Greška kod pisanja u datoteku!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private StringBuilder ZamjeniSate()
        {
            StringBuilder ubaceniSati = new StringBuilder(podaciIzDatoteke);
            int duljinaSati = 0;

            for (int i = satiPozicija + 10; i < ubaceniSati.Length; i++)
            {
                char znak = ubaceniSati[i];
                if (char.IsDigit(znak))
                {
                    duljinaSati++;
                }
                if (znak == '\r' || znak == '\n')
                {
                    break;
                }
            }
            ubaceniSati = ubaceniSati.Remove(satiPozicija + 10, duljinaSati);
            ubaceniSati = ubaceniSati.Insert(satiPozicija + 10, sati);
            return ubaceniSati;
        }

        private void Pocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ako nije pokrenuta vec je zapisano na stani_klik
            if (pokrenuta)
            {
                podaciIzDatoteke = ucitajSadrzajDatoteke();
                ZapisiUDatoteku();
            }
        }

        private void PromjenaStanja(object s, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Resume:
                    this.Show();
                    this.Focus();
                    MessageBox.Show("Ne zaboravi me pokrenuti!", "Štoperica - podsjetnik",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case PowerModes.Suspend:
                    if (pokrenuta)
                    {
                        Zaustavi();
                    }
                    break;
            }
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdrediPredmet();
        }

        private void cmbNaziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdrediNaziv();
        }

        private void OdrediNaziv()
        {
            odabraniNaziv = cmbNaziv.SelectedItem.ToString();
            if (odabraniNaziv.ToLower().Equals("ostalo"))
            {
                txtNazivOstalo.Enabled = true;
            }
            else
            {
                txtNazivOstalo.Enabled = false;
            }
        }
        private void OdrediPredmet()
        {
            odabraniPredmet = cmbPredmeti.SelectedItem.ToString();
            if (odabraniPredmet.ToLower().Equals("ostalo"))
            {
                txtPredmetOstali.Enabled = true;
            }
            else
            {
                txtPredmetOstali.Enabled = false;
            }
        }

        private void txtPredmetOstali_TextChanged(object sender, EventArgs e)
        {
            odabraniPredmet = txtPredmetOstali.Text;
        }

        private void txtNazivOstalo_TextChanged(object sender, EventArgs e)
        {
            odabraniNaziv = txtNazivOstalo.Text;
        }
    }
}
