using Common.Collection;
using FoodTruckService.TDO_s;
using System.Threading.Tasks;

namespace FoodTruckService
{
    public  interface IFoodtruckClient
    {
         Task<DataCollection<FoodTruckTDO>> GetFoodTruckByDatetime(string date, string time, int page, int take);
    }
}
