using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Operacao: BaseModel
    {        
        public List<Operacao> GetOperacoes()
        {
            List<Operacao> result = new List<Operacao>();

            result.Add(new Operacao { Nome = "GASTO", Id = 1, Tipo = "D" });
            result.Add(new Operacao { Nome = "GASTEI", Id = 2, Tipo = "D" });
            result.Add(new Operacao { Nome = "GASTAR", Id = 3, Tipo = "D" });
            result.Add(new Operacao { Nome = "USEI", Id = 4, Tipo = "D" });
            result.Add(new Operacao { Nome = "COMPREI", Id = 5, Tipo = "D" });
            result.Add(new Operacao { Nome = "COMPRAS", Id = 6, Tipo = "D" });
            result.Add(new Operacao { Nome = "COMPRANDO", Id = 7, Tipo = "D" });
            result.Add(new Operacao { Nome = "COMPRAR", Id = 8, Tipo = "D" });
            result.Add(new Operacao { Nome = "DESPESA", Id = 9, Tipo = "D" });
            result.Add(new Operacao { Nome = "PERDI", Id = 10, Tipo = "D" });
            result.Add(new Operacao { Nome = "EMPRESTEI", Id = 11, Tipo = "D" });

            result.Add(new Operacao { Nome = "GANHEI", Id = 15, Tipo = "C" });
            result.Add(new Operacao { Nome = "RECEBI", Id = 16, Tipo = "C" });
            result.Add(new Operacao { Nome = "PREMIO", Id = 17, Tipo = "C" });
            result.Add(new Operacao { Nome = "MEU VALE", Id = 18, Tipo = "C" });
            result.Add(new Operacao { Nome = "SALARIO", Id = 19, Tipo = "C" });

            result.Add(new Operacao { Nome = "ABASTECI", Id = 25, Tipo = "D" });
            result.Add(new Operacao { Nome = "ABASTECER", Id = 26, Tipo = "D" });
            result.Add(new Operacao { Nome = "ENVIEI", Id = 27, Tipo = "D" });
            result.Add(new Operacao { Nome = "TRANSFERI", Id = 28, Tipo = "D" });
            result.Add(new Operacao { Nome = "ME DEVE", Id = 29, Tipo = "C" });
            result.Add(new Operacao { Nome = "SAQUEI", Id = 30, Tipo = "D" });
            result.Add(new Operacao { Nome = "VOU SACAR", Id = 31, Tipo = "D" });
            result.Add(new Operacao { Nome = "RETIREI", Id = 32, Tipo = "D" });

            return result;
        }
    }
}
