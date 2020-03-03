using Seed.DAL.Interface;
using Seed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seed.DAL.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            return usuario;
        }
    }
}
