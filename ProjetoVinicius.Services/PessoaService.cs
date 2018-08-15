using ProjetoVinicius.Domain.Entities;
using ProjetoVinicius.Infra.Data.Rpositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVinicius.Services
{
    public class PessoaService
    {
        private readonly PessoaRepository _PessoaRepository;

        public PessoaService()
        {
            _PessoaRepository = new PessoaRepository();
        }
        public IEnumerable<Pessoa> GetAll()
        {
            return _PessoaRepository.GetAll();
        }
        public void Add(Pessoa p)
        {
            _PessoaRepository.Add(p);
        }
        public void Remove(Pessoa p)
        {
            _PessoaRepository.Remove(p);
        }
        public Pessoa GetPessoa(int id)
        {
            return _PessoaRepository.GetPessoa(id);
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return _PessoaRepository.Update(pessoa);
        }


    }
}
