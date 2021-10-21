using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Client:IEntity
    {
        public int ClientId { get; set; }
        public int UserId { get; set; }

    }
}
