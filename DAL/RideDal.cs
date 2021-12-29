using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Http;

namespace DAL
{
    public class RideDAL
    {
        public static IEnumerable<Ride> GetRides()
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Rides.ToList();
            }
        }

        public static Ride GetRide(int id)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Rides.Single(ride => ride.Id == id);
            }
        }

        public static void AddRide(Ride ride)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                ctx.Rides.Add(ride);
                ctx.SaveChanges();
            }
        }

        public static void UpdateRide(Ride ride)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                Ride rideToRemove = ctx.Rides.Single(x => x.Id == ride.Id);
                ctx.Rides.Remove(rideToRemove);
                ctx.Rides.Add(ride);
                ctx.SaveChanges();
                
            }
        }

        public static void DeleteRide(int id)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                Ride rideToRemove = ctx.Rides.Single(ride => ride.Id == id);
                ctx.Rides.Remove(rideToRemove);
                ctx.SaveChanges();
            }
        }

    }
}
