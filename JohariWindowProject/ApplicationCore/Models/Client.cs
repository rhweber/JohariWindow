using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required]
        [Display(Name = "First Name TEST")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        //Connect Objects or Tables
        //[ForeignKey("ASPNETUserID")]
        //public virtual ASPNETUserID ASPNETUserID { get; set; }
    }
}
