using AutoMapper;
using Evolent.Model.Models;
using Evolent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evolent.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        /// <summary>
        /// Here we can configure our model to be mapped
        /// </summary>
        protected override void Configure()
        {
            Mapper.CreateMap<Contact, ContactViewModel>();
        }
    }
}