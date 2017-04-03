namespace KKEcpert.Service.Account
{
    using KKExpert.Model.Entity_Models;
    using KKExpert.Model.View_Models.Account;

    public class AccountService : Service
    {
        
        public void RegisterUser(RegisterViewModel model, ApplicationUser user)
        {
            var entityUser = new User()
            {
                //Id = user.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                ApplicationUserId = user.Id
            };

            this.Context.Users.Add(entityUser);
            this.Context.SaveChanges();
        }
    }
}
