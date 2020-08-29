using devboost.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace devboost.Domain.Repository
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetAll();
    }
}
