using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Phone : IdEntity
    {
        
        [Required]
        public int PhoneNumber { get; set; }

        public Phone Copy()
        {
            return new Phone
            {
                PhoneNumber = this.PhoneNumber,
                Id = this.Id
            };
        }
    }
}