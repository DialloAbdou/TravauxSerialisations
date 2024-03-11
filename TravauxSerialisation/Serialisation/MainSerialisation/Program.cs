// See https://aka.ms/new-console-template for more information
using ModelsSerialisation;
using XMLSerialisation;

Console.WriteLine("Serialisation");

var readPersonne = new ReadPersonneXml();

var personneXml = readPersonne.GetReadPersonneXml();
if (personneXml is not null)
{
    Console.WriteLine($"Nom : {personneXml.Nom}, Prenom: {personneXml.Prenome},DateNaissance : {personneXml.DateNaissance}");

}
// Creation d'un fichier xml 
var personne1 = new Personne
{
    Nom = "DIALLO",
    Prenome = "Abdou",
    DateNaissance = new DateTime(1982, 5, 6)

};
var writePersonne = new WritePersonneXml();
writePersonne.CreatePersonneXml(personne1 );
Console.WriteLine("fichier a été créer avec succès !");
Console.ReadLine();
