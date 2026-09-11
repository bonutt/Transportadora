using System;

namespace LogisticaTransportadora.Models
{
    /// <summary>
    /// Colaborador responsável pelo transporte de cargas pesadas em carreta.
    /// Herda de FuncionarioTransporte.
    /// </summary>
    public class MotoristaCarreta : FuncionarioTransporte
    {
        private string _placaCarreta = string.Empty;

        public string PlacaCarreta
        {
            get => _placaCarreta;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A placa da carreta não pode ser vazia.");

                _placaCarreta = value.Trim().ToUpper();
            }
        }

        public string CategoriaCnh { get; private set; }

        public double CapacidadeCargaToneladas { get; private set; }

        /// <summary>
        /// Invoca o construtor da classe pai com base e complementa com os
        /// atributos próprios do motorista de carreta.
        /// </summary>
        public MotoristaCarreta(
            string nome,
            string registro,
            string placaCarreta,
            string categoriaCnh,
            double capacidadeCargaToneladas)
            : base(nome, registro)
        {
            PlacaCarreta = placaCarreta;
            CategoriaCnh = categoriaCnh;
            CapacidadeCargaToneladas = capacidadeCargaToneladas;
        }

        /// <summary>
        /// Sobrescreve o método da classe base para exibir as particularidades
        /// operacionais do transporte rodoviário de carga.
        /// </summary>
        public override void MostrarDetalhes()
        {
            Console.WriteLine("Função........: Motorista de Carreta");
            base.MostrarDetalhes();
            Console.WriteLine($"Placa carreta.: {PlacaCarreta}");
            Console.WriteLine($"CNH categoria.: {CategoriaCnh}");
            Console.WriteLine($"Capacidade....: {CapacidadeCargaToneladas:F1} toneladas");
            Console.WriteLine("Operação......: viagens intermunicipais e interestaduais de longa distância");
        }
    }
}
