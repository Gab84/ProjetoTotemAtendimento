﻿using System;
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
