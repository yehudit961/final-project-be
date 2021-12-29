using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class RideBL
    {
        public static IEnumerable<RideDTO> GetRides()
        {
            var list = RideDAL.GetRides().ToList();

            foreach (var item in list)
            {
                yield return Conversions.Map(item);
            }
        }

        public static RideDTO GetRide(int id)
        {
            //return Converter.ConvertToDTO( UserDal.GetUser(id));
            return Conversions.Map(RideDAL.GetRide(id));
        }


        public static void AddRide(RideDTO rideDTO)
        {
            RideDAL.AddRide(Conversions.Map(rideDTO));
        }

        public static void UpdateRide(RideDTO rideDTO, int id)
        {
            RideDAL.UpdateRide(Conversions.Map(rideDTO));
        }

        public static void DeleteRide(int id)
        {
            RideDAL.DeleteRide(id);
        }
    }
}
