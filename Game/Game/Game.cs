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
    public partial class Game : Form
    {
        int nBotoes;
        int nAlterar;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            var telaMenu = new Menu();
            telaMenu.Show();
        }

        private void MoverB1_Click(object sender, EventArgs e)
        {
            nBotoes = NumeroDeBotoes(NumCalaB1);
            NumCalaB1.Text = "         0";

            switch (nBotoes)
            {
                case 1:
                    nAlterar = int.Parse(NumCalaB2.Text) + 1;
                    NumCalaB2.Text = nAlterar.ToString();
                    break;

                case 2:
                    nAlterar = int.Parse(NumCalaB2.Text) + 1;
                    NumCalaB2.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB3.Text) + 1;
                    NumCalaB3.Text = nAlterar.ToString();
                    break;

                case 3:
                    nAlterar = int.Parse(NumCalaB2.Text) + 1;
                    NumCalaB2.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB3.Text) + 1;
                    NumCalaB3.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB4.Text) + 1;
                    NumCalaB4.Text = nAlterar.ToString();
                    break;

                case 4:
                    nAlterar = int.Parse(NumCalaB2.Text) + 1;
                    NumCalaB2.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB3.Text) + 1;
                    NumCalaB3.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB4.Text) + 1;
                    NumCalaB4.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB5.Text) + 1;
                    NumCalaB5.Text = nAlterar.ToString();
                    break;

                case 5:
                    nAlterar = int.Parse(NumCalaB2.Text) + 1;
                    NumCalaB2.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB3.Text) + 1;
                    NumCalaB3.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB4.Text) + 1;
                    NumCalaB4.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB5.Text) + 1;
                    NumCalaB5.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB6.Text) + 1;
                    NumCalaB6.Text = nAlterar.ToString();
                    break;

                case 6:
                    nAlterar = int.Parse(NumCalaB2.Text) + 1;
                    NumCalaB2.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB3.Text) + 1;
                    NumCalaB3.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB4.Text) + 1;
                    NumCalaB4.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB5.Text) + 1;
                    NumCalaB5.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaB6.Text) + 1;
                    NumCalaB6.Text = nAlterar.ToString();

                    nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                    NumCalaPrincipalP1.Text = nAlterar.ToString();
                    break;

                default:
                    break;
            }
        }

        static int NumeroDeBotoes(Label txtNums)
        {
            int nBotoes = 0;

            nBotoes = int.Parse(txtNums.Text);

            return nBotoes;
        }
    }
}
