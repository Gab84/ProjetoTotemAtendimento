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
        FirebaseClient _firebase = new FirebaseClient("https://totematendimento-78bc9-default-rtdb.firebaseio.com/");
        public Tl_Incidente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //acertar os valores
            var random = new Random();
            string senha = "ATD" + random.Next(1, 9999);
            atendimentoDAO.UsuarioNome = "testeatendimento";
            atendimentoDAO.Id = senha;
            atendimentoDAO.Status = "pendente"; // Em_atendimento - finalizado - pendente
            atendimentoDAO.TecnicoLogin = "";
            //atendimentoDAO.Prioridade = "Prioritario";
            atendimentoDAO.CadastrarAtendimento(atendimentoDAO, _firebase);
            MessageBox.Show("GERADO TESTE");

        }

        private void Tl_Incidente_Load(object sender, EventArgs e)
        {

        }
    }
}
