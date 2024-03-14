// See https://aka.ms/new-console-template for more information
using ModelsSerialisation;
using System.Xml.Linq;
using XMLSerialisation;

Console.WriteLine("Serialisation");

// ReadXML Lecture XML
var readPersonne = new ReadPersonneXml();

var personneXml = readPersonne.GetReadPersonneXml();
if (personneXml is not null)
{
    Console.WriteLine($"Nom : {personneXml.Nom}, Prenom: {personneXml.Prenome},DateNaissance : {personneXml.DateNaissance}");
}

//  WriteXML Creation d'un fichier xml 
var personne1 = new Personne
{
    Nom = "DIALLO",
    Prenome = "Abdou",
    DateNaissance = new DateTime(1982, 5, 6)

};
WritePersonneXml? writePersonne = new WritePersonneXml();
writePersonne.CreatePersonneXml(personne1);
//Console.WriteLine("fichier a été créer avec succès !");

// Gestion XML en mémoire avec XDocument
var adresse = new XElement("Adresse", "52 rue Ferertra 31400 Toulouse");

var doc = XDocument.Load(@"C:\FormationC#\fondamentoC#\Serialisations\Docs\fichier.xml");
if (doc.Root is not null)
{
    var elemTaille = doc.Root.Element("Taille");
    if (elemTaille is not null)
    {
        elemTaille.AddAfterSelf(adresse);

        var xmldocument = new XMLDocumentPersonne();

        var personne = new Personne();

        var perso = xmldocument.ReadXmlDocument(personne, doc);

        Console.WriteLine("Gestion XMl en mémoire avec XDocument !");

        Console.WriteLine($"{perso.Nom}, {perso.Prenome} {perso.DateNaissance}, {perso.Taille}, {perso.Adresse}");
    }
}


Console.ReadLine();
