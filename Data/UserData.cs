using BECapstoneIronAssist.Models;

namespace BECapstoneIronAssist.Data
{
    public class UserData
    {
        public static List<User> Users = new()
        {
            new User
            {
                Id = 1,
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92",
                FirstName = "Zach",
                LastName = "Colburn",
                Email = "colburn.zach7@gmail.com",
                Role = "Operator"
            },
            new User
            {
                Id = 2,
                Uid = "D1zpqWr2bJUPO7YP39LkWPqMYu64",
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Role = "Mechanic"
            }
        };
    }
}
