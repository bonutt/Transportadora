using System;
using System.Collections.Generic;
using LogisticaTransportadora.Models;
using LogisticaTransportadora.Utils;

namespace LogisticaTransportadora.Services
{
    /// <summary>
    /// Camada de serviço: concentra o cadastro e a listagem dos colaboradores da frota.
    /// </summary>
    public class FrotaService
    {
        // A lista é do tipo da classe base — é isso que permite o polimorfismo.
        private readonly List<FuncionarioTransporte> _colaboradores = new List<FuncionarioTransporte>();

        public int TotalColaboradores => _colaboradores.Count;

        public void Cadastrar(FuncionarioTransporte colaborador)
        {
            if (colaborador == null)
                throw new ArgumentNullException(nameof(colaborador), "Colaborador inválido.");

            _colaboradores.Add(colaborador);
        }

        /// <summary>
        /// Percorre a frota chamando MostrarDetalhes(). Em tempo de execução o CLR
        /// resolve qual override será executado para cada objeto.
        /// </summary>
        public void ListarDetalhes()
        {
            if (_colaboradores.Count == 0)
            {
                Console.WriteLine("Nenhum colaborador cadastrado na frota.");
                return;
            }

            foreach (FuncionarioTransporte colaborador in _colaboradores)
            {
                ConsoleUI.Separador();
                colaborador.MostrarDetalhes();
            }

            ConsoleUI.Separador();
        }
    }
}
