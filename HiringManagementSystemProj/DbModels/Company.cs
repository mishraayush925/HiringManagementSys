namespace HiringManagementSystemProj.DbModels
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }  // Navigation property
        public List<Job> Jobs { get; set; } = new List<Job>();
    }

}
