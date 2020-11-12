using System;
using System.Collections.Generic;
using System.Text;

namespace Guilherme.Modal
{
    public class Voo
    {
        public int id_Voo { get; private set; }
        public DateTime Data_Voo { get; private set; }
        public int custo { get; private set; }
        public int Distancia { get; private set; }

        public string captura { get; private set; }
        public int Nivel_Dor { get; private set; }


        public Voo(int id, DateTime data, int custo, int distancia, string captura, int nivel_dor )
        {
            this.id_Voo = id;
            this.Data_Voo = data;
            this.custo = custo;
            this.Distancia = distancia;
            this.captura = captura;
            this.Nivel_Dor = nivel_dor;
        }

    }
}
