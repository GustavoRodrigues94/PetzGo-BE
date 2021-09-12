using System;
using PetzGo.Core.DominioBase;

namespace PetzGo.Core.RepositorioBase
{
    public interface IRepositorio<T> : IDisposable where T : IRaizAgregacao 
    {
        IUnidadeDeTrabalho UnidadeDeTrabalho { get; }
    }
}
