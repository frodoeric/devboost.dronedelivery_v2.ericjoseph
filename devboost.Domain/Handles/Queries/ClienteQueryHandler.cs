using devboost.Domain.Handles.Queries.Interfaces;
using devboost.Domain.Model;
using devboost.Domain.Queries.Filters;
using devboost.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Queries
{
    public class ClienteQueryHandler : IClienteQueryHandler
    {
        readonly IClienteRepository _clienteRepository;

        public ClienteQueryHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _clienteRepository.GetAll();
        }
    }
}
