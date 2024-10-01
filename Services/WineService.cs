using Common.DTOs;
using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WineService : IWineService
    {
        #region Inyección de WineRepo
        private readonly IWineRepository _wineRepo;
        public WineService(IWineRepository wineRepo)
        {
            _wineRepo = wineRepo;
        }
        #endregion
        public List<Wine> getAllWines()
        {
            List<Wine> wineList = _wineRepo.getAllWines();
            return wineList;
        }

        public int addWine(VinoForCreateDTO vinoDelController)
        {
            Wine newWine = new Wine()
            {
                Id = _wineRepo.Wines.Count + 1,
                Name = vinoDelController.Name,
                Variety = vinoDelController.Variety,
                Region = vinoDelController.Region,
                Year = vinoDelController.Year,
                Stock = vinoDelController.Stock,
                CreatedAt = vinoDelController.CreatedAt,

            };
            _wineRepo.addWine(newWine);

            return newWine.Id;
        }

        public bool modifyStock(WineForModifyDTO wineForModify)
        {

            if (_wineRepo.Wines.Find(u => u.Id == wineForModify.Id) != null)
            {
                _wineRepo.updateStock(wineForModify);
                return true;
            }
            else
            {
                return false;
            }
        }
    };
}
