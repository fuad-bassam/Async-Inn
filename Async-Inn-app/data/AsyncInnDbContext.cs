using Async_Inn_app.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.data
{
    public class AsyncInnDbContext : DbContext
    {

       public DbSet<Amenities> Amenities { get; set; }

        public DbSet<Employees> Employees { get; set; }

        //public DbSet<EmployeesWorkTime> EmployeesWorkTime { get; set; }

        public DbSet<HotelBranches> HotelBranches { get; set; }

        //public DbSet<People> People { get; set; }

        public DbSet<Rooms> Rooms { get; set; }

        public DbSet<RoomsAmenities> RoomsAmenities { get; set; }

        //public DbSet<Visitors> Visitors { get; set; }


        //public DbSet<WorkTime> WorkTime { get; set; }


        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<RoomsAmenities>().HasKey( x =>  new {x.roomId,x.featureId });

            // This calls the base method, but does nothing
            // base.OnModelCreating(modelBuilder);

           // modelBuilder.Entity<HotelBranches>().HasData(
           //   new HotelBranches { hotelId = 1, name = "Downtown Branch", city = "jordan", state = "amman", address = "Downtoun-ALsame street ", phoneNum = "00963323423212", roomsNum = 30 },

           //   new HotelBranches { hotelId = 2, name = "Zarqa Branch", city = "jordan", state = "Zarqa", address = " ali street", phoneNum = "00962790941468", roomsNum = 40 },

           //   new HotelBranches { hotelId = 13, name = "Karak Branch", city = "jordan", state = "Karak", address = "AL-waseh street", phoneNum = "00962301520123", roomsNum = 90 }
           // );

           //// modelBuilder.Entity<Rooms>().HasData(
           ////  new Rooms { hotelIdRoomId = 1101, roomId = 101, nickName = "Restful Rainier", space = 2, price = 29.9m },
           ////  new Rooms { hotelIdRoomId = 1102, roomId = 102, nickName = "Seahawks Snooze", space = 2, price = 45 },

           ////  new Rooms { hotelIdRoomId = 2101, roomId = 101, nickName = "Golden hat", space = 3, price = 75}
           ////);


           // modelBuilder.Entity<Amenities>().HasData(
           //  new Amenities { amenitiesId = 11, name = "coffee maker", description = "have a coffee maker with unlimited drink amounts from machine choices.", price = 25 },
           //  new Amenities { amenitiesId = 21, name = "ocean view", description = "have a view from the window on the ocean.", price = 35 },
           //  new Amenities { amenitiesId = 31, name = "mini bar", description = "Have a mini bar in your rome with a discount of 25% on drinks from it.", price = 40 }

           //);

            //modelBuilder.Entity<Rooms>().HasKey(
            //    Rooms => new { Rooms.hotelId, Rooms.roomId }
            //    );
            //modelBuilder.Entity<RoomsAmenities>().HasKey(
            //   x => new {x.hotelIdRoomId , x.amenitiesId }
            //   );
        }

    }
}
