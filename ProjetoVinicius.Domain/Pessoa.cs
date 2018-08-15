using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVinicius.Domain.Entities
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public string sexo { get; set; }
        public DateTime? Data { get; set; }
    }
}
