namespace KKEcpert.Service.Account
{
    using System.Linq;
    using AutoMapper;
    using KKExpert.Model.Binding_Models;
    using KKExpert.Model.Entity_Models;
    using KKExpert.Model.View_Models.Manage;

    public class AccountService : Service
    {
        
        public void RegisterUser(UserBm model, ApplicationUser user)
        {
            User entityUser = Mapper.Map<UserBm, User>(model);
            entityUser.ApplicationUserId = user.Id;

            this.Context.Users.Add(entityUser);
            this.Context.SaveChanges();
        }

        public UserVm GetUserInfo(string userId)
        {
            User user = this.Context.Users.FirstOrDefault(x => x.ApplicationUserId == userId);
           // UserVm userVm = Mapper.Map<User, UserVm>(user);
           UserVm userVm = new UserVm()
           {
               FirstName = user.FirstName,
               LastName = user.LastName,
               PhoneNumber = user.PhoneNumber
           };
            return userVm;
        }

        public void EditUser()
        {
            
        }
    }
}
