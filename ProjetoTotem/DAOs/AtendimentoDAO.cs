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

        public async Task<List<Atendimento>> ListarAtendimentos2(FirebaseClient _firebase)
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
        
        // As funções acima  precisam ser avaliadas se vão ser usadas ou não no Programa!



        

        public async Task<List<Atendimento>> ListarAtendimentos(FirebaseClient FBconnector)
        {
            List<Atendimento> DBatendimento = new List<Atendimento>();
            
            var result = await FBconnector
                .Child("ATENDIMENTO")
                .OnceAsync<Atendimento>();

            foreach(var item in result)
            {

                DBatendimento.Add(item.Object);

            }


            //return result.Select(item => item.Object).ToList();
            return DBatendimento;
           
        }



        
       

        public async Task<List<Atendimento>> GetPendentes(FirebaseClient FBconnector) =>
           (await ListarAtendimentos(FBconnector)).Where(a => a.Status == "pendente").ToList();



        public async Task<List<Atendimento>> GetEmAtendimentoTecnico(FirebaseClient FBconnector,Tecnico UserTecnico) =>
           (await ListarAtendimentos(FBconnector)).Where(a => a.Status == "Em_atendimento").Where(b => b.TecnicoLogin == UserTecnico.login).ToList();

        
        public async Task<List<Atendimento>> GetPrioritarios(FirebaseClient FBconnector,Tecnico UserTecnico) =>
           (await ListarAtendimentos(FBconnector)).Where(a => a.Status == "pendente").Where(b => b.TecnicoLogin == UserTecnico.login).Where(c => c.Prioridade == "Prioritario").ToList();
        


        public async Task<List<Atendimento>> GetAtendidos(FirebaseClient FBconnector, Tecnico UserTecnico) =>
          (await ListarAtendimentos(FBconnector)).Where(a => a.Status == "finalizado").Where(b => b.TecnicoLogin == UserTecnico.login).ToList();
        

        // Nos 3 metodos acima o ideial é que não seja utilizado como parametro para filtro o login do tecnico e sim talves o ID e o nome ou id e login,





        /*
        public async Task<List<Atendimento>> TesteGetPendentes(FirebaseClient FBconnector)
        {
            List<Atendimento> DBatendimento = await ListarAtendimentos(FBconnector);

            List<Atendimento> ATpendentes = new List<Atendimento>();
            
            foreach(var item in DBatendimento)
            {

                if (item.Status == "pendente")
                {
                    ATpendentes.Add(item);

                }

            }
            return ATpendentes;
        }
        */
    }
}
