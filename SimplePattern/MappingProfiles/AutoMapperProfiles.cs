using AutoMapper;
using Contracts.Dtos;
using Data.Models;

namespace SimplePattern.MappingProfiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Dapper, DapperDto>();
            CreateMap<DapperDto, Dapper>();
        }
    }
}
