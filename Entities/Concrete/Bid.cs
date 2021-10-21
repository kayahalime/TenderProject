using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Bid: IEntity
    {
        public int BidId { get; set; }
        public int TenderId { get; set; }
        public int ClientId { get; set; }
        public double Price { get; set; }

    }
}
