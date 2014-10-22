using CSharpSixReview.StructConstructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSixReview
{
    class Program
    {
        static void Main(string[] args)
        {

            var methods = new Dictionary<string, Action>
            {
                ["1"] = () => NameOf(),
                ["2"] = () => PrimaryCtors(),
                ["3"] = () => StructCtors()

            };

            Console.WriteLine("C# Demos");
            Console.WriteLine();
            Console.WriteLine("1 - Name of");
            Console.WriteLine("2 - Primary ctors");
            Console.WriteLine("3 - Struct ctors");

            while (true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    return;
                }

                methods.TryGetValue(line.First().ToString(), out var value);
                value?.Invoke();
            }

        }

        private static void StructCtors()
        {
            var v1 = new Vector2D(4.0, 6.7);
            Console.WriteLine("{0} Length {1}", v1, v1.Length);
            var v2 = new Vector2D();
            Console.WriteLine("{0} + {1} = {2} ", v1, v2, v1 + v2);
        }

        private static void PrimaryCtors()
        {
            var pc = new PrimaryConstructor(2, 4);
            Console.WriteLine("(X, Y) = ({0},{1})", pc.X, pc.Y);
            var pc2 = new PrimaryConstructor();
        }

        private static void NameOf()
        {
            NameOfOperator op = new NameOfOperator();
            try
            {
                op.ValidateName6("En un lugar de la Mancha, de cuyo nombre no quiero acordarme, no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, adarga antigua, rocín flaco y galgo corredor. Una olla de algo más vaca que carnero, salpicón las más noches, duelos y quebrantos los sábados, lantejas los viernes, algún palomino de añadidura los domingos, consumían las tres partes de su hacienda. El resto della concluían sayo de velarte, calzas de velludo para las fiestas, con sus pantuflos de lo mesmo, y los días de entresemana se honraba con su vellorí de lo más fino. Tenía en su casa una ama que pasaba de los cuarenta, y una sobrina que no llegaba a los veinte, y un mozo de campo y plaza, que así ensillaba el rocín como tomaba la podadera. Frisaba la edad de nuestro hidalgo con los cincuenta años; era de complexión recia, seco de carnes, enjuto de rostro, gran madrugador y amigo de la caza. Quieren decir que tenía el sobrenombre de Quijada, o Quesada, que en esto hay alguna diferencia en los autores que deste caso escriben; aunque, por conjeturas verosímiles, se deja entender que se llamaba Quejana. Pero esto importa poco a nuestro cuento; basta que en la narración dél no se salga un punto de la verdad. ");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
