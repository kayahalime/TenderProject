using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Admin: IEntity
    {
        public int AdminId { get; set; }
        public int UserId { get; set; }

    }
}
