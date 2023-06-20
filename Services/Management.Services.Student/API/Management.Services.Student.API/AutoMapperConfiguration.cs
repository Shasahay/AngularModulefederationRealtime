using AutoMapper;
using Management.Services.Student.API.Extensions;
using Management.Services.Student.Core.Mapper;

namespace Management.Services.Student.API
{
    public class AutoMapperConfiguration
    {
        public IMapper Configure()
        {
            var profiles = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(a => typeof(DataMapperProfile).IsAssignableFrom(a));

            // Initialize AutoMapper with each instance of profiles found

            var mapperConfiguration = new MapperConfiguration(m => profiles.ForEach(m.AddProfile));
            return mapperConfiguration.CreateMapper();

        }
    }
}
