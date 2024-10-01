using Common.DTOs;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class WineRepository : IWineRepository
    {
        public List<Wine> Wines { get; set; }
        public WineRepository()
        {
            Wines = new List<Wine>()
            {
                new Wine()
                {
                    Id = 1,
                    Name = "La Patada al higado",
                    Variety = "Malbec",
                    Year = 1980,
                    Region = "Mendoza",
                    Stock = 20
                },
                new Wine()
                {
                    Id = 2,
                    Name = "Vittorino",
                    Variety = "Cabernet",
                    Year = 2023,
                    Region = "La Pampa",
                    Stock = 5
                },
                new Wine()
                {
                    Id = 3,
                    Name = "Pedrito",
                    Variety = "Cabernet Suavignon",
                    Year = 1234,
                    Region = "password",
                    Stock = 15
                },
                new Wine()
                {
                    Id = 4,
                    Name = "Uvita",
                    Variety = "Veneno",
                    Year = 1000,
                    Region = "Purmamarca",
                    Stock = 3
                }
            };
        }

        //Metodo Para agregar vinos al repo
        public void addWine(Wine WineFromService)
        {
            Wines.Add(WineFromService);
        }

        //Metodo para consultar inventario de vinos
        public List<Wine> getAllWines()
        {
            return Wines;
        }

        //Metodo para actualizar stock
        public void updateStock(WineForModifyDTO wineForModify)
        {
            this.Wines.Find(u => u.Id == wineForModify.Id).Stock = wineForModify.NewStock;
        }
    }
}
