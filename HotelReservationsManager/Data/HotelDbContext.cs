using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class HotelDbContext : IdentityDbContext<User,IdentityRole,string>
    {
        public HotelDbContext()
        {
                
        }
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= .\\SQLEXPRESS;Database=HotelDb;Integrated Security = true");
            }
            base.OnConfiguring(optionsBuilder);
        }


        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ph = new Microsoft.AspNetCore.Identity.PasswordHasher<User>();

            modelBuilder.Entity<Reservation>()
                .HasMany(reservation => reservation.Clients)
                .WithOne(client => client.Reservation)
                .HasForeignKey(client => client.ReservationId)
                .OnDelete(DeleteBehavior.Cascade);
            /*

            modelBuilder.Entity<Reservation>()
                .HasMany(room => room.Reservations)
                .WithOne(reservation => reservation.Room)
                .HasForeignKey(reservation => reservation.RoomId);
            

            modelBuilder.Entity<Reservation>()
                .HasOne(reservation => reservation.Room)
                .WithOne(room => room.Reservation)
                .HasForeignKey<Room>(room => room.ReservationId);


            modelBuilder.Entity<User>()
                .HasMany(user=>user.Reservations)
                .WithOne(reservation => reservation.User)
                .HasForeignKey(reservation=>reservation.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<User>()
                .HasData( new User()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "admin",
                    PasswordHash = ph.HashPassword(null,"adminpass"),
                    FirstName = "Atanas",
                    MiddleName = "Mihaylov",
                    LastName = "Ivanov",
                    EGN = "7306078725",
                    PhoneNumber = "0877923606",
                    Email = "adminAtanas@abv.bg",
                    DateАppointment = new DateTime(2002, 11, 25),
                    ActiveOrNot = true,
                    IsAdmin = true,
                },
                new User()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "user",
                    PasswordHash = ph.HashPassword(null,"userpass"),
                    FirstName = "Ivan",
                    MiddleName = "Ivanov",
                    LastName = "Georgiev",
                    EGN = "8536156621",
                    PhoneNumber = "0882686278",
                    Email = "userIvan@abv.bg",
                    DateАppointment = new DateTime(2012, 06, 11),
                    ActiveOrNot = true,
                    IsAdmin = false
                });

            base.OnModelCreating(modelBuilder);
        }
        */

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= DESKTOP-023DC6U\\SQLEXPRESS;Database=HotelDb;Integrated Security = true");
            }
        }
        */
    }
}
