using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiringManagementSystemProj.DbModels
{
    public class Application
    {
       [Key]
    public int Id { get; set; }

    [ForeignKey("Applicant")]
    public int ApplicantId { get; set; }
    public Applicant Applicant { get; set; }

    public DateTime AppliedOn { get; set; }

    [ForeignKey("Job")]
    public int AppliedFor { get; set; }

    public byte Status { get; set; }
    public Job Job { get; set; }
    }

}
