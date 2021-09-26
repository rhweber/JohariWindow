using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Adjective
    {
        [Key]
        public int AdjectiveID { get; set; }

        public string AdjectiveName { get; set; }

        public string AdjectiveDefinition { get; set; }

        public bool AdjectiveType { get; set; }
    }
}
