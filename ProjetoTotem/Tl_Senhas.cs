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
using Firebase.Database.Query;

namespace ProjetoTotem
{
    public partial class Tl_Senhas: Form
    {

        //FBConnector conn;
       // private readonly FirebaseService firebase;
        public Tl_Senhas()
        {
            InitializeComponent();
            FirebaseClient _firebase = new FirebaseClient("https://totematendimento-78bc9-default-rtdb.firebaseio.com/");
            //FBConnector conn = new FBConnector();
            
            AtualizarTela(_firebase);
        }

        
        public async Task<List<Atendimento>> ListarAtendimentos(FirebaseClient _firebase)
        {
            
            var result = await _firebase
                .Child("ATENDIMENTO")
                .OnceAsync<Atendimento>();

            return result.Select(item => item.Object).ToList();
        }

        public async Task<List<Atendimento>> GetFinalizados(FirebaseClient _firebase) =>
           (await ListarAtendimentos(_firebase)).Where(a => a.Status == "finalizado").ToList();
        

        public async Task<Atendimento> GetEmAtendimento(FirebaseClient _firebase) =>
            (await ListarAtendimentos(_firebase)).FirstOrDefault(a => a.Status == "em_atendimento");

        public async Task<Atendimento> GetProximoNaFila(FirebaseClient _firebase) =>
            (await ListarAtendimentos(_firebase)).Where(a => a.Status == "em_espera")
                                        .OrderBy(a => a.Datahora).FirstOrDefault();
    

        private async Task AtualizarTela(FirebaseClient _firebase)
        {
            var emAtendimento = await GetEmAtendimento(_firebase);
            var proximo = await GetProximoNaFila(_firebase);
            var finalizados = await GetFinalizados(_firebase);

            numSenha.Text = emAtendimento?.Id ?? "Nenhum";
            //labelProximo.Text = proximo?.Id ?? "Nenhum";
            dataGridView1.DataSource = finalizados;
        }





        private void Tl_Senhas_Load(object sender, EventArgs e)
        {
            Texts_to_load();
        }

        private void Texts_to_load()
        {


            numSenha.Text = "1";

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
            
        }

        private void numSenha_click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numSenha_Click_1(object sender, EventArgs e)
        {

        }
    }
}
