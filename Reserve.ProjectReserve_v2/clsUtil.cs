using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.ProjectReserve_v2
{
    public static class clsUtil
    {
        public static List<int> fncValidaSequencia(string tcSequenciaDigitada)
        {
            List<int> laListaInteirosValidos = new List<int>();
            List<int> laListaFinalInteiros = new List<int>();
            try
            {
                string[] aListaValores = tcSequenciaDigitada.Split(char.Parse(","));
                fncValidaArgumentosMinimos(aListaValores);
                fncValidaArgumentosMaximos(aListaValores);

                laListaInteirosValidos = fncValidaNumerosInteiros(aListaValores);
                fncValidaArgumentosMinMax(laListaInteirosValidos);
                fncValidaValoresInicialeFinal(aListaValores);

                for(int x = int.Parse(aListaValores[0]); x<= int.Parse(aListaValores[1]); x++)
                {
                    laListaFinalInteiros.Add(x);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return laListaFinalInteiros;
        }



        private static void fncValidaArgumentosMinimos(string[] taListaValores)
        {
            #region NumeroMinimoArgumento
            //Validação se não tem o número correto de argumentos (2)
            if (taListaValores.Count() < 2)
                throw new ArgumentException("oi, tudo bem? Então, não consegui encontrar valores (inicial e final). Vamos tentar novamente? (S/N)");
            #endregion NumeroMinimoArgumento
        }

        private static void fncValidaArgumentosMaximos(string[] taListaValores)
        {
            #region NumeroMaximoArgumento
            //Validação se não tem um número maior do que o sugerido (5)
            if (taListaValores.Count() > 2)
                throw new ArgumentException("Então... como vai? Eu encontrei mais de 2 valores. Vamos tentar novamente? :)  (S/N)");
            #endregion NumeroMaximoArgumento
        }
      
        private static List<int> fncValidaNumerosInteiros(string[] taListaValores)
        {
            #region NumerosInteirosValidos
            //Validação se todos os valores são inteiros válidos;
            string lcListaValoresErrados = "";
            bool lbExisteValorErrado = false;
            List<int> aListaValoresConvertidos = new List<int>();
            foreach (string laValor in taListaValores)
            {
                int loValorTestado;
                bool lbResult = Int32.TryParse(laValor, out loValorTestado);
                if (lbResult)
                {
                    aListaValoresConvertidos.Add(loValorTestado);
                }
                else
                {
                    lbExisteValorErrado = true;
                    lcListaValoresErrados = lcListaValoresErrados + laValor + ", ";
                }
            }

            if (lbExisteValorErrado)
            {
                lcListaValoresErrados = lcListaValoresErrados.Substring(0, lcListaValoresErrados.Length - 2);
                throw new ArgumentException("Olá! Fiz alguns testes e acho que não vou conseguir trabalhar com os seguintes valores digitados: \n" + lcListaValoresErrados + ". Vamos tentar novamente? ");
            }
            #endregion NumerosInteirosValidos

            return aListaValoresConvertidos;
        }

        public static void fncValidaArgumentosMinMax(List<int> taListaValores)
        {
            //Validação se todos os valores são inteiros acima de zero e menor que 100;
            string lcListaValoresErrados = "";
            bool lbExisteValorErrado = false;
            foreach (int laNumero in taListaValores)
            {
                if (laNumero < 0 || laNumero > 100)
                {
                    lbExisteValorErrado = true;
                    lcListaValoresErrados = lcListaValoresErrados + laNumero.ToString() + ", ";
                }
            }

            if (lbExisteValorErrado)
            {
                lcListaValoresErrados = lcListaValoresErrados.Substring(0, lcListaValoresErrados.Length - 2);
                throw new ArgumentException("Olá! Fiz alguns testes e acho que não vou conseguir trabalhar com os seguintes valores digitados: \n" + lcListaValoresErrados + ". \n Vamos tentar novamente? E desta vez pode digitar números maiores que 0 (zero) e menores que 100 (cem)? ");
            }

        }

        private static void fncValidaValoresInicialeFinal(string[] taListaValores)
        {
            #region ValoresInicialEfinal
            //Validação dos valores inicial e final
            if (int.Parse(taListaValores[0]) >= int.Parse(taListaValores[1]))
                throw new ArgumentException("hummm... acho que não vou conseguir realizar os cálculos com o valor inicial sendo maior ou igual ao final. Vamos tentar novamente? (S/N)");
            #endregion NumeroMinimoArgumento
        }

    }
}
