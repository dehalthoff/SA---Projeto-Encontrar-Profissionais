﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA___Projeto_Encontrar_Profissionais
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == string.Empty || txtBoxLogin.Text == null || txtBoxSenha.Text == string.Empty || txtBoxSenha.Text == null)
            {
                lblAtencao.Visible = true;
                return;
            }
        }
    }
}
