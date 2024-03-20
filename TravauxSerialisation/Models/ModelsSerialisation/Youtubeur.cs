using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsSerialisation
{
    public class Youtubeur
    {
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Titre { get; set; } = string.Empty;
        public List<Video>? Videos { get; set; }
    }
}
