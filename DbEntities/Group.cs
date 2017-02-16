using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Group : IdEntity
    {
        [MaxLength(100)]
        [Required]
        public string Speciality { get; set; }

        public Group Copy()
        {
            return new Group
            {
                Speciality = this.Speciality,
                Id = this.Id
            };
        }
    }
}