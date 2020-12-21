using AirLiquide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquide.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        Guid Incluir(TEntity entidade);
        void Excluir(Guid id);
        void Excluir(TEntity entidade);
        void Alterar(TEntity entidade);
        TEntity SelecionarPorId(Guid id);
        IEnumerable<TEntity> SelecionarTodos();
    }
}
