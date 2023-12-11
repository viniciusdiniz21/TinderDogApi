using Dominio.Entities;


namespace Dados.Interface
{
    public interface IAuthRepositorio 
    {
        Task<Usuario> Cadastrar(Usuario usuario);
        Task<Usuario> BuscarUsuario(string usuario);
    }
}
