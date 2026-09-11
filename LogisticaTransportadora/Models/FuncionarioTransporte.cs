using System;

namespace LogisticaTransportadora.Models
{
    
    public abstract class FuncionarioTransporte
    {
        
        private string _nome = string.Empty;
        private string _registro = string.Empty;

        
        public string Nome
        {
            get => _nome;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome do colaborador não pode ser vazio.");

                _nome = value.Trim();
            }
        }

        
        public string Registro
        {
            get => _registro;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O registro do colaborador não pode ser vazio.");

                _registro = value.Trim().ToUpper();
            }
        }

        
        protected FuncionarioTransporte(string nome, string registro)
        {
            Nome = nome;
            Registro = registro;
        }

        
        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Colaborador...: {Nome}");
            Console.WriteLine($"Registro......: {Registro}");
        }
    }
}
