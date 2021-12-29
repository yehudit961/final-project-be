using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
   public class UserBL
   {
        public static IEnumerable<UserDTO> GetUsers()
        {
            var users = UserDal.GetUsers();

            foreach (var item in users)
            {
                yield return Conversions.Map(item);
            }           
        }

        public static UserDTO GetUser(int id)
        {
            //return Converter.ConvertToDTO( UserDal.GetUser(id));
            return Conversions.Map(UserDal.GetUser(id));
        }

        public static UserDTO AddUser(UserDTO user)
        {
            return Conversions.Map(UserDal.AddUser(Conversions.Map(user)));
        }

        public static UserDTO Login(string email, string password)
        {
            return GetUsers().FirstOrDefault(user => user.Email == email && user.Password == password);
        }
   }
}
