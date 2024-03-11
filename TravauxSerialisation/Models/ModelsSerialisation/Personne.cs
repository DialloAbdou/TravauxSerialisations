using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsSerialisation
{
    public class Personne
    {
        public string Nom { get; set; } = string.Empty;
        public string Prenome { get; set; } = string.Empty;
        public DateTime DateNaissance { get; set; }
        public int Taille { get; set; }


    }
}
