using ModelsSerialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonSerialisation
{
    public class SerialisationYoutubeur
    {

        public string GetSerialisation()
        {
            Youtubeur youtubeurAbdou = new Youtubeur { Nom = "Diallo", Prenom = "Abdou", Titre = "Developpeur .Net" };

            List<Video> videos = new List<Video>
            {
                new Video { Titre = "Serialisation & Deserialisaation", Duree = 25, Tags= new List<string>{" JSon, Objet"} },
                new Video { Titre = "Manipulation Base de donnée", Duree = 25, Tags= new List<string>{" Sql Server, Oracle"} },
                new Video { Titre = "Angular & React", Duree = 25, Tags= new List<string>{" Front, Mobile"} }

            };
            youtubeurAbdou.Videos = videos;

            var json = JsonSerializer.Serialize(youtubeurAbdou, new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            return json;

        }
    }
}
