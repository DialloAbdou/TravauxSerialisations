using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonSerialisation
{
    public class WritePersonne
    {
        public void EcrireJsonPersonne()
        {
            using var memStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memStream, new JsonWriterOptions
            {
                Indented = true,
            });
            writer.WriteStartObject();
            writer.WritePropertyName("nom");
            writer.WriteStringValue("Diallo");

            writer.WritePropertyName("prenom");
            writer.WriteStringValue("abdou");

            writer.WritePropertyName("age");
            writer.WriteNumberValue(33);
            writer.WriteEndObject();

            writer.Flush();

            memStream.Position = 0;
            Console.WriteLine(Encoding.UTF8.GetString(memStream.ToArray()));

        }
    }
}
