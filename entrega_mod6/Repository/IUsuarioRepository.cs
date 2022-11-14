using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maria's Tour.Model;

namespace Maria's Tour.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        void AddUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        void DeletarUsuario(Usuario usuario);

        Task<bool> SaveChangesAsync();
    }
}