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
    public partial class Tl_Login : Form
    {
        public string login;
        public string senha;
        public Tl_Login()
        {
            InitializeComponent();
        }

        private void Tl_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Blogin_Click(object sender, EventArgs e)
        {
            login = TBusuario.Text;
            senha = TBsenha.Text;

            /* a partir desse ponto é nescessario que aja um tratamento de verificação das credenciais pelo TecnicoDAO,para que seja confirmado o login!
            Com a confirmação do login é nescessario que o objeto tecnicoDAO puxe de banco os dados do tecnico logado em questão como:nome,id e status

            */
            this.Close();

            
        }

        private void TBusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
