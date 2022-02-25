using Common.Collection;
using Common.Mapping;
using Common.Paging;
using Domain;
using FoodTruckService.TDO_s;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodTruckService
{
    public  class FoodTruckClient : IFoodtruckClient
    {

        public  async Task<DataCollection<FoodTruckTDO>> GetFoodTruckByDatetime(string date, string time,int page, int take)
        {
            string url = "https://data.sfgov.org/resource/jjew-r69b.json";

            List<FoodTruckModel> food = new List<FoodTruckModel>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Fiddler");
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    using (HttpContent content = response.Content)
                    {
                        string result = await content.ReadAsStringAsync();
                        if (result != null)
                        {
                            food = JsonConvert.DeserializeObject<List<FoodTruckModel>>(result);
                        }
                    }
                   
                }
          
                var hora = Convert.ToDateTime(time).TimeOfDay.Hours;

                var collection = food.Where(x => x.dayorder == date && 
                                            Convert.ToDateTime(x.start24).TimeOfDay.Hours == hora 
                                            )
                                            .OrderByDescending(x => x.applicant)
                                            .ThenByDescending(x => x.optionaltext)
                                            .Select( x => new FoodTruckTDO
                                            {
                                            applicant = x.applicant,
                                            locationdesc = x.locationdesc
                                            })
                                            .GetPagedAsyncAsIENumerable(page, take);

                return collection.MapTo<DataCollection<FoodTruckTDO>>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

 

}
