using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class TenderDetailDto: IDto
    {
        public int TenderId { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Job { get; set; }
        public string Corparation { get; set; }

        public string ImagePath { get; set; }
    }
}
