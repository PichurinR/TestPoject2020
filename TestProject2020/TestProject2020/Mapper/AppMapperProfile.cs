using AutoMapper;
using BAL.ViewModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject2020.Mapper
{
    public class AppMapperProfile : Profile
    {
        public AppMapperProfile()
        {
            CreateMap<DashboardVM, Dashboard>().ReverseMap();
            CreateMap<SectionVM, Section>().ReverseMap();
            CreateMap<TicketVM, Ticket>().ReverseMap();
        }
    }
}
