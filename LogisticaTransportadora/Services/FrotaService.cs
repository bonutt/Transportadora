using System;
using System.Collections.Generic;
using LogisticaTransportadora.Models;
using LogisticaTransportadora.Utils;

namespace LogisticaTransportadora.Services
{
   
    public class FrotaService
    {
        
        private readonly List<FuncionarioTransporte> _colaboradores = new List<FuncionarioTransporte>();

        public int TotalColaboradores => _colaboradores.Count;

        public void Cadastrar(FuncionarioTransporte colaborador)
        {
            if (colaborador == null)
                throw new ArgumentNullException(nameof(colaborador), "Colaborador inválido.");

            _colaboradores.Add(colaborador);
        }

        
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
