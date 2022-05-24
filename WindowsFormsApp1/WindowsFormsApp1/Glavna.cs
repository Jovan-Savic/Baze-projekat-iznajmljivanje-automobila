using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            string user = Program.user_ime + " " + Program.user_prezime;
            label1.Text = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Automobili auti = new Automobili();
            auti.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forna a = new Forna();
            a.Show();
        }
    }
}
