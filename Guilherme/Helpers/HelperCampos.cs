using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Guilherme.Helpers
{
    public class HelperCampos
    {
        public DateTime CampoData_Voo { get; private set; }
        public string Campocusto { get; private set; }
        public string CampoDistancia { get; private set; }

        public string CampoCaptura { get; private set; }
        public string CampoNivel_Dor { get; private set; }

        public HelperCampos(DateTime data, string custo, string distancia, string captura, string nivel_dor)
        {
            this.CampoCaptura = captura;
            this.Campocusto = custo;
            this.CampoData_Voo = data;
            this.CampoDistancia = distancia;
            this.CampoNivel_Dor = nivel_dor;
        }


        public int Custo()
        {
            int custos;
            if(int.TryParse(this.Campocusto, out custos))
            {
                return custos;
            }
            else
            {
                return 0;
            }
        }

        public int id(string valor)
        {
            int id;
            if (int.TryParse(valor, out id))
            {
                return id;
            }
            else
            {
                return 0;
            }
        }

        public int Distancia()
        {
            int valor;
            if (int.TryParse(this.CampoDistancia, out valor))
            {
                return valor;
            }
            else
            {
                return 0;
            }
        }

        public int NivelDor()
        {
            int valor;
            if (int.TryParse(this.CampoNivel_Dor, out valor))
            {
                return valor;
            }
            else
            {
                return 0;
            }
        }



        public bool ValidacaoCusto()
        {
            if (string.IsNullOrEmpty(this.Campocusto))
            {
                return false;
            }
            return true;
        }

        public bool ValidacaoDistancia()
        {
            if (string.IsNullOrEmpty(this.CampoDistancia))
            {
                return false;
            }
            return true;
        }

        public bool ValidacaoDor()
        {
            if (string.IsNullOrEmpty(this.CampoNivel_Dor) || this.CampoNivel_Dor.Length > 2)
            {
                return false;
            }
            return true;
        }


        public string selecionaRadios(string index)
        {
            string valor = "";
            if (index.Equals("s"))
            {
                valor = index;
            }

            if (index.Equals("n"))
            {
                valor = index;
            }


            return valor;
        }


    }
}
