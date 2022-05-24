using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == " " || txt_passw.Text == " ")
            {
                MessageBox.Show("Molimo unesite sve podatke!");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Povezi();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM osoba where email =@username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (string.Compare(tabela.Rows[0]["sifra"].ToString(), txt_passw.Text) == 0)
                        {
                            MessageBox.Show("Uspesna prijava!");
                            Program.user_id = (int)tabela.Rows[0]["id"];
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            this.Hide();
                            Glavna frm_glavna = new Glavna();
                            frm_glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Losa sifra!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nepostojeca email adresa!");
                    }

                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
