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
        public Tl_Etiqueta()
        {
            InitializeComponent();
            
        }

        private void ImprimirETQ_Click(object sender, EventArgs e)
        {
            Tl_etiquetaPronta tela_EtiquetaPronta = new Tl_etiquetaPronta();
            tela_EtiquetaPronta.ShowDialog();
        }
    }
}
