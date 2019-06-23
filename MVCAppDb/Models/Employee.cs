using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAppDb.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Display(Name ="Confirm Email")]
        [Compare("Email")]
        [NotMapped]
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid email address")]
        public string ConfirmEmail { get; set; }

        public string Password { get; set; }
    }
}