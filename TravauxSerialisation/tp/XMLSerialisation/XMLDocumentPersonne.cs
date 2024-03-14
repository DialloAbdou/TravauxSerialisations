using ModelsSerialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLSerialisation
{
    public class XMLDocumentPersonne
    {
        public Personne  ReadXmlDocument(Personne personne, XDocument doc)
        {
            // instanciation de XDocument

            if (doc.Root is not null)
            {
                foreach (var elm in doc.Root.Elements())
                {
                    if (elm.Name == "Nom")
                    {
                        personne.Nom = elm.Value;
                    }
                    else if (elm.Name == "Prenom")
                    {
                        personne.Prenome = elm.Value;

                    }
                    else if (elm.Name == "DateDeNaissance")
                    {
                        personne.DateNaissance = DateTime.Parse(elm.Value);

                    }
                    else if (elm.Name == "Taille")
                    {
                        personne.Taille = int.Parse(elm.Value);
                    }
                    else if(elm.Name == "Adresse")
                    {
                        personne.Adresse = elm.Value;
                    }
                }
            }
            return personne;
        }
    }
}
