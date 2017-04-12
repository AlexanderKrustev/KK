namespace KKExpert.Web.Mapper
{
    using System;
    using AutoMapper;
    using KKExpert.Model.Entity_Models;
    using Model.View_Models.Manage;

    public class UserToUserVm : Profile
    {
        protected void Configure()
        {
            Mapper.Initialize(x =>
                x.CreateMap<User, UserVm>()

                    .ForMember<string>(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                    .ForMember<string>(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                    .ForMember<string>(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber)));


        }
    }
}
