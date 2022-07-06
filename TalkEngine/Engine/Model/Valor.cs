using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Valor: BaseModel
    {
        public decimal ValorLancamento { get; set; }        

        static List<string> GetTagsCentavos()
        {
            return new List<string> { "CENTAVOS" };
        }

        public static string ResolveFraseCentavos(string frase)
        {            
            string aFrase = frase.ToUpper();    
            //Get tags
            var tagsCentavos = GetTagsCentavos();

            //padroes de pesquisa
            string regExpCents = "[1-9]+[0-9]*";
            string regExpValor = @"(\d+|\d{1,3}(.\d{3})*)(\,\d+)";
            //converter decimal com ','
            System.Globalization.CultureInfo fp = new System.Globalization.CultureInfo("pt-BR");

            foreach (string tag in tagsCentavos)
            {
                //pegar a substring de centavos
                int indexTag = aFrase.IndexOf(tag);
                int indexReal = aFrase.IndexOf("R$");
                if (indexTag > -1)
                {
                    string fraseReal = aFrase.Substring(0, indexTag + tag.Length);
                    fraseReal = fraseReal.Substring(fraseReal.LastIndexOf("R$") > -1 ? fraseReal.LastIndexOf("R$") : fraseReal.IndexOf(" ")).Trim();

                    decimal valorCents = 0;
                    decimal valor = 0;

                    var matchCents = Regex.Matches(fraseReal, regExpCents);
                    if (matchCents.Count > 0)
                    {
                        // o último valor é centavos
                        Match matchCentavos = matchCents.LastOrDefault();
                        {
                            var cents = Convert.ToInt32(matchCentavos.Value);
                            valorCents += Convert.ToDecimal(cents) / 100m;
                        }
                        if (matchCents.Count > 1)
                        {
                            //se tiver mais de um o primeiro é reais
                            Match matchValor = matchCents.FirstOrDefault();
                            var reais = Convert.ToInt32(matchValor.Value);
                            valor += reais;
                        }
                    }
                    var matchReais = Regex.Matches(fraseReal, regExpValor);
                    if (matchReais.Count > 0)
                    {
                        var reais = Convert.ToDecimal(matchReais[0].Value, fp);
                        valor += reais;
                    }
                    valor += valorCents;
                    aFrase = aFrase.Replace(fraseReal, "R$ " + valor.ToString());
                }
            }



            return aFrase;
        }

        // Buscando todos os valores da frase
        public static List<Valor> BuscarValores(string frase)
        {
            var result = new List<Valor>();

            string regExpInteiro = @"\b(R\$ )\b[1-9]+[0-9]*";
            string regExpValor = @"\b(R\$ )\b(\d+|\d{1,3}(.\d{3})*)(\,\d+)";
            //converter decimal com ','
            System.Globalization.CultureInfo fp = new System.Globalization.CultureInfo("pt-BR");

            var matchInts = Regex.Matches(frase, regExpInteiro);
            if (matchInts.Count > 0)
            {
                foreach (Match match in matchInts)
                {
                    var reais = Convert.ToDecimal(match.Value.Replace("R$", "").Trim(), fp);
                    result.Add(new Valor { ValorLancamento = reais, Index = match.Index });
                }
            }

            var matchReais = Regex.Matches(frase, regExpValor);
            if (matchReais.Count > 0)
            {
                foreach (Match match in matchReais)
                {
                    var reais = Convert.ToDecimal(match.Value.Replace("R$", "").Trim(), fp);
                    result.Add(new Valor { ValorLancamento = reais, Index = match.Index });
                }
            }

            
            return result;
        }
    }
}
