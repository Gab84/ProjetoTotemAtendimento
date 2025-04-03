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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void bt_problema_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void bt_chamado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste2");
        }

        private void bt_etiqueta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste3");
        }

        private void bt_requisicao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste5");
        }

        private void bt_incidente_Click(object sender, EventArgs e)
        {

        }
    }
}
