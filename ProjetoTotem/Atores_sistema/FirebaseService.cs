using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace ProjetoTotem
{
    public class FBConnector
    {

        public readonly FirebaseClient BDoor;

        public FBConnector()
        {

            this.BDoor = new FirebaseClient("https://totematendimento-78bc9-default-rtdb.firebaseio.com/");
        }


    }
}
