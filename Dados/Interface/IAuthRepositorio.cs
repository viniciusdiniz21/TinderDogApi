using Dominio.Entities;


namespace Dados.Interface
{
    public interface IAuthRepositorio 
    {
        Task<Usuario> Cadastrar(Usuario usuario);
        Usuario BuscarUsuario(string usuario);
    }
}
