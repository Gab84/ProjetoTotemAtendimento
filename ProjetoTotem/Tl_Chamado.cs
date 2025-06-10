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
    public partial class Tl_Chamado : Form
    {
        private FBConnector Coon = new FBConnector();
        private TecnicoDAO tecnicoDAO = new TecnicoDAO();
        public Tl_Chamado()
        {
            InitializeComponent();
            DropBoxFiller(Coon, tecnicoDAO);
        }

        private async Task DropBoxFiller(FBConnector Coon, TecnicoDAO tecnicoDAO)
        {
            List<Tecnico> tecnicos = new List<Tecnico>();

            tecnicos = await tecnicoDAO.GetTecnicos(Coon.BDoor);

            CBtecnicos.BeginUpdate();
            try
            {

                if (tecnicos.Count > 0)
                {

                    for (int i = 1; i < tecnicos.Count; i++)
                    {
                        CBtecnicos.Items.Add(tecnicos[i].Nome);

                    }

                }

            }
            finally
            {

                CBtecnicos.EndUpdate();

            }
        }
        private void Tl_Chamado_Load(object sender, EventArgs e)
        {

        }


    }
}
