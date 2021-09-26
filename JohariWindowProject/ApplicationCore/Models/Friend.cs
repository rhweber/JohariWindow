using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Friend
    {
        [Key]
        public int FriendID { get; set; }

        public string Relationship { get; set; }

        public string HowLong { get; set; }

        //Connect Objects or Tables
        //[ForeignKey("ASPNETUserID")]
        //public virtual ASPNETUserID ASPNETUserID { get; set; }
    }
}
