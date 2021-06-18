using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_virtual
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoVeiculo)
            : base(tipoVeiculo)
        { }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o veículo");
        }
        public override void Parar()
        {
            Console.WriteLine("Estou brecando o veículo.");
        }
    }
}
