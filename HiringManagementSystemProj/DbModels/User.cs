using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HiringManagementSystemProj.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // "Admin", "Company", "Applicant"

        public Company? Company { get; set; }  // Nullable: Only for companies
        public Applicant? Applicant { get; set; }  // Nullable: Only for applicants
    }

}
