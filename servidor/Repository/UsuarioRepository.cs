using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using Model;
using Contexto;

namespace Repository
{
    class UsuarioRepository : IUsuarioRepository, IDisposable
    {
        private UsuarioContext context;

        public UsuarioRepository(UsuarioContext context)
        {
            this.context = context;
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return context.Usuarios.ToList();
        }

        public Usuario GetUsuarioByID(string apelido)
        {
            return context.Usuarios.Find(apelido);
        }

        public void InsertUsuario(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
        }

        public void DeleteUsuario(string apelido)
        {
            Usuario usuario = context.Usuarios.Find(apelido);
            context.Usuarios.Remove(usuario);
        }

        // public void UpdateUsuario(Usuario usuario)
        // {
        //     context.Entry(usuario).State = EntityState.Modified;
        // }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}