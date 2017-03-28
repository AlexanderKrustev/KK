namespace KKExpert.Model.Entity_Models
{
    using System.ComponentModel.DataAnnotations;

    public class User 
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ApplicationUser Type { get; set; }
    }
}
