using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTotem
{
    public partial class Tl_Senhas: Form
    {
        public Tl_Senhas()
        {
            InitializeComponent();
        }

        private void Tl_Senhas_Load(object sender, EventArgs e)
        {
            Tsenha.Text = "SENHA";
            numSenha.Text = "490";
            tipoSenha.Text = "Porta A";
        }

        

        private void BackGround_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void TituloSenhas_click(object sender, EventArgs e)
        {
            Tsenha.Text = "mudeis";
        }

        private void numSenha_click(object sender, EventArgs e)
        {

        }
    }
}
