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
    public partial class Tl_etiquetaPronta : Form
    {
        private string incidentePronto;
        private string GmaquinaPronto;
        private string DproblemaPronto;
        public Tl_etiquetaPronta(string incidente,string Gmaquina,string Dproblema)
        {
            InitializeComponent();
            this.incidentePronto = incidente;
            this.GmaquinaPronto = Gmaquina;
            this.DproblemaPronto = Dproblema;

            TB_incidente.Text = incidentePronto;
            TB_patrimonio.Text = GmaquinaPronto;
            TB_descricao.Text = DproblemaPronto;

        }

        private void Tl_etiquetaPronta_Load(object sender, EventArgs e)
        {

        }
    }
}
