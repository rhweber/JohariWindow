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
    public class Friend : IdentityUser
    {
        
        //public string FriendsClientId { get; set; }
        
        //[ForeignKey("FirstName")]
        //public string FirstName { get; set; }

        //[ForeignKey("LastName")]
        //public string LastName { get; set; }

        public string Relationship { get; set; }

        public string HowLong { get; set; }
    }
}
