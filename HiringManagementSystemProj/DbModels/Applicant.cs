namespace HiringManagementSystemProj.DbModels
{
    public class Applicant
    {
        public int Id { get; set; }
        public string ResumeUrl { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Application> Applications { get; set; } = new List<Application>();
    }

}
