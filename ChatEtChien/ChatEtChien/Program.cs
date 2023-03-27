using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienNamespace;
using ChatNamespace;

namespace AmitieNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat cat = new Chat("Cat");
            Chien dog = new Chien("Dog");
            Chien doggy = new Chien("Doggy");

            dog = cat.DevenirAmi(dog);      
            Console.WriteLine(cat.Ami);
            Console.WriteLine(dog.Ami);

            dog.DevenirAmi(doggy);
            Console.WriteLine(dog.Ami);
            Console.WriteLine(doggy.Ami);
        }
    }
}
