using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MovieCentralOne.Models;

namespace MovieCentralOne.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public byte MembershipTypeId { get; set; }
       // [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

    }

}