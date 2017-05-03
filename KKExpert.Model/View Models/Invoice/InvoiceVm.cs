namespace KKExpert.Model.View_Models.Invoice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using KKExpert.Model.Entity_Models;
    using KKExpert.Model.Enums;

    public class InvoiceVm
    {
        public int id { get; set; }
        public string InvoiceNumber { get; set; }

      
        [DataType(DataType.Date)]
        public DateTime DateOfUssue { get; set; }

        [Required(ErrorMessage = "Please supply the title.")]
        [Display(Name = "Title")]
        public PaymentTypes PaymentMethod { get; set; }
        public decimal Price { get; set; }

        public string SelectedItem { get; set; }
        public virtual IList<Item> Items { get; set; }
    }
}
