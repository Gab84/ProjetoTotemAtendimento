using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;

namespace ProjetoTotem
{

    public class Atendimento
    {
        public string Id { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEmail { get; set; }

        public string TecnicoId { get; set; }
        public string TecnicoNome { get; set; }
       
        public string Num_incidente { get; set; }

        public string Patrimonio_Maq { get; set; }
        public string Datahora { get; set; }

        public string Status { get; set; }

        public string Prioridade { get; set; }


    }

    

}
