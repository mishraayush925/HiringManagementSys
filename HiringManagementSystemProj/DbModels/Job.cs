using static System.Net.Mime.MediaTypeNames;

namespace HiringManagementSystemProj.DbModels
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; } // "Full-Time", "Part-Time", "Remote"
        public decimal Salary { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public List<Application> Applications { get; set; } = new List<Application>();
    }

}
