using AutoMapper;
using Common.Collection;
using Domain;
using FoodTruckService.TDO_s;
using Service.CRUD.DTO_s;

namespace Web.Api.Store.Mappers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<PlayThing, ToyDTO >();
            CreateMap<ToyDTO, PlayThing>();
            CreateMap<DataCollection<PlayThing>, DataCollection<ToyDTO>>();
            CreateMap<DataCollection<ToyDTO>, DataCollection<PlayThing>>();
            CreateMap<DataCollection<FoodTruckModel>,DataCollection<FoodTruckTDO>> ();
            CreateMap<DataCollection<FoodTruckTDO>, DataCollection<FoodTruckModel>>();
        }
    }
}
