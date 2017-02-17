using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Phone : IdEntity
    {
        
        [Required]
        public string PhoneNumber { get; set; }

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