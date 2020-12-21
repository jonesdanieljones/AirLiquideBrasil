using AirLiquide.Domain.Entities;
using AirLiquide.Domain.Interfaces.Repositories;
using AirLiquide.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquide.Domain.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IClienteRepository repository) : base(repository)
        {

        }
    }
}
