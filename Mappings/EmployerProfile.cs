using AutoMapper;
using employer_api.DTOs;
using employer_api.Models.Entities;

namespace employer_api.Mappings;

public class EmployerProfile : Profile
{
    public EmployerProfile()
    {
        CreateMap<EmployerInputDto, Employer>();
        CreateMap<Employer, EmployerOutputDto>();
    }
}
