using Seed.BLL.Interface;
using Seed.DAL.Interface;
using Seed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seed.BLL.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            return _usuarioRepository.GetById(id);
        }
    }
}
