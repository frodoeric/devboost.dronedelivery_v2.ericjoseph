using System;
using System.Collections.Generic;
using System.Text;

namespace devboost.Domain.Model
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<ClientePedido> ClientePedidos { get; set; } = new List<ClientePedido>();
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
