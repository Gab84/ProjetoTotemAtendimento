﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTotem
{
   
    public partial class Form1: Form
    {

        private Tecnico UserTecnico;
        public Form1()
        {
            InitializeComponent();
            UserTecnico = new Tecnico();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void bt_problema_Click(object sender, EventArgs e)
        {
            
            Tl_Incidente TelaIncidente = new Tl_Incidente();
            TelaIncidente.Show();
        }

        private void bt_chamado_Click(object sender, EventArgs e)
        {
            
            Tl_Chamado TelaChamado = new Tl_Chamado();
            TelaChamado.Show();
        }

        private void bt_etiqueta_Click(object sender, EventArgs e)
        {
            
            Tl_Etiqueta TelaEtiqueta = new Tl_Etiqueta();
            TelaEtiqueta.Show();
        }

        private void bt_requisicao_Click(object sender, EventArgs e)
        {
            Tl_Requisicao TelaRequisicao = new Tl_Requisicao();
            TelaRequisicao.Show();
        }

        private void bt_incidente_Click(object sender, EventArgs e)
        {
            
            Tl_Qrcode_AbrirChamado Tela_QR_Code = new Tl_Qrcode_AbrirChamado();
           
            Tela_QR_Code.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tl_Login TelaLogin = new Tl_Login();
            TelaLogin.ShowDialog();
            if(TelaLogin.UserTecnico.Nome != null)
            {

                UserTecnico = TelaLogin.UserTecnico;
                if(UserTecnico.Nome != "Tela de senhas")
                {

                    Tl_Tecnicos TelaTecnicos = new Tl_Tecnicos(UserTecnico);
                    TelaTecnicos.Show();

                }
                else
                {

                    Tl_Senhas TelaSenhas = new Tl_Senhas();
                    TelaSenhas.Show();

                }

            }


            
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
