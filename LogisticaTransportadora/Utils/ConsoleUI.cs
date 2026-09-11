using System;

namespace LogisticaTransportadora.Utils
{
    /// <summary>
    /// Pequenos helpers de apresentação para manter o Program.cs limpo.
    /// </summary>
    public static class ConsoleUI
    {
        public static void Cabecalho(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine($"  {titulo.ToUpper()}");
            Console.WriteLine("========================================================");
        }

        public static void Separador()
        {
            Console.WriteLine("--------------------------------------------------------");
        }

        public static void Rodape(string mensagem)
        {
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.WriteLine();
        }
    }
}
