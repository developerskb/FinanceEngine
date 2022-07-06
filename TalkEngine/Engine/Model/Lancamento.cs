using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Lancamento
    {
        public string Frase { get; set; }
        public string FraseConvertida { get; set; }

        public List<Valor> Valores { get; set; } = new List<Valor>();
        public List<ReceitaDespesa> ReceitasDespesas { get; set; } = new List<ReceitaDespesa>();
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>();
        public List<TipoData> Datas { get; set; } = new List<TipoData>();

        public Lancamento()
        {

        }

        public Lancamento(string frase)
        {
            Frase = frase;
        }

        public void ProcessarFrase()
        {
            //fazer as conversões da frase
            FraseConvertida = Valor.ResolveFraseCentavos(Frase);
            Valores = Valor.BuscarValores(FraseConvertida);
            ReceitasDespesas = ReceitaDespesa.IdentificarDespesas(FraseConvertida);
            Pessoas = Pessoa.IdentificarPessoas(FraseConvertida);
            Datas = TipoData.IdentificarDatas(FraseConvertida);
        }

        public override string ToString()
        {
            var result = $"{Frase}\n{FraseConvertida}";
            result += "\nValores: " + String.Join(", ", Valores.Select(v => $"P({v.Index}) {v.ValorLancamento.ToString("0.00")}").ToArray());
            result += "\nDatas: " + Datas.Select(d => $"P({d.Index}) {d.Data.ToString()})");

            return result;
        }
    }
}
