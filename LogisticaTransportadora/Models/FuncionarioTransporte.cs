using System;

namespace LogisticaTransportadora.Models
{
    /// <summary>
    /// Classe base abstrata que representa, de forma genérica, um colaborador
    /// da transportadora. Por ser abstrata, não pode ser instanciada diretamente.
    /// </summary>
    public abstract class FuncionarioTransporte
    {
        // Campos privados: o estado fica protegido contra acesso externo.
        private string _nome = string.Empty;
        private string _registro = string.Empty;

        /// <summary>
        /// Nome do colaborador. Leitura pública, escrita restrita à hierarquia
        /// e validada para não aceitar valores vazios.
        /// </summary>
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

        /// <summary>
        /// Registro (matrícula) do colaborador. Mesmo padrão de encapsulamento do nome.
        /// </summary>
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

        /// <summary>
        /// Construtor da classe base: inicializa as propriedades comuns a todos
        /// os colaboradores. É protected para reforçar que só as filhas o utilizam.
        /// </summary>
        protected FuncionarioTransporte(string nome, string registro)
        {
            Nome = nome;
            Registro = registro;
        }

        /// <summary>
        /// Método virtual: exibe os dados comuns e pode ser sobrescrito (override)
        /// pelas classes derivadas para acrescentar as particularidades de cada função.
        /// </summary>
        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Colaborador...: {Nome}");
            Console.WriteLine($"Registro......: {Registro}");
        }
    }
}
