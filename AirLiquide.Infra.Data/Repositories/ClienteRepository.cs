using AirLiquide.Domain.Entities;
using AirLiquide.Domain.Interfaces.Repositories;
using AirLiquide.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquide.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(DBLiquideContext contexto) : base(contexto)
        {
        }
    }
}
