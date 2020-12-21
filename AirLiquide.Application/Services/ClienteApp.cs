using AirLiquide.Application.DTO;
using AirLiquide.Application.Interfaces;
using AirLiquide.Domain.Entities;
using AirLiquide.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquide.Application.Services
{
    public class ClienteApp : BaseServiceApp<Cliente, ClienteDTO>, IClienteApp
    {
      public ClienteApp(IMapper iMapper, IClienteService service): base(iMapper, service)
        {

        }
    }
}
