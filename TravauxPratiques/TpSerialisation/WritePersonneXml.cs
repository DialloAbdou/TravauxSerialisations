using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TpSerialisation
{
    public class WritePersonneXml
    {

        public void CreatePersonneXml(Personne personne)
        {
            var parametre = new XmlWriterSettings
            {
                Indent = true,
            };
            var write = XmlWriter.Create(@"C:\FormationC#\fondamentoC#\Serialisations\TravauxPratiques\TpSerialisation\personne.xml", parametre);

            write.WriteStartElement("Personne");
            write.WriteElementString("Nom",personne.Nom);
            write.WriteElementString("Prenom", personne.Prenome);
            write.WriteElementString("DateNaissance", personne.DateNaissance.ToString());
            write.WriteElementString("Taille", personne.Taille.ToString());
            write.WriteEndElement();
            write.Flush();
            
        }
    }
}
