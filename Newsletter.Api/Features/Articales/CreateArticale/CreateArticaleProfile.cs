using AutoMapper;
using Newsletter.Api.Entities;

namespace Newsletter.Api.Features.Articales.CreateArticale
{
    public class CreateArticaleProfile : Profile
    {
        public CreateArticaleProfile() {
            CreateMap<CreateArticaleRequest, Articale>();
              
        }
    }
}
