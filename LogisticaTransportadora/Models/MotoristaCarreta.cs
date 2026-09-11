using System;

namespace LogisticaTransportadora.Models
{
    
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
