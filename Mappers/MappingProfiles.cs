using AutoMapper;
using DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mappers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Client, CreateClientDTO>().ReverseMap();
            CreateMap<Client, UpdateClientDTO>().ReverseMap();
            CreateMap<Client, ListClientDTO>().ReverseMap();
            CreateMap<Call, CreateCallDTO>().ReverseMap();
            CreateMap<Call, UpdateCallDTO>().ReverseMap();
            CreateMap<Call, ListCallDTO>().ReverseMap();
        }
    }
}
