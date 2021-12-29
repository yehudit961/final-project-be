using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TripDAL
    {

        public static IEnumerable<Trip> GetTrips()
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Trips.ToList();
            }
        }

        public static IEnumerable<Trip> GetTripsForUser(int userId)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Trips.Where(trip => trip.UserId == userId).ToList();
            }
        }

        public static Trip GetTrip(int id)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                return ctx.Trips.Single(trip => trip.Id == id);
            }
        }

        public static void addTrip(Trip trip)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                ctx.Trips.Add(trip);
                ctx.SaveChanges();
            }
        }

        public static void updateTrip(Trip trip)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                Trip tripToRemove = ctx.Trips.Single(t => t.Id == trip.Id);
                ctx.Trips.Remove(tripToRemove);
                ctx.Trips.Add(trip);
                ctx.SaveChanges();

            }
        }

        public static void DeleteTrip(int id)
        {
            using (AmusementParkEntities ctx = new AmusementParkEntities())
            {
                Trip tripToRemove = ctx.Trips.Single(trip => trip.Id == id);
                ctx.Trips.Remove(tripToRemove);
                ctx.SaveChanges();
            }
        }

    }
}
