using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace ProjetoTotem
{
    public partial class Tl_Senhas: Form
    {

        private FBConnector Conn = new FBConnector();
        private AtendimentoDAO atendimentoDAO = new AtendimentoDAO();
        int contador = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Atendimento atendimentoAtual = new Atendimento();

        public Tl_Senhas()
        {
            InitializeComponent();
          
            AtualizarTela(Conn);

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timerTick);
            timer.Start();
            //TimerStarter();
        }

        private void TimerStarter()
        {          
        }

        private void timerTick(object sender, EventArgs e)
        {

            AtualizarTela(Conn);
            

        }

        /*
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



       */

        public async Task<Atendimento> GetProximoNaFila(FBConnector Conn,AtendimentoDAO atendimentoDAO) =>
            (await atendimentoDAO.ListarAtendimentos(Conn.BDoor)).Where(a => a.Status == "em_espera")
                                        .OrderBy(a => a.Datahora).FirstOrDefault();


        private async Task AtualizarTela(FBConnector Coon)
        {
            
            
            var pendentes = await  atendimentoDAO.GetPendentes(Conn.BDoor); //GetEmAtendimento(_firebase);
            // var proximo = await GetProximoNaFila(Conn,atendimentoDAO);  --> esse "Proximo na fila"
            //var finalizados = await atendimentoDAO.GetFinalizados(Coon.BDoor);//GetFinalizados(_firebase);
            
            atendimentoAtual = await atendimentoDAO.GetEmAtendimento(Conn.BDoor);
            numSenha.Text = atendimentoAtual.Id;  //emEspera[0].Id.ToString();
            //SystemSounds.Exclamation.Play();
            //labelProximo.Text = proximo?.Id ?? "Nenhum";
            dataGridView1.DataSource = pendentes;
            //contador++;

        }





        private void Tl_Senhas_Load(object sender, EventArgs e)
        {
            Texts_to_load();
        }

        private void Texts_to_load()
        {


            numSenha.Text = "";

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

        private void Tl_Senhas_FormClosing(object sender, FormClosingEventArgs e)
        {

            timer.Stop();

        }

    }
}
