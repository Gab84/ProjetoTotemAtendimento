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
        public string InputLogin;
        public string InputSenha;
        private TecnicoDAO tecnicoDAO = new TecnicoDAO();
        private FBConnector Coon = new FBConnector();
        public Tecnico UserTecnico = new Tecnico();

        public Tl_Login()
        {
            InitializeComponent();

        }

        private void Tl_Login_Load(object sender, EventArgs e)
        {
            
        }



        private async void LGChecker(TecnicoDAO tecnicoDAO, FBConnector Coon, string InputLogin, string InputSenha)
        {

            try
            {

                UserTecnico = await tecnicoDAO.LoginChecker(Coon.BDoor, InputLogin, InputSenha);
                
                if (UserTecnico.Nome == null)
                {
                    throw new Exception();
                }
 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuario ou senha incorretos");
                TBusuario.Text = string.Empty;
                TBsenha.Text = string.Empty;

            }



        }


        private void Blogin_Click(object sender, EventArgs e)
        {
            InputLogin = TBusuario.Text;
            InputSenha = TBsenha.Text;

            LGChecker(tecnicoDAO, Coon, InputLogin, InputSenha);
            
            if (UserTecnico.login != null)
            {
                
                var Porta = MessageBox.Show("Em qual Porta Voce esta atendendo?","selecione a porta!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                
                if (Porta == DialogResult.Yes)
                {
                    UserTecnico.PortaAtual = "Porta_A";

                }
                else if(Porta == DialogResult.No)
                {

                    UserTecnico.PortaAtual = "Porta_B";

                }

                
                    this.Close();

            }
           
            
        }

        private void TBusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
