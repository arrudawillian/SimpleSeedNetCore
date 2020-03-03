using Seed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seed.BLL.Interface
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> GetAll();
        Usuario GetById(int id);
    }
}
