using ProjetoVinicius.Domain.Entities;
using ProjetoVinicius.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVinicius.Infra.Data.Rpositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>
    {

        public Pessoa GetPessoa(int id)
        {
            return Db.Pessoa.Where(p => p.IdPessoa == id).FirstOrDefault();
        }

    }
}
