// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Xml;
using TpSerialisation;

Console.WriteLine("======La serialisation======");

// utilisation de setting
//var readPersonnes = new ReadPersonneXml();

//var personne = readPersonnes.GetReadPersonneXml();
//Console.WriteLine($" Nom : {personne.Nom}, Prenom : {personne.Prenome}, DateNaissance : {personne.DateNaissance}, Taille : {personne.Taille}");

// Create Fichier Xml
Console.WriteLine("Création d'un fichier");

var personne1 = new Personne
{
    Nom = "DIALLO"  ,
    Prenome = "Abdou",
    DateNaissance = DateTime.Now,
    Taille = 180

};

var writePesonne = new WritePersonneXml();
writePesonne.CreatePersonneXml(personne1);
Console.ReadLine();
