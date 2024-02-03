using AutoMapper;
using Newsletter.Api.Entities;

namespace Newsletter.Api.Features.Articales.EditArticale
{
    public class EditArticaleProfile : Profile
    {
        public EditArticaleProfile() {
            CreateMap<EditArticaleRequest, Articale>();
              
        }
    }
}
