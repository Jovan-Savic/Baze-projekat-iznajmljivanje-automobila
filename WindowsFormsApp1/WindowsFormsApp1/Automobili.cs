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
    public partial class Automobili : Form
    {

        DataTable ugovori = new DataTable();
        public Automobili()
        {
            InitializeComponent();
        }

        private void Automobili_Load(object sender, EventArgs e)
        {
            ProizvodjacPopulate();
            GridPop();
        }
        private void ProizvodjacPopulate()
        {
            SqlConnection veza = Konekcija.Povezi();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Automobil", veza);
            DataTable proi = new DataTable();
            adapter.Fill(proi);
            Proizvodjac.DataSource = proi;
            Proizvodjac.ValueMember = "id";
            Proizvodjac.DisplayMember = "model";
            Proizvodjac.SelectedValue = 3;
        }
        private void GridPop()
        {
            SqlConnection veza = Konekcija.Povezi();
            ugovori = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Ugovor.id, ime as Poslodavac, model as Auto, imekl as ImeKlijenta, prezimekl as PrezimeKlijenta, jmbgkl as JMBGKlijenta, od as Datumuzimanja, do as Datumvracanja,cena* DATEDIFF(DAY, od,do) as Cena from Ugovor LEFT JOIN Osoba ON id_osobe = Osoba.id LEFT JOIN Automobil ON id_automobil = Automobil.id", veza);
            adapter.Fill(ugovori);
            Grid_Ocene.DataSource = null;
            Grid_Ocene.DataSource = ugovori;
            Grid_Ocene.AllowUserToAddRows = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Povezi();

            StringBuilder naredba = new StringBuilder("INSERT INTO Ugovor VALUES ('");
            naredba.Append(Program.user_id.ToString() + "','");
            naredba.Append(Proizvodjac.SelectedValue.ToString() + "','");
            naredba.Append(Ime.Text + "','");
            naredba.Append(Prezime.Text + "','");
            naredba.Append(Jmbg.Text + "','");
            naredba.Append(Od.Value.ToString("yyyy-MM-dd") + "','");
            naredba.Append(Do.Value.ToString("yyyy-MM-dd") + "','");
            naredba.Append(Cena.Text + "')");
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            GridPop();
        }

        private void UcenikOcenaIdSet(int broj_sloga)
        {

        }
        private void Grid_Ocene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((int)e.RowIndex > 0) { 
            txt_id.Text = ugovori.Rows[(int)e.RowIndex]["id"].ToString();}
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txt_id.Text) > 0)
            {
                SqlConnection veza = Konekcija.Povezi();

                StringBuilder naredba = new StringBuilder("UPDATE Ugovor WHERE Ugovor.id=" + txt_id.Text + " SET ");
                naredba.Append(" id_osobe =' " + Program.user_id.ToString() + "','");
                naredba.Append(" id_automobil =' " + Proizvodjac.SelectedValue.ToString() + "','");
                naredba.Append(" imekl =' " + Ime.Text + "','");
                naredba.Append(" prezimekl =' " + Prezime.Text + "','");
                naredba.Append(" jmbgkl =' " + Jmbg.Text + "','");
                naredba.Append(" od =' " + Od.Value.ToString("yyyy-MM-dd") + "','");
                naredba.Append(" do =' " + Do.Value.ToString("yyyy-MM-dd") + "','");
                naredba.Append(" cena =' " + Cena.Text + "'");
                SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close(); 
                    GridPop();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }  
               
            }
          

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) > 0)
            {
                string naredba = "DELETE FROM Ugovor WHERE id = " + txt_id.Text;
                SqlConnection veza = Konekcija.Povezi();
                SqlCommand Komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                    GridPop();
                    txt_id.Text = "0";
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}
