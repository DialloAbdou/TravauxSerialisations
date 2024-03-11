using ModelsSerialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLSerialisation
{
    public class WritePersonneXml
    {
        public void CreatePersonneXml(Personne personne)
        {
            var parametre = new XmlWriterSettings
            {
                Indent = true,
            };

            string pathString = @"C:\FormationC#\fondamentoC#\Serialisations\Docs\personne.xml";

            try
            {
                if (File.Exists(pathString))
                    { File.Delete(pathString); }
                var write = XmlWriter.Create(pathString, parametre);
                write.WriteStartElement("Personne");
                write.WriteElementString("Nom", personne.Nom);
                write.WriteElementString("Prenom", personne.Prenome);
                write.WriteElementString("DateNaissance", personne.DateNaissance.ToString());
                write.WriteElementString("Taille", personne.Taille.ToString());
                write.WriteEndElement();
                write.Flush();
            }
            catch (Exception)
            {

                throw;
            }



        }

    }
}
