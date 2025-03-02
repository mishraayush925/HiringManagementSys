using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace HiringManagementSystemProj.DbModels
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("HiringPerson")]
        public int PostedBy { get; set; }
        public HiringPerson HiringPerson { get; set; }

        public DateTime ApplyBefore { get; set; }
        public long SalaryOffered { get; set; }
        public string SkillsRequired { get; set; }
        public int ExpRequired { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }

}
