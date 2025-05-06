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

        public async Task CadastrarUsuario(Tecnico UserTecnico, FirebaseClient _firebase)
        {
            await _firebase.Child("USUARIOS").Child(UserTecnico.Nome).PutAsync(UserTecnico);

        }



    }
}
