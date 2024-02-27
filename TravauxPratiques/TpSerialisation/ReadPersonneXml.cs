using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TpSerialisation
{
    public class ReadPersonneXml
    {
        public Personne GetReadPersonneXml()
        {
            var settings = new XmlReaderSettings
            {
                IgnoreWhitespace = true,
                IgnoreComments = true
            };

            Personne personne = new Personne();
            var reader = XmlReader.Create(@"C:\FormationC#\fondamentoC#\Serialisations\TravauxPratiques\TpSerialisation\fichier.xml", settings);

            reader.MoveToContent();

            reader.ReadStartElement("Personne");
            reader.ReadStartElement("Nom");
            personne.Nom = reader.ReadContentAsString();
            reader.ReadEndElement();

            reader.ReadStartElement("Prenom");
            personne.Prenome = reader.ReadContentAsString();
            reader.ReadEndElement();

            reader.ReadStartElement("DateDeNaissance");
            personne.DateNaissance = reader.ReadContentAsDateTime();
            reader.ReadEndElement();

            reader.ReadStartElement("Taille");
            personne.Taille = reader.ReadContentAsInt();
            reader.ReadEndElement();
            return personne;
        }
    }
}
