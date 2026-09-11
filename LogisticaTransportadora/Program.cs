using System;
using System.Text;
using LogisticaTransportadora.Models;
using LogisticaTransportadora.Services;
using LogisticaTransportadora.Utils;

namespace LogisticaTransportadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ConsoleUI.Cabecalho("Sistema de Logística - Controle de Frota");

            FrotaService frota = new FrotaService();

            
            frota.Cadastrar(new MotoristaCarreta(
                nome: "Carlos Eduardo Ramos",
                registro: "mt-1001",
                placaCarreta: "brl2k18",
                categoriaCnh: "E",
                capacidadeCargaToneladas: 27.5));

            frota.Cadastrar(new MotoristaCarreta(
                nome: "Fernanda Lopes",
                registro: "mt-1002",
                placaCarreta: "gjt4c92",
                categoriaCnh: "E",
                capacidadeCargaToneladas: 32.0));

            frota.Cadastrar(new EntregadorMoto(
                nome: "Rafael Souza",
                registro: "em-2001",
                placaMoto: "qpx7a33",
                categoriaCnh: "A",
                entregasPorDia: 45,
                regiaoAtendimento: "Zona Oeste - São Paulo/SP"));

            frota.Cadastrar(new EntregadorMoto(
                nome: "Juliana Prado",
                registro: "em-2002",
                placaMoto: "rtn9b07",
                categoriaCnh: "A",
                entregasPorDia: 38,
                regiaoAtendimento: "Centro - Osasco/SP"));

            
            frota.ListarDetalhes();

            ConsoleUI.Rodape($"Total de colaboradores cadastrados: {frota.TotalColaboradores}");

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
