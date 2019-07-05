using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.ProjectReserve_v2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string lcMenu = "";

            do
            {
                Console.Clear();

                Console.WriteLine("Digite uma sequencia de 5 números (todos entre 0 e 100)!");
                Console.WriteLine(":: Separe os números com vírgula ::");
                Console.Write("=> ");
                string lcTextoDigitado = Console.ReadLine();
                string lcNumerosExtensos = "";
                try
                {
                    List<int> laListaInteirosValidos = new List<int>();
                    laListaInteirosValidos = clsUtil.fncValidaSequencia(lcTextoDigitado);
                    clsListagens loListagem = new clsListagens();
                    foreach (int laNumero in laListaInteirosValidos)
                    {
                        lcNumerosExtensos = lcNumerosExtensos + loListagem.fncRetornoNumeroExtenso(laNumero) + ", ";

                    }

                    lcNumerosExtensos = lcNumerosExtensos.Substring(0, lcNumerosExtensos.Length - 2);
                    string lcNumerosExtensosTratados = lcNumerosExtensos.Replace(" ", "").Replace(",", "");
                    int lnTotalLetras = lcNumerosExtensosTratados.Length;

                    Console.WriteLine("");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("Olha que legal: ");
                    Console.WriteLine("Números digitados: " + lcTextoDigitado);
                    Console.WriteLine("Números digitados por extenso: " + lcNumerosExtensos);
                    Console.WriteLine("Total de letras: " + lnTotalLetras.ToString());
                    Console.WriteLine("****************************************");
                    Console.WriteLine("");
                    Console.WriteLine("Vamos continuar? (S/N)");
                    lcMenu = Console.ReadLine();



                }
                catch (Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine(e.Message);
                    lcMenu = Console.ReadLine();

                }

            } while (lcMenu.ToUpper() != "N");
            Console.WriteLine("");
            Console.WriteLine("****************************************");
            Console.WriteLine("Obrigado por brincar comigo.");
            Console.WriteLine("****************************************");
            Console.ReadKey();
        }
    }
}
