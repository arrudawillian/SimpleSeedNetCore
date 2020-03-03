using Seed.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Seed.DAL.Interface
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetAll();
        Usuario GetById(int id);

    }
}
