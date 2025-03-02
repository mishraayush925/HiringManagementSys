using System.ComponentModel.DataAnnotations;

namespace HiringManagementSystemProj.DbModels
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public string Location { get; set; }

        public virtual ICollection<HiringPerson> HiringPersons { get; set; }
    }

}
