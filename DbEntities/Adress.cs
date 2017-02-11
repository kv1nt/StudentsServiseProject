using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Adress : IdEntity
    {
        [MaxLength(100)]
        [Required]
        public string Address { get; set; }
    }
}