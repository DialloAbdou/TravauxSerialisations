using ModelsSerialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var VideoBlazor = new Video { Titre = "Blazor Assembly", Duree = 15 };
            var VideoAngular = new Video { Titre = "AngularJS", Duree = 25 };
           
            youtubeurAbdou.Videos = new() { VideoAngular, VideoBlazor };
            youtubeurAbdou.Videos.Add(VideoAngular);
            youtubeurAbdou.Videos.Add(VideoBlazor);

            var json = JsonSerializer.Serialize(youtubeurAbdou, new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return json;

        }
    }
}
