using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le 1er nombre:");
            Int32.TryParse(Console.ReadLine(), out int nb1);
            Console.WriteLine("Entrez le 2eme nombre:");
            Int32.TryParse(Console.ReadLine(), out int nb2);
            Calculateur calculateur = new Calculateur();
            try
            {
                Console.WriteLine(calculateur.Diviser(nb1, nb2));
            }
            catch (DivideByZeroException ex2)
            {
                Console.WriteLine("Erreur divison par 0");
            }
            catch (IndexOutOfRangeException ex1)
            {
                Console.WriteLine("Erreur out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur");
            }
        }
    }
}
