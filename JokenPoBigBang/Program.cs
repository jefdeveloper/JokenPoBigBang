using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPoBigBang
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EscolhaEnum> escolhas = new List<EscolhaEnum>();
            bool erro;

            do
            {
                erro = false;

                Console.WriteLine("Escolha uma das opções:");

                foreach (EscolhaEnum escolha in Enum.GetValues(typeof(EscolhaEnum)))
                {
                    Console.WriteLine(Convert.ToInt32(escolha) + " - " + escolha.ToString());
                }

                string resposta = Console.ReadLine();
                int respostaInt;

                if (int.TryParse(resposta, out respostaInt) && Enum.IsDefined(typeof(EscolhaEnum), respostaInt))
                {
                    escolhas.Add((EscolhaEnum)respostaInt);
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                    erro = true;
                }

            } while (erro || escolhas.Count < 2);

            EscolhaEnum? vencedor = Regras.GetVencedor(escolhas[0], escolhas[1]);

            if (vencedor == null)
            {
                Console.WriteLine("Empate!");
            }
            else
            {
                Console.WriteLine(vencedor.ToString() + " ganhou!");
            }

            Console.ReadKey();
        }

       
    }
}
