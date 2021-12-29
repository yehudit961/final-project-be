using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class TripBL
    {
        public static IEnumerable<TripDTO> GetTrips()
        {
            var list = TripDAL.GetTrips().ToList();

            foreach (var item in list)
            {
                yield return Conversions.Map(item);
            }
        }

        public static TripDTO GetTrip(int id)
        {
            return Conversions.Map(TripDAL.GetTrip(id));
        }

        public static IEnumerable<TripDTO> GetTripsForUser(int userId)
        {
            var list = TripDAL.GetTripsForUser(userId);
            foreach (var item in list)
            {
                yield return Conversions.Map(item);
            }
        }

        public static void AddTrip(TripDTO tripDTO)
        {
            TripDAL.addTrip(Conversions.Map(tripDTO));
        }

        public static void UpdateTrip(TripDTO tripDTO, int id)
        {
            TripDAL.updateTrip(Conversions.Map(tripDTO));
        }

        public static void DeleteTrip(int id)
        {
            TripDAL.DeleteTrip(id);
        }
    }
}
