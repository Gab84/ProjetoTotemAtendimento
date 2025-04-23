using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace ProjetoTotem
{
    public class AtendimentoDAO : Atendimento
    {
        public async Task<String> GerarSenhaAtendimento()
        {
            var random = new Random();
            string senha = "ATD" + random.Next(1, 9999);
            return senha;
        }

        public async Task CadastrarAtendimento(Atendimento atendimento, FirebaseClient _firebase )
        {
            await _firebase.Child("ATENDIMENTO").Child(atendimento.Id).PutAsync(atendimento);  

        }

        public async Task<List<Atendimento>> ListarAtendimentos(FirebaseClient _firebase)
        {
            var atendimentos = await _firebase.Child("ATENDIMENTO").OnceAsync<Atendimento>();
            var lista = new List<Atendimento>();
            foreach(var item in atendimentos)
            {

                lista.Add(item.Object);

            }
            return lista;
        }

        public async Task ExcluirAtendimento(string Id, FirebaseClient _firebase)
        {

            await _firebase.Child("ATENDIMENTO").Child(Id).DeleteAsync();
        }


    }
}
