using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exo1tp2core.Models
{
    public class User
    {
        public string Nom { get; set; }
        public string Prenom  { get; set; }
       public User(string nom,string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
    }
}
