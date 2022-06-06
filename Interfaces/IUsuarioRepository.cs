using Chapter1000ton.Models;

namespace Chapter1000ton.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario usuario);

        void Atualizar(int id, Usuario usuario);

        void Deletar(int id);


        Usuario Login(string email, string senha);
    }
}
