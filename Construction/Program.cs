using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Game = true;
            int compteur = 1;
            Ville ville = new Ville();
            ville.AjouterBatiment(new Batiment(5, "Parfait", 0, 5));
            ville.AjouterBatiment(new Batiment(15, "À démolir", 5, 1));
            ville.AjouterBatiment(new Batiment(10, "Réparation nécéssaire", 2, 2));
            ville.AjouterBatiment(new Batiment(1, "Parfait", 0, 4));
            ville.AjouterBatiment(new Batiment(6, "Réparation nécéssaire", 3, 4));


            Usine usine = new Usine();

            Robot robot1 = usine.CreerRobot("Vitesse");

            Console.WriteLine($"Le premier robot comportant les pieces : {robot1}\nà fait un scan de la ville, les statuts des batiments sont les suivants : ");
            robot1.ScannerVille(ville);
            Console.WriteLine("");
            while (Game)
            {
            Console.WriteLine($"------------------------------BATIMENT {compteur} (statut: {ville.batiments[compteur - 1].Statut})------------------------------");
                if (ville.batiments[compteur - 1].Statut != "Parfait" && ville.batiments[compteur - 1].Statut != "Détruit")
                {
                    Console.WriteLine("1-Creer robot\n" +
                        "2-Envoyer ressources\n" +
                        "3-Reparer batiment\n" +
                        "4-Detruire batiment\n");
                    string temp = Console.ReadLine();

                    switch (temp)
                    {
                        case "1":
                            Console.WriteLine("Entrez type:");
                            Robot robot = usine.CreerRobot(Console.ReadLine());
                            Console.WriteLine(robot);
                            break;
                        case "2":
                            Console.WriteLine("Des ressources sont envoyés au batiment");
                            break;
                        case "3":
                            Console.WriteLine("Le batiment est réparé par un robot");
                            ville.batiments[compteur - 1].Statut = "Parfait";
                            break;
                        case "4":
                            Console.WriteLine("Le batiment est détruit par un robot");
                            ville.batiments[compteur - 1].Statut = "Détruit";
                            break;
                        default:
                            Console.WriteLine("Ce n'est pas un choix\n");
                            break;
                    }
                }
                else {
                    Console.WriteLine("Il n'y a rien a faire sur ce batiment.");
                    if (ville.batiments.Count == compteur)
                    {
                        Game = false;
                    }
                    else
                    {
                        compteur++;
                    }
                }
            }
        }
    }
}
