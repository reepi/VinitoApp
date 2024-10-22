using Common.DTOs;
using Data.Entities;

namespace Data.Repository
{
    public interface IWineRepository
    {
        void addWine(Wine WineFromService);
        List<Wine> getAllWines();
        void updateStock(WineForModifyDTO wineForModify);
    }
}