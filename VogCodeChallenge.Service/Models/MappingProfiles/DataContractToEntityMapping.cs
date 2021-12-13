using AutoMapper;

namespace VogCodeChallenge.Service.Models.MappingProfiles
{
    public class DataContractToEntityMapping : Profile
    {
        public DataContractToEntityMapping()
        {
            CreateMap<DataAccess.Entities.Employee, Employee>();
            CreateMap<DataAccess.Entities.Address, Address>();
            CreateMap<DataAccess.Entities.Department, Department>();
        }
    }
}
