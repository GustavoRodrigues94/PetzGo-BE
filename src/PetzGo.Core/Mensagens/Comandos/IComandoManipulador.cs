using System.Threading.Tasks;

namespace PetzGo.Core.Mensagens.Comandos
{
    public interface IComandoManipulador<in T> where T : IComando
    {
        Task<ComandoResultado> Manipular(T comando);
    }
}
