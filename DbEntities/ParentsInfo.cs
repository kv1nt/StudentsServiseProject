using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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

        public ParentsInfo Copy()
        {
            return new ParentsInfo
            {
                Relation = this.Relation?.Copy(),
                LastName = this.LastName,
                FirstName = this.FirstName,
                Phones = this.Phones?.Select(x => x.Copy()).ToList(),
                WorkPlace = this.WorkPlace,
                Id = this.Id
            };
        }
}
}