using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudService1
{
    public class Phone : IdEntity
    {
        
        [Required]
        public int IdPhone { get; set; }
    }
}