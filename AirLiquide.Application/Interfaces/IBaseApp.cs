using AirLiquide.Application.DTO;
using AirLiquide.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquide.Application.Interfaces
{
    public interface IBaseApp<TEntity, TEntityDTO>
        where TEntity : BaseEntity
        where TEntityDTO : BaseDTO
    {
        Guid Incluir(TEntityDTO entidade);
        void Excluir(Guid id);
        void Excluir(TEntityDTO entidade);
        void Alterar(TEntityDTO entidade);
        TEntityDTO SelecionarPorId(Guid id);
        IEnumerable<TEntityDTO> SelecionarTodos();
    }
}
