using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class telaLogin : Form
    {
        pro_chefeEntities8 bd = new pro_chefeEntities8();
        public static usuario logado = new usuario();
        public telaLogin()
        {
            InitializeComponent();
            btnLogar.Click += logar;
            cboxMostrarSenha.Click += caixa1; 
        }
        
        private void caixa1(object sender, EventArgs e)
        {
            if (cboxMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
        private void logar (object sender, EventArgs e)
        {
            logado = bd.usuario.Where(u => u.login.Equals(txtLogin.Text) && u.senha.Equals(txtSenha.Text)).FirstOrDefault();

            if (logado != null)
            {
                new telaPosLogin().Show();
                this.Hide();
            }   
            else
            {
                MessageBox.Show("Login inválido");
            }
            /* = SELECT * FROM usuario
            *bd.ususario.ToList().ForEach(u =>
           * {
               * MessageBox.Show(u.nome);
            });*/
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
