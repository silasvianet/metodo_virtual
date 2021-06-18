﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_virtual
{
    public class Aeronave : Veiculo
    {
        public Aeronave(string tipoVeiculo)
            : base(tipoVeiculo)
        { }

        public override void Mover()
        {
            Console.WriteLine("Decolando a aeronave");
        }
        public override void Parar()
        {
            Console.WriteLine("Estou aterrisando a aeronave.");
        }
    }
}
