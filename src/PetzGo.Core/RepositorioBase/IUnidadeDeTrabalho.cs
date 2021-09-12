using System.Threading.Tasks;

namespace PetzGo.Core.RepositorioBase
{
    public interface IUnidadeDeTrabalho
    {
        Task<bool> Commit();
    }
}
