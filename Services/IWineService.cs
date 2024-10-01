using Common.DTOs;
using Data.Entities;

namespace Services
{
    public interface IWineService
    {
        int addWine(VinoForCreateDTO vinoDelController);
        List<Wine> getAllWines();
        bool modifyStock(WineForModifyDTO wineForModify);
    }
}