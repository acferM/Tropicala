﻿using System;
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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void Creditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            var telaMenu = new Menu();
            telaMenu.Show();
        }

        private void Creditos_Load(object sender, EventArgs e)
        {

        }
    }
}
