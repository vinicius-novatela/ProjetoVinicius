using ProjetoVinicius.Domain.Entities;
using ProjetoVinicius.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVinicius.Infra.Data.Rpositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>
    {

        public Usuario GetUsuarioId(int id)
        {
            return Db.Usuario.Where(p => p.UsuarioId == id).FirstOrDefault();
        }

    }
}
