using BookProject.Models;

namespace Books2Project.Model
{
    public class Role
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }
        
        public ICollection<User> Users { get; set; }
    }
}
