using AutoMapper;
using Evolent.Model.Models;
using Evolent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evolent.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ContactFormViewModel, Contact>()
                .ForMember(c => c.FirstName, map => map.MapFrom(vm => vm.showFirstName))
                .ForMember(c => c.LastName, map => map.MapFrom(vm => vm.showLastName))
                .ForMember(c => c.Email, map => map.MapFrom(vm => vm.showEmail))
                .ForMember(c => c.MobileNumber, map => map.MapFrom(vm => vm.showMobileNumber))
                .ForMember(c => c.ID, map => map.MapFrom(vm => vm.showId));
        }
    }
}