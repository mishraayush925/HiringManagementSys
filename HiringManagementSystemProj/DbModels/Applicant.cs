using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HiringManagementSystemProj.DbModels
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public string? ResumeUrl { get; set; }
        public long CurrentCTC { get; set; }
        public long ExpectedCTC { get; set; }
        public int Experience { get; set; }
        public string? TechStack { get; set; }
        public string? CurrentEmployer { get; set; }

        public virtual ICollection<Application>? Applications { get; set; }

    }

}
