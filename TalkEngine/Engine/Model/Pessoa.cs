using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Pessoa: BaseModel
    {
        public int TipoPessoaId { get; set; }

        public static List<Pessoa> GetPessoas()
        {
            List<Pessoa> result = new List<Pessoa>();

            result.Add(new Pessoa { Nome = "ROBSON", Id = 1, TipoPessoaId = 1 });
            result.Add(new Pessoa { Nome = "COMIGO", Id = 2, TipoPessoaId = 1 });

            // Amigos
            result.Add(new Pessoa { Nome = "MARCELO", Id = 3, TipoPessoaId = 4 });
            result.Add(new Pessoa { Nome = "RAIMO", Id = 4, TipoPessoaId = 4 });
            result.Add(new Pessoa { Nome = "GABRIEL", Id = 5, TipoPessoaId = 4 });
            result.Add(new Pessoa { Nome = "VICTOR", Id = 6, TipoPessoaId = 4 });
            result.Add(new Pessoa { Nome = "THIAGO", Id = 7, TipoPessoaId = 4 });
            
            // Irm�os
            result.Add(new Pessoa { Nome = "HUGO", Id = 22, TipoPessoaId = 5 });
            result.Add(new Pessoa { Nome = "ANA LUCIA", Id = 23, TipoPessoaId = 5 });
            result.Add(new Pessoa { Nome = "ANA PAULA", Id = 24, TipoPessoaId = 5 });
            result.Add(new Pessoa { Nome = "MARCELO", Id = 25, TipoPessoaId = 5 });

            // Parentes
            result.Add(new Pessoa { Nome = "LADIR", Id = 30 });
            result.Add(new Pessoa { Nome = "JOSE", Id = 31 });
            result.Add(new Pessoa { Nome = "FLAVIO", Id = 32 });
            result.Add(new Pessoa { Nome = "DIEGO", Id = 33 });
            result.Add(new Pessoa { Nome = "VIVIANE", Id = 34 });
            result.Add(new Pessoa { Nome = "MARCIA", Id = 35 });
            result.Add(new Pessoa { Nome = "FRANCISCO", Id = 36 });
            result.Add(new Pessoa { Nome = "VERA", Id = 37 });
            result.Add(new Pessoa { Nome = "LURDES", Id = 38 });
            result.Add(new Pessoa { Nome = "SILVANA", Id = 39 });

            // Testes
            result.Add(new Pessoa { Nome = "MARA", Id = 40 });

            return result;
        }

        // Identificando as pessoas
        public static List<Pessoa> IdentificarPessoas(string frase)
        {
            return new List<Pessoa>();
        }
    }
}
