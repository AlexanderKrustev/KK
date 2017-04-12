namespace KKExpert.Web.Mapper
{
    using AutoMapper;
    using Model.Binding_Models;
    using Model.Entity_Models;

    public class UserBmToUser : Profile
    {
        protected void Configure()
            {
                Mapper.Initialize(x =>
                 x.CreateMap<UserBm, User>());
            }
        }
    }
