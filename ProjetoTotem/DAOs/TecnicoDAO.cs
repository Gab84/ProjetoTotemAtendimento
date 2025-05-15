using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace ProjetoTotem
{
    public class TecnicoDAO : Tecnico
    {

        
        public async Task<Tecnico> LoginChecker(FirebaseClient FBconnector, string InputLogin, string InputSenha)
        {
            Tecnico FoundTecnico = new Tecnico();
            List<Tecnico> listaDeTecnicos = new List<Tecnico>();
            var users = await FBconnector.Child("USERS").OnceAsListAsync<Tecnico>();
            
            
            foreach (var item in users)
            {
                listaDeTecnicos.Add(item.Object);
           
            }


            if(listaDeTecnicos.Count > 0)
            {
                
                for(int i = 1; i <  listaDeTecnicos.Count; i++)
                {

                    if (listaDeTecnicos[i].login == InputLogin & listaDeTecnicos[i].senha == InputSenha)
                    {

                        FoundTecnico = listaDeTecnicos[i];
                        break;
                        
                    }

                }



          
             }

            return FoundTecnico;



        }


        public async Task CadastrarUsuario(Tecnico UserTecnico, FirebaseClient _firebase)
        {
            await _firebase.Child("USER").Child(UserTecnico.Id).PutAsync(UserTecnico);

        }



    }
}
