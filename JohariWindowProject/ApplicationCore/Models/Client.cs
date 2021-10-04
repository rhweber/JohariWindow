using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Client : IdentityUser
    {
        [ForeignKey("FirstName")]
        public string FirstName { get; set; }

        [ForeignKey("LastName")]
        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }
    }
}
