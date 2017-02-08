using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudService1
{
    public class ParentsInfo : IdEntity
    {
        [MaxLength(250)]
        [Required]
        public string MotherFirstName { get; set; }
        [Required]
        public string MotherSecondName { get; set; }
        [Required]
        public string FatherFirstName { get; set; }
        [Required]
        public string FatherSecondName { get; set; }
        [Required]
        public string MotherWorkPlace { get; set; }
        [Required]
        public string FatherWorkPlace { get; set; }


        public virtual Relation Relation { get; set; }
        public virtual  Phone Phone{ get; set; }
}
}