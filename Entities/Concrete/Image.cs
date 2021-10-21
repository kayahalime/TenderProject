using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Image:IEntity
    {
        public int ImageId { get; set; }
        public int TenderId { get; set; }
        public string ImagePath { get; set; }

    }
}
