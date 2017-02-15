using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class ParentsInfo : IdEntity
    {
        public ParentsInfo()
        {
            Phones = new List<Phone>();
        }
        [MaxLength(250)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string WorkPlace { get; set; }

        public virtual Relation Relation { get; set; }
        public virtual  ICollection<Phone> Phones { get; set; }
}
}