using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudService1
{
    public class Group : IdEntity
    {
        [MaxLength(100)]
        [Required]
        public string Speciality { get; set; }
    }
}