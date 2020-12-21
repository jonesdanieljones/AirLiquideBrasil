using AirLiquide.Domain.Entities;
using AirLiquide.Domain.Interfaces.Repositories;
using AirLiquide.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace AirLiquide.Domain.Services
{
    public class BaseService<TEntidade> : IBaseService<TEntidade> where TEntidade : BaseEntity
    {
        protected readonly IBaseRepository<TEntidade> repository;

        public BaseService(IBaseRepository<TEntidade> repository)
        {
            this.repository = repository;
        }

        public void Alterar(TEntidade entidade)
        {
            repository.Alterar(entidade);
        }

        public void Excluir(Guid id)
        {
            repository.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            repository.Excluir(entidade);
        }

        public Guid Incluir(TEntidade entidade)
        {
            return repository.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(Guid id)
        {
            return repository.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return repository.SelecionarTodos();
        }
    }
}
