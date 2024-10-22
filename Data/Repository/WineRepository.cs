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

        private readonly ApplicationContext _context;
        public WineRepository(ApplicationContext context)
        {
            _context = context;
        }

        //Metodo Para agregar vinos al repo
        public void addWine(Wine wineFromService)
        {
            _context.Add(wineFromService);
        }

        //Metodo para consultar inventario de vinos
        public List<Wine> getAllWines()
        {
            return _context.Wines.ToList();
        }

        //Metodo para actualizar stock
        public void updateStock(WineForModifyDTO wineForModify)
        {
            _context.Wines.Find(u => u.Id == wineForModify.Id).Stock = wineForModify.NewStock;
        }
    }
}
