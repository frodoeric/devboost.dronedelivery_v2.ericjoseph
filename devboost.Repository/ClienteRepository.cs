using devboost.Domain.Model;
using devboost.Domain.Repository;
using devboost.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace devboost.Repository
{
    public class ClienteRepository: IClienteRepository
    {
        readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Cliente>> GetAll()
        {
            var clientes = await _dataContext.Cliente
                .Include(x => x.ClientePedidos)
                .ThenInclude(x => x.Cliente)
                .ThenInclude(x => x.User)
                .ToListAsync();

            return clientes;
        }
    }
}
