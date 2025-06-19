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
   
    public partial class Tl_Requisicao: Form
    {
        private FBConnector Coon = new FBConnector();
        private AtendimentoDAO atendimentoDAO = new AtendimentoDAO();
        public Tl_Requisicao()
        {
            InitializeComponent();
            DropBoxFiller(Coon, atendimentoDAO);
        }

        private async Task DropBoxFiller(FBConnector Coon, AtendimentoDAO atendimentoDAO)
        {
            List<Atendimento> atendimentos = new List<Atendimento>();

            atendimentos = await atendimentoDAO.GetFinalizados(Coon.BDoor);

            DBrequisicoes.BeginUpdate();
            try
            {

                if (atendimentos.Count > 0)
                {

                    for (int i = 1; i < atendimentos.Count; i++)
                    {
                        DBrequisicoes.Items.Add(atendimentos[i].Id);

                    }

                }

            }
            finally
            {

                DBrequisicoes.EndUpdate();

            }
        }

        private async void StatusRequisicao()
        {
            Atendimento atendimentoSelecionado = new Atendimento();
            atendimentoSelecionado = await atendimentoDAO.GetFinalizadosEspecifico(Coon.BDoor, DBrequisicoes.SelectedItem.ToString());
            TBstatus.Text = atendimentoSelecionado.Status;
        }

        private async void MudarStatus(FBConnector Coon)
        {
            Atendimento atendimentoSelecionado = new Atendimento();
            atendimentoSelecionado = await atendimentoDAO.GetFinalizadosEspecifico(Coon.BDoor, DBrequisicoes.SelectedItem.ToString());

            atendimentoSelecionado.Status = "Prioritario";
            await atendimentoDAO.AtualizarAtendimento(Coon.BDoor, atendimentoSelecionado);


        }

        private void DBrequisicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            StatusRequisicao();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DBrequisicoes.SelectedItem != null)
            {

                MudarStatus(Coon);
                MessageBox.Show("A REQUISIÇÃO ESTA EM PRIORIDADE NA FILA!");
                this.Close();
                
            }
            else
            {

                MessageBox.Show("SELECIONE A REQUISIÇÃO");

            }


        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    

}
