using MoviesWebsite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWebsite.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Customer" : "New Customer";
            }
        }
        public int? Id { get; set; }

        [Required(ErrorMessage = "Plesae enter customer 's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Membership Type")]
        public byte? MembershipTypeId { get; set; }


        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            Birthdate = customer.Birthdate;
            MembershipTypeId = customer.MembershipTypeId;
        }

        public CustomerFormViewModel()
        {
            Id = 0;
        }
    }
}