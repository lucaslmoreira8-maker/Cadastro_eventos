using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_eventos.Models
{
    public class Dados_Festa
    {


        public required Festas FestasSelecionada { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int QuantidadeAdultos { get; set; }
        public int QuantidadeCriancas { get; set; }
        public int Duracao => Termino.Subtract(value: Inicio).Days;

        public double ValorTotal { 
    
            get
            {
                double valor_adultos = QuantidadeAdultos * FestasSelecionada.ValorAdulto * Duracao;
                double valor_criancas = QuantidadeCriancas * FestasSelecionada.ValorCrianca * Duracao;
                double Total = (valor_adultos + valor_criancas);
                return Total;

            }
        }
    }
}
