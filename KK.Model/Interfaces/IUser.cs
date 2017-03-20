namespace KK.Model.Interfaces
{
    using System.Collections;
    using System.Collections.Generic;
    using KK.Model.Entities;

    public interface IUser
    {
        int Id { get; }
        string Name { get; set; }

        string Username { get; set; }

        string Password { get; set; }

        string Role { get; set; }

        IDictionary<string, bool> Rights { get; set; }

        IList<Sale> Sales { get; set; }
    }
}
