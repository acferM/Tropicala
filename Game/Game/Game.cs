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
        int vez = 0;
        bool verifica;

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
            if (vez == 0)
            {
                nBotoes = NumeroDeBotoes(NumCalaB1);
                NumCalaB1.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

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

                        Captura(NumCalaB6, NumCalaA6);

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

                        verifica = true;
                        StillIsYourTurn("Player 1");
                        break;

                    case 7:
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

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 8:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 9:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 10:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 11:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 12:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 13:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 14:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 15:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setZero();
                    verifica = false;
                }
                else vez = 1;
            }
            else ErroPlayP2();
        }

        static int NumeroDeBotoes(Label txtNums)
        {
            int nBotoes = 0;

            nBotoes = int.Parse(txtNums.Text);

            return nBotoes;
        }

        private void MoverB2_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                nBotoes = NumeroDeBotoes(NumCalaB2);
                NumCalaB2.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 5:
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

                        StillIsYourTurn("Player 1");
                        break;

                    case 6:
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

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 7:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 8:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 9:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 10:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 11:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 12:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 13:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 14:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    case 15:
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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        vez = 1;
                        break;

                    default:
                        break;
                }
            }
            else ErroPlayP2();
        }

        private void MoverB3_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                nBotoes = NumeroDeBotoes(NumCalaB3);
                NumCalaB3.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 1");
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setZero();
                    verifica = false;
                }
                else vez =1;
            }
            else ErroPlayP2();
        }

        private void MoverB4_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                nBotoes = NumeroDeBotoes(NumCalaB4);
                NumCalaB4.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 1");
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setZero();
                    verifica = false;
                }
                else vez = 1;
            }
            else ErroPlayP2();
        }

        private void MoverB5_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                nBotoes = NumeroDeBotoes(NumCalaB5);
                NumCalaB5.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 1");
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        verifica = true;
                        StillIsYourTurn("Player 1");
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setZero();
                    verifica = false;
                }
                else vez = 1;
            }
            else ErroPlayP2();
        }

        private void MoverB6_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                nBotoes = NumeroDeBotoes(NumCalaB6);
                NumCalaB6.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 1");
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        verifica = true;
                        StillIsYourTurn("Player 1");
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setZero();
                    verifica = false;
                }
                else vez = 1;
            }
            else ErroPlayP2();
        }

        private void MoverA1_Click(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                nBotoes = NumeroDeBotoes(NumCalaA1);
                NumCalaA1.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setOne();
                    verifica = false;
                }
                else vez = 0;
            }
            else ErroPlayP1();
        }

        private void MoverA2_Click(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                nBotoes = NumeroDeBotoes(NumCalaA2);
                NumCalaA2.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setOne();
                    verifica = false;
                }
                else vez = 0;
            }
            else ErroPlayP1();
        }

        private void MoverA3_Click(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                nBotoes = NumeroDeBotoes(NumCalaA3);
                NumCalaA3.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP1.Text) + 1;
                        NumCalaPrincipalP1.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setOne();
                    verifica = false;
                }
                else vez = 0;
            }
            else ErroPlayP1();
        }

        private void MoverA4_Click(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                nBotoes = NumeroDeBotoes(NumCalaA4);
                NumCalaA4.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setOne();
                    verifica = false;
                }
                else vez = 0;
            }
            else ErroPlayP1();
        }

        private void MoverA5_Click(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                nBotoes = NumeroDeBotoes(NumCalaA5);
                NumCalaA5.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        Captura(NumCalaA6, NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setOne();
                    verifica = false;
                }
                else vez = 0;
            }
            else ErroPlayP1();
        }

        private void MoverA6_Click(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                nBotoes = NumeroDeBotoes(NumCalaA6);
                NumCalaA6.Text = "         0";

                switch (nBotoes)
                {
                    case 1:
                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 2:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();
                        break;

                    case 3:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        Captura(NumCalaA3, NumCalaB3);

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();
                        break;

                    case 4:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        Captura(NumCalaA2, NumCalaB2);

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();
                        break;

                    case 5:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        Captura(NumCalaA1, NumCalaB1);

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();                      
                        break;

                    case 6:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        verifica = true;
                        StillIsYourTurn("Player 2");
                        break;

                    case 7:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        Captura(NumCalaB1, NumCalaA1);

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();
                        break;

                    case 8:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        Captura(NumCalaB2, NumCalaA2);

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();
                        break;

                    case 9:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        Captura(NumCalaB3, NumCalaA3);

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();
                        break;

                    case 10:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB4, NumCalaA4);

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();
                        break;

                    case 11:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        Captura(NumCalaB5, NumCalaA5);

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();
                        break;

                    case 12:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB5.Text) + 1;
                        NumCalaB5.Text = nAlterar.ToString();

                        Captura(NumCalaB6, NumCalaA6);

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();
                        break;

                    case 13:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        Captura(NumCalaA6,NumCalaB6);

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();
                        break;

                    case 14:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB2.Text) + 1;
                        NumCalaB2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB3.Text) + 1;
                        NumCalaB3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB4.Text) + 1;
                        NumCalaB4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB6.Text) + 1;
                        NumCalaB6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        Captura(NumCalaA5, NumCalaB5);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    case 15:
                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA4.Text) + 1;
                        NumCalaA4.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA3.Text) + 1;
                        NumCalaA3.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA2.Text) + 1;
                        NumCalaA2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA1.Text) + 1;
                        NumCalaA1.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaPrincipalP2.Text) + 1;
                        NumCalaPrincipalP2.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaB1.Text) + 1;
                        NumCalaB1.Text = nAlterar.ToString();

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

                        nAlterar = int.Parse(NumCalaA6.Text) + 1;
                        NumCalaA6.Text = nAlterar.ToString();

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();

                        Captura(NumCalaA4, NumCalaB4);

                        nAlterar = int.Parse(NumCalaA5.Text) + 1;
                        NumCalaA5.Text = nAlterar.ToString();
                        break;

                    default:
                        break;
                }

                if (verifica)
                {
                    vez = setOne();
                    verifica = false;
                }
                else vez = 0;
            }
            else ErroPlayP1();
        }

        void ErroPlayP2()
        {
            MessageBox.Show("é a vez do player 2 jogar", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ErroPlayP1()
        {
            MessageBox.Show("é a vez do player 1 jogar", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void StillIsYourTurn(string player)
        {
            MessageBox.Show("Ainda é seu turno " + player);
        }

        int setZero()
        {
            return 0;
        }

        int setOne()
        {
            return 1;
        }

        void Captura(Label numeroDePeças, Label numeroDePeçasOposto)
        {
            int soma;
            if (numeroDePeças.Text == "0")
            {
                soma = int.Parse(numeroDePeçasOposto.Text) + 1;
                MessageBox.Show("Você realizou uma captura e ira pegar a ultima peça que ira colocar\ne as da cala oposta do seu oponente", "Captura", MessageBoxButtons.OK);

                if (numeroDePeças.Name.StartsWith("NumCalaB")) NumCalaPrincipalP1.Text = soma.ToString();
                else NumCalaPrincipalP2.Text = soma.ToString();

                numeroDePeças.Text = "-1";
                numeroDePeçasOposto.Text = "0";
            }
        }
    }
}
