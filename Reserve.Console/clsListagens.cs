using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.ProjectConsole
{
    public class clsListagens
    {
        private readonly ArrayList laListaUnidades;
        private readonly ArrayList laListaDezenas;
        private ArrayList laListaDezenasFixas;

        public clsListagens()
        {
            laListaUnidades = new ArrayList();
            laListaDezenasFixas = new ArrayList();
            laListaDezenas = new ArrayList();

            laListaUnidades.Add("Um");
            laListaUnidades.Add("Dois");
            laListaUnidades.Add("Três");
            laListaUnidades.Add("Quatro");
            laListaUnidades.Add("Cinco");
            laListaUnidades.Add("Seis");
            laListaUnidades.Add("Sete");
            laListaUnidades.Add("Oito");
            laListaUnidades.Add("Nove");

          

            laListaDezenasFixas.Add("Onze");
            laListaDezenasFixas.Add("Doze");
            laListaDezenasFixas.Add("Treze");
            laListaDezenasFixas.Add("Quatorze");
            laListaDezenasFixas.Add("Quinze");
            laListaDezenasFixas.Add("Dezesseis");
            laListaDezenasFixas.Add("Dezessete");
            laListaDezenasFixas.Add("Dezoito");
            laListaDezenasFixas.Add("Dezenove");



            laListaDezenas.Add("Dez");
            laListaDezenas.Add("Vinte");
            laListaDezenas.Add("Trinta");
            laListaDezenas.Add("Quarenta");
            laListaDezenas.Add("Cinquenta");
            laListaDezenas.Add("Sessenta");
            laListaDezenas.Add("Setenta");
            laListaDezenas.Add("Oitenta");
            laListaDezenas.Add("Noventa");
        }
        private string fncRetornaDezenaFixa(string tcDezenaFixa)
        {
           return laListaDezenasFixas[((int.Parse(tcDezenaFixa)) - 1)].ToString();
        }

        private string fncRetornaDezena(string tcDezena)
        {
            return laListaDezenas[Int16.Parse(tcDezena) - 1].ToString();
        }

        private string fncRetornaUnidade(string tcUnidade)
        {
            return laListaUnidades[(int.Parse(tcUnidade) - 1)].ToString();
        }
        
        private  string fncRetornaUnidade(int tnUnidade)
        {
            return (tnUnidade == 0) ? "Zero" : fncRetornaUnidade(tnUnidade.ToString());
        }

        private string fncRetornaDezena(int tnDezena)
        {
          
            string lcPrimeiroNumero = tnDezena.ToString().Substring(0, 1);
            string lcSegundoNumero = tnDezena.ToString().Substring(1, 1);
            string lcNumeroExtenso = "";

            if (int.Parse(lcPrimeiroNumero) == 1)
            {
                lcNumeroExtenso = (int.Parse(lcSegundoNumero)==0)?"Dez":fncRetornaDezenaFixa(lcSegundoNumero);
            }
            else
            {
                lcNumeroExtenso = fncRetornaDezena(lcPrimeiroNumero);
                lcNumeroExtenso = (int.Parse(lcSegundoNumero)==0)? lcNumeroExtenso: lcNumeroExtenso + " e " + fncRetornaUnidade(lcSegundoNumero);
            }

            return lcNumeroExtenso;

        }

        public string fncRetornoNumeroExtenso(int tnNumero)
        {
            string lcNumeroPorExtenso = "";
            switch (tnNumero.ToString().Length)
            {
                case 1:
                    lcNumeroPorExtenso = fncRetornaUnidade(tnNumero);
                    break;
                case 2:
                    lcNumeroPorExtenso = fncRetornaDezena(tnNumero);
                    break;
                case 3:
                    lcNumeroPorExtenso = "Cem";
                    break;
                default:
                    break;
            }

            return lcNumeroPorExtenso;
        }
    }
}
