using Api_ANEEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_ANEEL.Services
{
    public class AneelServices
    {
        private Fornecedor[] GetFornecedor()
        {
            return new Fornecedor[]
            {
                new Fornecedor
                {
                    Id = 0,
                    Nome ="Não Especificado"
                },
                new Fornecedor
                {
                    Id = 1,
                    Nome = "AME"
                },
                new Fornecedor
                {
                    Id = 2,
                    Nome = "BOA VISTA"
                },
                new Fornecedor
                {
                    Id = 3,
                    Nome = "CEA"
                },
                new Fornecedor
                {
                    Id = 4,
                    Nome = "CEAL"
                },
                new Fornecedor
                {
                    Id = 5,
                    Nome = "CEBDIS"
                },
                new Fornecedor
                {
                    Id = 6,
                    Nome ="CEEE-D"
                },
                new Fornecedor
                {
                    Id = 7,
                    Nome ="CELESC"
                },
                new Fornecedor
                {
                    Id = 8,
                    Nome ="CELPA"
                },
                new Fornecedor
                {
                    Id = 9,
                    Nome ="CELPE"
                },
                new Fornecedor
                {
                    Id = 10,
                    Nome ="CEMAR"
                },
                new Fornecedor
                {
                    Id = 11,
                    Nome ="CEMIG-D"
                },
                new Fornecedor
                {
                    Id = 12,
                    Nome ="CELG-D"
                },
                new Fornecedor
                {
                    Id = 13,
                    Nome ="CEPISA"
                },
                new Fornecedor
                {
                    Id = 14,
                    Nome ="CERGAL"
                },
                new Fornecedor
                {
                    Id = 15,
                    Nome ="CERON"
                },
                new Fornecedor
                {
                    Id = 16,
                    Nome ="CERR"
                },
                new Fornecedor
                {
                    Id = 17,
                    Nome ="CHESP"
                },
                new Fornecedor
                {
                    Id = 18,
                    Nome ="COCEL"
                },
                new Fornecedor
                {
                    Id = 19,
                    Nome ="COELBA"
                },
                new Fornecedor
                {
                    Id = 20,
                    Nome ="COOPERALIANÇA"
                },
                new Fornecedor
                {
                    Id = 20,
                    Nome ="COPEL-DIS"
                },
                new Fornecedor
                {
                    Id = 21,
                    Nome ="COSERN"
                },
                new Fornecedor
                {
                    Id = 22,
                    Nome ="CPFL Jaguari"
                },
                new Fornecedor
                {
                    Id = 23,
                    Nome ="CPFL Leste Paulista"
                },
                new Fornecedor
                {
                    Id = 24,
                    Nome ="CPFL Mococa"
                },
                new Fornecedor
                {
                    Id = 25,
                    Nome ="CPFL- PIRATININGA"
                },
                new Fornecedor
                {
                    Id = 26,
                    Nome ="CPFL Santa Cruz"
                },
                new Fornecedor
                {
                    Id = 27,
                    Nome ="CPFL Sul Paulista"
                },
                new Fornecedor
                {
                    Id = 28,
                    Nome ="CPFL-PAULISTA"
                },
                new Fornecedor
                {
                    Id = 29,
                    Nome ="DEMEI"
                },
                new Fornecedor
                {
                    Id = 30,
                    Nome ="DMED"
                },
                new Fornecedor
                {
                    Id = 31,
                    Nome ="EBO"
                },
                new Fornecedor
                {
                    Id = 32,
                    Nome ="EDP ES"
                },
                new Fornecedor
                {
                    Id = 33,
                    Nome ="EDP SP"
                },
                new Fornecedor
                {
                    Id = 34,
                    Nome ="EFLJC"
                },
                new Fornecedor
                {
                    Id = 35,
                    Nome ="EFLUL"
                },
                new Fornecedor
                {
                    Id = 36,
                    Nome ="Elektro"
                },
                new Fornecedor
                {
                    Id = 37,
                    Nome ="ELETROACRE"
                },
                new Fornecedor
                {
                    Id = 38,
                    Nome ="Eletrocar"
                },
                new Fornecedor
                {
                    Id = 39,
                    Nome ="ENEEL SP"
                },
                new Fornecedor
                {
                    Id = 40,
                    Nome ="ELFSM"
                },
                new Fornecedor
                {                    
                    Id = 41,
                    Nome ="EMG"
                },
                new Fornecedor
                {
                    Id = 42,
                    Nome ="EMS"
                },
                new Fornecedor
                {
                    Id = 43,
                    Nome ="EMT"
                },
                new Fornecedor
                {
                    Id = 44,
                    Nome ="ENEL CE"
                },
                new Fornecedor
                {
                    Id = 45,
                    Nome ="Enel GO"
                },
                new Fornecedor
                {
                    Id = 46,
                    Nome ="Enel RJ"
                },
                new Fornecedor
                {
                    Id = 47,
                    Nome ="HIDROPAN"
                },
                new Fornecedor
                {
                    Id = 48,
                    Nome ="Light"
                },
                new Fornecedor
                {
                    Id = 49,
                    Nome ="Light - Ponta 18h"
                },
                new Fornecedor
                {
                    Id = 50,
                    Nome ="MUXENERGIA"
                },
                new Fornecedor
                {
                    Id = 51,
                    Nome ="UHENPAL"
                },
                new Fornecedor
                {
                    Id = 52,
                    Nome ="ENF"
                },
                new Fornecedor
                {
                    Id = 53,
                    Nome ="EPB"
                },
                new Fornecedor
                {
                    Id = 54,
                    Nome ="ESE"
                },
                new Fornecedor
                {
                    Id = 55,
                    Nome ="ESS"
                },
                new Fornecedor
                {
                    Id = 56,
                    Nome ="ETO"
                },
                new Fornecedor
                {
                    Id = 57,
                    Nome ="Forcel"
                },
                new Fornecedor
                {
                    Id = 58,
                    Nome ="IENERGIA"
                },
                new Fornecedor
                {
                    Id = 59,
                    Nome ="Sulgipe"
                },
                new Fornecedor
                {
                    Id = 60,
                    Nome ="RGE"
                },
                new Fornecedor
                {
                    Id = 61,
                    Nome ="RGE Sul"
                },
                new Fornecedor
                {
                    Id = 62,
                    Nome ="Castro - DIS"
                },
                new Fornecedor
                {
                    Id = 63,
                    Nome ="CEB-DIS"
                },
                new Fornecedor
                {
                    Id = 64,
                    Nome ="Cedrap"
                },
                new Fornecedor
                {
                    Id = 65,
                    Nome ="Cedri"
                },
                new Fornecedor
                {
                    Id = 66,
                    Nome ="CEGERO"
                },
                new Fornecedor
                {
                    Id = 67,
                    Nome ="Cejama"
                },
                new Fornecedor
                {
                    Id = 68,
                    Nome ="Celesc-DIS"
                },
                new Fornecedor
                {
                    Id = 69,
                    Nome ="Cemirim"
                },
                new Fornecedor
                {
                    Id = 70,
                    Nome ="Ceprag"
                },
                new Fornecedor
                {
                    Id = 71,
                    Nome ="Ceraça"
                },
                new Fornecedor
                {
                    Id = 72,
                    Nome ="Ceral Anitápolis"
                },

            };
        }
        private Bandeira[] GetBandeira()
        {
            return new Bandeira[]
            {
                new Bandeira
                {
                    Id = 0,
                    Nome = "Sem registro",
                    ValorAcrescido = 0.0
                },
                new Bandeira
                {
                    Id = 1,
                    Nome = "Bandeira verde",
                    ValorAcrescido = 0.0
                },
                 new Bandeira
                {
                    Id = 2,
                    Nome = "Bandeira amarela",
                    ValorAcrescido = 0.01343
                },
                new Bandeira
                {
                    Id = 3,
                    Nome = "Bandeira vermelha - Patamar 1",
                    ValorAcrescido = 0.04169
                },
                new Bandeira
                {
                    Id = 4,
                    Nome = "Bandeira vermelha - Patamar 2",
                    ValorAcrescido = 0.06243
                },
            };
        }
    }
}
