namespace HiringManagementSystemProj.DbModels
{
    public class Application
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        public DateTime AppliedOn { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } // "Pending", "Accepted", "Rejected"
    }

}
