using AutoMapper;
using InternLeaveandPayment.Domain.DTOs.Intern;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Mapper
{
    public class MyMapper : Profile
    {
        MapperConfiguration MapperConfiguration;
        public MyMapper()
        {
            CreateMap<InternAddDTO, Intern>().ReverseMap();
            

            

            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(this);
            });

        }

        public TCikis Map<TCikis, TGiris>(TGiris giris)
            where TGiris : class, new()
            where TCikis : class, new()
        {
            IMapper mapper = MapperConfiguration.CreateMapper();
            return mapper.Map<TCikis>(giris);
        }


    }
}
