using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Tender tender = new Tender {
                TenderId = 1, Active =true, AdminId =12, Category="ev" , Price=100.000
            };
            Console.WriteLine("Tender Test");
            Console.WriteLine("Tender id: " + tender.TenderId);
            Console.WriteLine("Aktiflik durumu: " + tender.Active);
            Console.WriteLine("Admin Id: " + tender.AdminId);
            Console.WriteLine("Category: " + tender.Category);
            Console.WriteLine("Fiyat: " + tender.Price);


            Admin admin = new Admin
            {
                AdminId=5 , UserId= 34
            };
            Console.WriteLine("Admin Test");
            Console.WriteLine("Admin id: " + admin.AdminId + " UserId: " + admin.UserId);

            Client client = new Client
            {
                ClientId= 14 , UserId = 23
            };
            Console.WriteLine("Client Test");
            Console.WriteLine("Client Id: "+ client.ClientId + " UserId: " + client.UserId);

            Bid bid = new Bid
            {
                BidId = 32 , TenderId=13, ClientId=14
            };
            Console.WriteLine("Bid Test");
            Console.WriteLine("Bid id: " + bid.BidId + " Tender id: " + bid.TenderId + " Client Id:" + bid.ClientId);

           
        }
    }
}
