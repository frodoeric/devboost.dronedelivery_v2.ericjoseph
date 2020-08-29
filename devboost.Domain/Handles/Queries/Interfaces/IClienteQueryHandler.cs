using devboost.Domain.Model;
using devboost.Domain.Queries.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Queries.Interfaces
{
    public interface IClienteQueryHandler
    {
        Task<List<Cliente>> GetAll();
        
    }
}
