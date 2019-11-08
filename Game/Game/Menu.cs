using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            var jogoTela = new Game();
            jogoTela.Show();

            this.Hide();
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            var creditosTela = new Creditos();
            creditosTela.Show();

            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
