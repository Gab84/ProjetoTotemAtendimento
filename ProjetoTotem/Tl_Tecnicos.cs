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
    public partial class Tl_Tecnicos : Form
    {
        private FBConnector Conn;
        private AtendimentoDAO atendimentoDAO;
        private Tecnico TecnicoLogado;

        public Tl_Tecnicos(Tecnico UserTecnico)
        {
            InitializeComponent();
            this.Conn = new FBConnector();
            this.atendimentoDAO = new AtendimentoDAO();
            TecnicoLogado = UserTecnico;

            AtualizarTela(atendimentoDAO, Conn.BDoor);
        }


        private async void Batender_Click(object sender, EventArgs e)
        {

            try
            {
                if (DataGrid_Pendentes.SelectedRows.Count > 0)
                {
                    // Obter o item selecionado
                    var selectedRow = DataGrid_Pendentes.SelectedRows[0];
                    var atendimentoSelecionado = (Atendimento)selectedRow.DataBoundItem;

                    // Atualizar status e técnico
                    atendimentoSelecionado.Status = "Em_atendimento";
                    atendimentoSelecionado.TecnicoLogin = TecnicoLogado.login; // ou Nome, se for esse o campo usado

                    // Salvar no Firebase
                    await atendimentoDAO.AtualizarAtendimento(Conn.BDoor, atendimentoSelecionado);

                    // Atualizar interface
                    AtualizarTela(atendimentoDAO, Conn.BDoor);
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Por favor, selecione um atendimento pendente.");
            }

            

                
        }

        private void DataGrid_Pendentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void AtualizarTela(AtendimentoDAO atendimentoDAO, FirebaseClient Conn)
        {

            var finalizados = await atendimentoDAO.GetAtendidos(Conn, TecnicoLogado);
            var pendentes = await atendimentoDAO.GetPendentes(Conn);
            var EmAtendimento = await atendimentoDAO.GetEmAtendimentoTecnico(Conn,TecnicoLogado);//
            var prioritarios = await atendimentoDAO.GetPrioritarios(Conn,TecnicoLogado);


            DataGrid_Pendentes.DataSource = pendentes;
            dataGrid_atendidos.DataSource = finalizados;
            dataGrid_Prioritarios.DataSource = prioritarios;
            
            //dataGrid_EmAtendimento_T.DataSource = atendimento.GetEmAtendimentoTecnico(Conn,TecnicoLogado);

            
        }


        private void Tl_Tecnicos_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGrid_atendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
