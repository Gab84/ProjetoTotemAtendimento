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
            Texts_to_load();
        }

        private void Texts_to_load()
        {

            Tsenha.Text = "SENHA";
            numSenha.Text = "490";
            tipoSenha.Text = "NORMAL";
            portaAtendimento.Text = "PORTA A";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
