using System;

namespace LogisticaTransportadora.Models
{
    /// <summary>
    /// Colaborador responsável pelas entregas rápidas de última milha em motocicleta.
    /// Herda de FuncionarioTransporte.
    /// </summary>
    public class EntregadorMoto : FuncionarioTransporte
    {
        private string _placaMoto = string.Empty;

        public string PlacaMoto
        {
            get => _placaMoto;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A placa da moto não pode ser vazia.");

                _placaMoto = value.Trim().ToUpper();
            }
        }

        public string CategoriaCnh { get; private set; }

        public int EntregasPorDia { get; private set; }

        public string RegiaoAtendimento { get; private set; }

        /// <summary>
        /// Invoca o construtor da classe pai com base e complementa com os
        /// atributos próprios do entregador de moto.
        /// </summary>
        public EntregadorMoto(
            string nome,
            string registro,
            string placaMoto,
            string categoriaCnh,
            int entregasPorDia,
            string regiaoAtendimento)
            : base(nome, registro)
        {
            PlacaMoto = placaMoto;
            CategoriaCnh = categoriaCnh;
            EntregasPorDia = entregasPorDia;
            RegiaoAtendimento = regiaoAtendimento;
        }

        /// <summary>
        /// Sobrescreve o método da classe base para exibir as particularidades
        /// operacionais da entrega de última milha.
        /// </summary>
        public override void MostrarDetalhes()
        {
            Console.WriteLine("Função........: Entregador de Moto");
            base.MostrarDetalhes();
            Console.WriteLine($"Placa moto....: {PlacaMoto}");
            Console.WriteLine($"CNH categoria.: {CategoriaCnh}");
            Console.WriteLine($"Meta diária...: {EntregasPorDia} entregas");
            Console.WriteLine($"Região........: {RegiaoAtendimento}");
            Console.WriteLine("Operação......: entregas expressas de última milha dentro do perímetro urbano");
        }
    }
}
