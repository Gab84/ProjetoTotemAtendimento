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

            
            if(dataGrid_EmAtendimento_T.ColumnCount > 0)
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
                        atendimentoSelecionado.portaAtendido = TecnicoLogado.PortaAtual;
                        atendimentoSelecionado.TecnicoLogin = TecnicoLogado.login; // ou Nome, se for esse o campo usado

                        // Salvar no Firebase
                        await atendimentoDAO.AtualizarAtendimento(Conn.BDoor, atendimentoSelecionado);

                        // Atualizar interface
                        AtualizarTela(atendimentoDAO, Conn.BDoor);
                        //Batender.Enabled = false;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, selecione um atendimento pendente.");
                }


            }

            else
            {

                dataGrid_EmAtendimento_T.Enabled = false;

            }

            

                
        }

        private void DataGrid_Pendentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private async void AtualizarTela(AtendimentoDAO atendimentoDAO, FirebaseClient Conn)
        {
            
            var finalizados = await atendimentoDAO.GetAtendidos(Conn, TecnicoLogado);
            var pendentes = await atendimentoDAO.GetPendentes(Conn);
            var EmAtendimento = await atendimentoDAO.GetEmAtendimentoTecnico(Conn,TecnicoLogado);
            var prioritarios = await atendimentoDAO.GetPrioritarios(Conn,TecnicoLogado);


            DataGrid_Pendentes.DataSource = pendentes;
            dataGrid_atendidos.DataSource = finalizados;
            dataGrid_Prioritarios.DataSource = prioritarios;
            dataGrid_EmAtendimento_T.DataSource = EmAtendimento;



            //separa
            DataGrid_Pendentes.Columns[1].Width = 200;
            DataGrid_Pendentes.Columns[2].Visible = false;
            DataGrid_Pendentes.Columns[3].Visible = false;
            DataGrid_Pendentes.Columns[4].Visible = false;
            DataGrid_Pendentes.Columns[5].Visible = false;
            DataGrid_Pendentes.Columns[6].Visible = false;
            DataGrid_Pendentes.Columns[7].Visible = false;
            DataGrid_Pendentes.Columns[8].Visible = false;
            DataGrid_Pendentes.Columns[9].Visible = false;
            DataGrid_Pendentes.Columns[10].Visible = false;
            DataGrid_Pendentes.Columns[11].Visible = false;
            DataGrid_Pendentes.Columns["Datahora"].Visible = true;
            DataGrid_Pendentes.Columns["Datahora"].Width = 150;
            DataGrid_Pendentes.Font = new Font("Segoe UI", 12);

            //separa
            dataGrid_atendidos.Columns[1].Width = 200;
            dataGrid_atendidos.Columns[3].Visible = false;
            dataGrid_atendidos.Columns[2].Visible = false;
            dataGrid_atendidos.Columns[4].Visible = false;
            dataGrid_atendidos.Columns[5].Visible = false;
            dataGrid_atendidos.Columns[6].Visible = false;
            dataGrid_atendidos.Columns[7].Visible = false;
            dataGrid_atendidos.Columns[8].Visible = false;
            dataGrid_atendidos.Columns[9].Visible = false;
            dataGrid_atendidos.Columns[10].Visible = false;
            dataGrid_atendidos.Columns[11].Visible = false;
            dataGrid_atendidos.Columns["Datahora"].Visible = true;
            dataGrid_atendidos.Columns["Datahora"].Width = 150;
            dataGrid_atendidos.Font = new Font("Segoe UI", 12);

            //
            dataGrid_EmAtendimento_T.Columns[1].Width = 200;
            dataGrid_EmAtendimento_T.Columns[2].Visible = false;
            dataGrid_EmAtendimento_T.Columns[3].Visible = false;
            dataGrid_EmAtendimento_T.Columns[4].Visible = false;
            dataGrid_EmAtendimento_T.Columns[5].Visible = false;
            dataGrid_EmAtendimento_T.Columns[6].Visible = false;
            dataGrid_EmAtendimento_T.Columns[7].Visible = false;
            dataGrid_EmAtendimento_T.Columns[8].Visible = false;
            dataGrid_EmAtendimento_T.Columns[9].Visible = false;
            dataGrid_EmAtendimento_T.Columns[10].Visible = false;
            dataGrid_EmAtendimento_T.Columns[11].Visible = false;
            dataGrid_EmAtendimento_T.Columns["Datahora"].Visible = true;
            dataGrid_EmAtendimento_T.Columns["Datahora"].Width = 150;
            dataGrid_EmAtendimento_T.Font = new Font("Segoe UI", 12);



            if(dataGrid_EmAtendimento_T.RowCount > 0)
            {
                Batender.Enabled = false;

            }

            //dataGrid_EmAtendimento_T.DataSource = atendimento.GetEmAtendimentoTecnico(Conn,TecnicoLogado);


        }


        private void Tl_Tecnicos_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGrid_atendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_EmAtendimento_T_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FINALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGrid_EmAtendimento_T.SelectedRows.Count > 0)
                {
                    // Obter o item selecionado
                    var selectedRow = dataGrid_EmAtendimento_T.SelectedRows[0];
                    var atendimentoSelecionado = (Atendimento)selectedRow.DataBoundItem;

                    // Atualizar status e técnico
                    atendimentoSelecionado.Status = "finalizado";
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

            if(dataGrid_EmAtendimento_T.RowCount == 0)
            {

                dataGrid_EmAtendimento_T.Enabled = true;

            }

        }
    }
}
