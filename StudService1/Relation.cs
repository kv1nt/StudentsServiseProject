using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudService1
{
    public class Relation : IdEntity
    {
        [MaxLength(250)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string WorkPlace { get; set; }


        public virtual List<Phone> Phones { get; set; }
}
}