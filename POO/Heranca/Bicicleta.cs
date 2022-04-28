using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal sealed class Bicicleta : Veiculo
    {

        public void Pedalar()
        {
            Console.WriteLine("Pedalando!");
        }
        public override void Acelerar() // método abstrato sobreescrito
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta!");
        }

    }
}
