using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class WineRepository
    {
        public List<Wine> Wines { get; set; }
        public WineRepository()
        {
            Wines = new List<Wine>()
            {
                new Wine()
                {
                    Id = 1,
                    Name = "Pedrito",
                    Variety = "mail@mail.com",
                    Year = 1234,
                    Region = "password"
                },
                new Wine()
                {
                    Id = 1,
                    Name = "Pedrito",
                    Variety = "mail@mail.com",
                    Year = 1234,
                    Region = "password"
                },
                new Wine()
                {
                    Id = 1,
                    Name = "Pedrito",
                    Variety = "mail@mail.com",
                    Year = 1234,
                    Region = "password"
                },
                new Wine()
                {
                    Id = 1,
                    Name = "Pedrito",
                    Variety = "mail@mail.com",
                    Year = 1234,
                    Region = "password"
                }
            };
        }
    }
}
