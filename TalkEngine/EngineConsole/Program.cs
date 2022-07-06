using System;

namespace EngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //testar valor
            string fraseTeste = "gastei r$ 5 no dia primeiro.de abril de 22 e mais r$ 12 no dia 3 de abril de 1999"; //"gastei 50 centavos no sacolao"; //"gastei r$ 10 com 983 centavos com velas";

            Engine.Model.Lancamento lancamento = new Engine.Model.Lancamento(fraseTeste);
            lancamento.ProcessarFrase();

            //Console.WriteLine("Original " + fraseTeste);
            //Console.WriteLine("Resultado " + lancamento.FraseConvertida);
            Console.WriteLine(lancamento.ToString());

            Console.ReadKey();
        }
    }
}
