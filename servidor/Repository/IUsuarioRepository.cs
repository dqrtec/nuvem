using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface IUsuarioRepository : IDisposable
    {
        IEnumerable<Usuario> GetUsuarios();
        Usuario GetUsuarioByID(string apelido);
        void InsertUsuario(Usuario usuario);
        void DeleteUsuario(string apelido);
        // void UpdateUsuario(Usuario usuario);
        void Save();
    }
}