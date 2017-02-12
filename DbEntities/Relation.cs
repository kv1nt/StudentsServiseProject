using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Relation : IdEntity
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

       
    }
}