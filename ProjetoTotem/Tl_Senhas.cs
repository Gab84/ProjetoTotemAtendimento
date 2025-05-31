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
        private Atendimento atendimentoAtual_1 = new Atendimento();
        private Atendimento atendimentoAtual_2 = new Atendimento();

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
            List<Atendimento> EmAtendimento = new List<Atendimento>();

            var pendentes = await  atendimentoDAO.GetPendentes(Conn.BDoor); //GetEmAtendimento(_firebase);
                                                                            // var proximo = await GetProximoNaFila(Conn,atendimentoDAO);  --> esse "Proximo na fila"
                                                                            //var finalizados = await atendimentoDAO.GetFinalizados(Coon.BDoor);//GetFinalizados(_firebase);
            

            EmAtendimento = await atendimentoDAO.GetEmAtendimento(Coon.BDoor);
            numSenha.Text = EmAtendimento[0].Id;  //emEspera[0].Id.ToString();
            numSenha2.Text = EmAtendimento[1].Id ;


            if (EmAtendimento[0].portaAtendido == "Porta_A")
            {
                NumSenhaPA.Text = EmAtendimento[0].Id;
                NumSenhaPB.Text = EmAtendimento[1].Id;

            }

            else
            {
                NumSenhaPA.Text = EmAtendimento[1].Id;
                NumSenhaPB.Text = EmAtendimento[0].Id;

            }

            // Para que o  codigo acima funcione corretamente assume-se que havera apenas dois atendimentos com status "em_atendimento" no banco e que ambos estarão separados por 
            // Porta_A e Porta_B, isso não é o caso atualmente pois não a nenhum filtro de input posto no sistema de login para impedir que dois tecnicos
            // selecionem a opção de estarem na porta A por exemplo!
            
            //Alem disso tambem não há nenhum mecanismo atualmente que impeça que o tecnico selecione para atender mais que um chamado!


            //SystemSounds.Exclamation.Play();
            //labelProximo.Text = proximo?.Id ?? "Nenhum";
            dataGridView1.DataSource = pendentes;
            //contador++;

        }





        private void Tl_Senhas_Load(object sender, EventArgs e)
        {
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
