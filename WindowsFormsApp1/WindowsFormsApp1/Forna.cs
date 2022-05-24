using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Forna : Form
    {
        int broj_sloga = 0;
        DataTable tabela;

        public Forna()
        {
            InitializeComponent();
        }
        private void Ucitaj_Podatke()
        {
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Automobil", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);

            DataTable tabelce = new DataTable();
            adapter = new SqlDataAdapter("Select * from Proizvodjac",veza);
            adapter.Fill(tabelce);
            Proiz.DataSource = tabelce;
            Proiz.ValueMember = "id";
            Proiz.DisplayMember = "naziv";
        }
        private void Txt_Ucitaj()
        {
            if (tabela.Rows.Count != 0)
            {
                txt_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_model.Text = tabela.Rows[broj_sloga]["model"].ToString();
                Proiz.SelectedValue = tabela.Rows[broj_sloga]["id_proizvodjaca"].ToString();
                 dateTimePicker1.Value = DateTime.Parse(tabela.Rows[broj_sloga]["adresa"].ToString());
                dateTimePicker2.Value = DateTime.Parse(tabela.Rows[broj_sloga]["jmbg"].ToString());

                btn_obrisi.Enabled = true;
                if (broj_sloga == 0)
                {
                    btn_prvi.Enabled = false;
                    btn_prethodni.Enabled = false;
                }
                else
                {
                    btn_prvi.Enabled = true;
                    btn_prethodni.Enabled = true;
                }

                if (broj_sloga == tabela.Rows.Count - 1)
                {
                    btn_poslednji.Enabled = false;
                    btn_sledeci.Enabled = false;
                }
                else
                {
                    btn_poslednji.Enabled = true;
                    btn_sledeci.Enabled = true;
                }
            }
            else
            {
                txt_id.Text = "";
                txt_model.Text = "";

                btn_prvi.Enabled = false;
                btn_prethodni.Enabled = false;
                btn_poslednji.Enabled = false;
                btn_sledeci.Enabled = false;
                btn_izmeni.Enabled = false;
                btn_obrisi.Enabled = false;
            }
        }
        private void Forna_Load(object sender, EventArgs e)
        {
            Ucitaj_Podatke();
            Txt_Ucitaj();
        }

        private void btn_prvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Ucitaj();
        }

        private void btn_prethodni_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Ucitaj();
        }

        private void btn_sledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Ucitaj();
        }

        private void btn_poslednji_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Ucitaj();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            Ucitaj_Podatke();
            Txt_Ucitaj();
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM Automobil WHERE id = " + txt_id.Text;
            //MessageBox.Show(naredba.ToString());
            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            if (brisano)
            {
                Ucitaj_Podatke();
                if (broj_sloga > 0) broj_sloga--;

                Txt_Ucitaj();
            }
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE Automobil SET ");
            naredba.Append("id_proizvodjaca = '" + Proiz.SelectedValue + "', ");
            naredba.Append("model = '" + txt_model.Text + "', ");
            naredba.Append("registracija = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', ");
            naredba.Append("godiste = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', ");
            naredba.Append("WHERE id = " + txt_id.Text);
            //MessageBox.Show(naredba.ToString());
            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            Txt_Ucitaj();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("Insert into Automobil Values(' ");
            naredba.Append(Proiz.SelectedValue + "', ");
            naredba.Append(txt_model.Text + "', ");
            naredba.Append(dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', ");
            naredba.Append(dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', ");
            naredba.Append(txt_id.Text);
            //MessageBox.Show(naredba.ToString());
            SqlConnection veza = Konekcija.Povezi();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Ucitaj();
        }
    }
}
