// See https://aka.ms/new-console-template for more information
using System.Xml;
using TpSerialisation;

Console.WriteLine("======La serialisation======");

// utilisation de setting

var settings = new XmlReaderSettings
{
    IgnoreWhitespace = true,
    IgnoreComments = true
};

Personne personne = new Personne();
var reader = XmlReader.Create(@"C:\FormationC#\fondamentoC#\Serialisations\TravauxPratiques\TpSerialisation\fichier.xml",settings);

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
reader.ReadEndElement();

Console.WriteLine($" Nom : {personne.Nom}, Prenom : {personne.Prenome}, DateNaissance : {personne.DateNaissance}, Taille : {personne.Taille}");
Console.ReadLine();
