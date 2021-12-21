using Albina.BusinesLogic.Core.Models;
using AutoMapper;
using Bor.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bor_Server.AutoMapperProfile
{
    public class MicroServiceProfile : Profile
    {
        CreateMap<UserInformationBlo, UserInformationDto>();
        CreateMap<UserIdentityBlo, UserIdentityDto>();
    }
}
