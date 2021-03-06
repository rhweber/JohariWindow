using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class ClientResponse
    {
        [Key]
        public int ClientResponseID { get; set; }

        //Connect Objects or Tables
        [ForeignKey("AdjectiveID")]
        public int AdjectiveID { get; set; }

        [ForeignKey("ClientID")]
        public int ClientID { get; set; }
    }
}
