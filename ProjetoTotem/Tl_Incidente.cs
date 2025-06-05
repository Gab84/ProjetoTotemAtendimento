using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;

namespace ProjetoTotem
{
    public partial class Tl_Incidente: Form
    {
        AtendimentoDAO atendimentoDAO = new AtendimentoDAO();
        private FBConnector Coon = new FBConnector();
        private TecnicoDAO tecnicoCadastro = new TecnicoDAO();
        public Tl_Incidente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //acertar os valores
            var random = new Random();
            string senha = "ATD" + random.Next(1, 9999);
            DateTime dataAtual = DateTime.Now;

            atendimentoDAO.Id = senha;

            if(TBemail.Text != "" & TBnumero.Text != "" & TBpatrimonio.Text != "" )
            {

                atendimentoDAO.UsuarioEmail = TBemail.Text;
                atendimentoDAO.Num_incidente = TBnumero.Text;
                atendimentoDAO.Patrimonio_Maq = TBpatrimonio.Text;
                atendimentoDAO.UsuarioNome = "testeatendimento";
                atendimentoDAO.Status = "pendente";
                atendimentoDAO.Datahora = dataAtual.ToString("g");
                atendimentoDAO.Patrimonio_Maq = TBpatrimonio.Text;
                atendimentoDAO.CadastrarAtendimento(atendimentoDAO, Coon.BDoor);
                //MessageBox.Show("GERADO TESTE");
                MessageBox.Show($"A senha para o seu atendimento é:{senha}");

                

            }
            else
            {

                MessageBox.Show("Alguns campos não foram preenchidos!");

            }

                      

        }

        private void Tl_Incidente_Load(object sender, EventArgs e)
        {

        }
    }
}
