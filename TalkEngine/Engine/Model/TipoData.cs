using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class TipoData: BaseModel
    {
        public string DataOriginal { get; set; }
        public DateTime Data { get; set; }        

        public static List<TipoData> GetTiposData()
        {
            List<TipoData> result = new List<TipoData>();

            result.Add(new TipoData { Nome = "DIA", Id = 0, Tipo = "E" }); // Data especifica
            result.Add(new TipoData { Nome = "DATA", Id = 0, Tipo = "E" }); // Data especifica

            result.Add(new TipoData { Nome = "AGORA", Id = 0, Tipo = "" });
            result.Add(new TipoData { Nome = "ACABEI DE", Id = 0, Tipo = "" });
            result.Add(new TipoData { Nome = "HOJE", Id = 0, Tipo = "" });
            result.Add(new TipoData { Nome = "ANTEONTEM", Id = -2, Tipo = "" });
            result.Add(new TipoData { Nome = " ONTEM", Id = -1, Tipo = "" });
            result.Add(new TipoData { Nome = "AMANHA", Id = 1, Tipo = "" });
            result.Add(new TipoData { Nome = "DEPOIS DE AMANHA", Id = 2, Tipo = "" });

            result.Add(new TipoData { Nome = "DOMINGO", Id = 1, Tipo = "S" });
            result.Add(new TipoData { Nome = "SEGUNDA", Id = 2, Tipo = "S" });
            result.Add(new TipoData { Nome = "TERCA", Id = 3, Tipo = "S" });
            result.Add(new TipoData { Nome = "QUARTA", Id = 4, Tipo = "S" });
            result.Add(new TipoData { Nome = "QUINTA", Id = 5, Tipo = "S" });
            result.Add(new TipoData { Nome = "SEXTA", Id = 6, Tipo = "S" });
            result.Add(new TipoData { Nome = "SABADO", Id = 7, Tipo = "S" });
            result.Add(new TipoData { Nome = "SEMANA PASSADA", Id = 7, Tipo = "S" });

            return result;
        }

        // Identificando a data por extenso
        public static string DataPorExtenso(string frase)
        {
            return "";
        }

        public static List<TipoData> IdentificarDatas(string frase)
        {
            return new List<TipoData>();
        }
    }
}
