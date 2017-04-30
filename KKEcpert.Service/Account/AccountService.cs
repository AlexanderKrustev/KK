namespace KKEcpert.Service.Account
{
    using System.Linq;
    using AutoMapper;
    using KKExpert.Model.Entity_Models;
    using KKExpert.Model.View_Models.Account;
    using KKExpert.Model.View_Models.Manage;

    public class AccountService : Service
    {
        
        public void RegisterUser(UserBm model, ApplicationUser user)
        {
            User entityUser = Mapper.Map<UserBm, User>(model);
           // entityUser.ApplicationUserId = user.Id;
            entityUser.ApplicationUser = user;
            this.Context.Users.Add(entityUser);
            this.Context.SaveChanges();

            
        }

        public UserVm GetUserInfo(string userId)
        {
            User user = this.Context.Users.FirstOrDefault(x => x.ApplicationUser.Id == userId);
            
            UserVm userVm = Mapper.Map<User, UserVm>(user);
           
            return userVm;
        }

        public void UpdateUser(UserBm userBm,string userId)
        {
            User user = this.Context.Users.FirstOrDefault(x => x.ApplicationUser.Id == userId);
            user.FirstName = userBm.FirstName;
            user.LastName = userBm.LastName;
            user.PhoneNumber = userBm.PhoneNumber;
            Context.SaveChanges();
        }
    }
}
