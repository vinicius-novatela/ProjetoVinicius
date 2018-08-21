using ProjetoVinicius.Domain.Entities;
using ProjetoVinicius.Infra.Data.Rpositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVinicius.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }
        public void Add(Usuario p)
        {
            _usuarioRepository.Add(p);
        }
        public void Remove(Usuario p)
        {
            _usuarioRepository.Remove(p);
        }
        public Usuario GetUsuarioId(int id)
        {
            return _usuarioRepository.GetUsuarioId(id);
        }

        public  void Update(Usuario obj)
        {
            _usuarioRepository.Update(obj);
        }


    }
}
