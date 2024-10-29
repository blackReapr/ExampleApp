using AutoMapper;
using FullIdentity.Data.Entities;
using FullIdentity.Dtos.CustomerDtos;

namespace FullIdentity.MapperProfiles;

public class BaseMapper : Profile
{
    public BaseMapper()
    {
        CreateMap<CustomerCreateDto, Customer>();
    }
}
