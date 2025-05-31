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

        public string TecnicoLogin { get; set; }  //atributo colocado apenas para teste

        public string Num_incidente { get; set; }

        public string Patrimonio_Maq { get; set; }
        public string Datahora { get; set; }

        public string Status { get; set; }

        public string Prioridade { get; set; }

        public string portaAtendido { get; set; }
    }

    public class Tecnico
    {

        public string Id { get; set; }
        public string Nome { get; set; }

        public string login { get; set; }

        public string senha { get; set; }

        public string status { get; set;}

        public string PortaAtual { get; set; }
    }

    

}
