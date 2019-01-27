using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPoBigBang
{
    class Regras
    {
        public static EscolhaEnum? GetVencedor(EscolhaEnum escolha1, EscolhaEnum escolha2)
        {
            if (escolha1 == escolha2)
            {
                return null;
            }
            else
            {
                List<EscolhaRegras> regras = GetRegras();

                EscolhaRegras regra = regras.Find(r => r.Escolha == escolha1);

                if (regra.GanhaDe.Contains(escolha2))
                {
                    return escolha1;
                }
                else
                {
                    return escolha2;
                }
            }
        }

        private static List<EscolhaRegras> GetRegras()
        {
            List<EscolhaRegras> escolhaRegras = new List<EscolhaRegras>();

            escolhaRegras.Add(new EscolhaRegras
            {
                Escolha = EscolhaEnum.Lagarto,
                GanhaDe = new List<EscolhaEnum>()
                {
                     EscolhaEnum.Spock,
                     EscolhaEnum.Papel
                }
            });

            escolhaRegras.Add(new EscolhaRegras
            {
                Escolha = EscolhaEnum.Papel,
                GanhaDe = new List<EscolhaEnum>()
                {
                     EscolhaEnum.Pedra,
                     EscolhaEnum.Spock
                }
            });

            escolhaRegras.Add(new EscolhaRegras
            {
                Escolha = EscolhaEnum.Pedra,
                GanhaDe = new List<EscolhaEnum>()
                {
                     EscolhaEnum.Tesoura,
                     EscolhaEnum.Lagarto
                }
            });

            escolhaRegras.Add(new EscolhaRegras
            {
                Escolha = EscolhaEnum.Spock,
                GanhaDe = new List<EscolhaEnum>()
                {
                     EscolhaEnum.Tesoura,
                     EscolhaEnum.Pedra
                }
            });

            escolhaRegras.Add(new EscolhaRegras
            {
                Escolha = EscolhaEnum.Tesoura,
                GanhaDe = new List<EscolhaEnum>()
                {
                     EscolhaEnum.Papel,
                     EscolhaEnum.Lagarto
                }
            });

            return escolhaRegras;
        }
    }
}
