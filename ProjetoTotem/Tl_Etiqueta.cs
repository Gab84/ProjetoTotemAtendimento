using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTotem
{
    public partial class Tl_Etiqueta: Form
    {
        private string incidente;
        private string Gmaquina;
        private string Dproblema;
        public Tl_Etiqueta()
        {
            InitializeComponent();
            
        }

        private void ImprimirETQ_Click(object sender, EventArgs e)
        {

            incidente = TB_E_incidente.Text;
            Gmaquina = TB_E_Gmaquina.Text;
            Dproblema = TB_E_descreva.Text;

            if(TB_E_descreva.Text !="" & TB_E_Gmaquina.Text !="" & TB_E_descreva.Text !="")
            {
                Tl_etiquetaPronta tela_EtiquetaPronta = new Tl_etiquetaPronta(incidente, Gmaquina, Dproblema);
                tela_EtiquetaPronta.ShowDialog();

            }
            else
            {
                MessageBox.Show("A CAMPOS NÃO PREENCHIDOS!");

            }

            
        }
    }
}
