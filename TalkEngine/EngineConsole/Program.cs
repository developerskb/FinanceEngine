using System;
using Engine.Model;
using Engine.Utils;

namespace EngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //testar valor
            var c = 0;
            var txt = TextFile.GetTxt();
            foreach( string frase in txt )
            {
                c++;
                Lancamento lancamento = new Lancamento(frase, "robson" );
                lancamento.ProcessarFrase();
                var lancamentoTexto = lancamento.ToString();
                Console.WriteLine(lancamentoTexto);



                /*if( txt.Length - 3 == c  || c == 3) break;*/
                /*break;*/
                /*if (Console.ReadKey().Key.ToString().ToLower() == "numpad0") break;*/
            }

        }
    }
}
