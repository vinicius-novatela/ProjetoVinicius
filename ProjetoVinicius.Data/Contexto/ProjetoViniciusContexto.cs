
using ProjetoVinicius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoVinicius.Infra.Data.Contexto
{
    public class ProjetoViniciusContexto : DbContext
    {
        public ProjetoViniciusContexto() : base("ProjetoViniciusConection")
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
