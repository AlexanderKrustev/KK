namespace KKExpert.Web.Mapper
{
    using AutoMapper;
    using KKExpert.Model.View_Models.Manage;
    using Model.Entity_Models;

    public class UserVmToUser : Profile
    {
        protected  void Configure()
        {
            Mapper.Initialize(x =>
             x.CreateMap<UserVm, User>());
        }
    }
}