using AutoMapper;
using Management.Services.Student.Core.Models.Responses;
using Entities = Management.Services.Student.Domain.Entities;

namespace Management.Services.Student.Core.Mapper
{
    public class DataMapperProfile : Profile
    {
        public DataMapperProfile()
        {
            this.CreateMap<Entities.Student, StudentResponse>();
        }

    }
}
