using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Console = Colorful.Console;
using Colorful;
using Figgle;

namespace Affichage
{
    internal class Program
    {
        public enum EnumUnderTest
        {
            [Description("Custom description")]
            MemberWithDescriptionAttribute,
            MemberWithoutDescriptionAttribute,
            ALLCAPITALS
        }

        static void Main(string[] args)
        {
            //TestHumain();
            TestConsole();
        }

        static void TestHumain()
        {
            string phrase1 = "BonjourAToutLeMonde";
            string phrase2 = "C'est une vrai phrase";

            Console.WriteLine(EnumUnderTest.MemberWithDescriptionAttribute.Humanize());
            Console.WriteLine(phrase1.Humanize());
            Console.WriteLine(phrase2.Dehumanize());
            Console.WriteLine(phrase1.Truncate(10, "..."));
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
        }

        static void TestConsole()
        {
            ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
            ColorAlternator alternator = alternatorFactory.GetAlternator(2, Color.Plum, Color.PaleVioletRed);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLineAlternating("cats", alternator);
            }

            int DA = 244;
            int V = 212;
            int ID = 255;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteAscii("HASSELHOFF", Color.FromArgb(DA, V, ID));

                DA -= 18;
                V -= 36;
            }
            
            Console.WriteLine(FiggleFonts.Standard.Render("Hello, World!"));
        }
    }
}
