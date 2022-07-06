using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Cartao: BaseModel
    {

        public List<Cartao> GetCartoes()
        {
            List<Cartao> result = new List<Cartao>();
         
            result.Add(new Cartao { Nome = "DEBITO", Id = 1 });
            result.Add(new Cartao { Nome = "CAIXA", Id = 2 });
            result.Add(new Cartao { Nome = "BB", Id = 3 });
            result.Add(new Cartao { Nome = "MASTERCARD", Id = 4 });
            result.Add(new Cartao { Nome = "MINHA CONTA", Id = 5 });
            result.Add(new Cartao { Nome = "SUBMARINO", Id = 6 });

            return result;
        }
    }
}
