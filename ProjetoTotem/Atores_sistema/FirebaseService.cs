using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace ProjetoTotem
{
    public class FirebaseService
    {

        private readonly FirebaseClient _firebase; //cria o objeto para acesso do cliente Firebase

        public FirebaseService()
        {

            _firebase = new FirebaseClient("https://totematendimento-78bc9-default-rtdb.firebaseio.com/");

        }

       


    }
}
