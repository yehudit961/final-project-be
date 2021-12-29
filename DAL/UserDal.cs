using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDal
    {
        public static IEnumerable<User> GetUsers()
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Users.ToList();
            }
        }

        public static User GetUser(int id)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Users.Single(u => u.Id == id);
            }
        }

        public static User AddUser(User user)
        {
            User newUser = null;
            using(AmusementParkEntities ctx = new AmusementParkEntities())
            {
                newUser = ctx.Users.Add(user);
                ctx.SaveChanges();
            }
            return newUser;
        }


        
    }
}
