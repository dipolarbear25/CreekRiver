using Microsoft.EntityFrameworkCore;
using CreekRiver.Models;
using System;


// : DBContext in the line below allows the class to inherit all the properties of DBContext
public class CreekRiverDbContext : DbContext
{
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }

    public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Campsite>().HasData(new Campsite[] {
            new Campsite { Id = 1, CampsiteTypeId = 1, Nickname = "Barred Owl", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
            new Campsite { Id = 2, CampsiteTypeId = 2, Nickname = "Yosemite", ImageUrl="https://media.architecturaldigest.com/photos/648a00aa1fa1b6e12cc85f4f/master/w_1920%2Cc_limit/GettyImages-557995745.jpg"},
            new Campsite { Id = 3, CampsiteTypeId = 3, Nickname = "Zion National Park", ImageUrl="https://media.architecturaldigest.com/photos/648a00aa1fa1b6e12cc85f4f/master/w_1920%2Cc_limit/GettyImages-557995745.jpg"},
            new Campsite { Id = 4, CampsiteTypeId = 4, Nickname = "Mount Cook National Park", ImageUrl="https://media.architecturaldigest.com/photos/648a00b01fa1b6e12cc85f51/master/w_1920%2Cc_limit/GettyImages-576394483.jpg"},
            new Campsite { Id = 5, CampsiteTypeId = 5, Nickname = "Acadia National Park", ImageUrl="https://media.architecturaldigest.com/photos/648a011181d1b73948dc32c4/master/w_1920%2Cc_limit/GettyImages-1035294244.jpg"}
        });

        // seed data with campsite types
        modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[] {
            new CampsiteType {Id = 1, CampsiteTypeName = "Tent", FeePerNight = 15.99M, MaxReservationDays = 7},
            new CampsiteType {Id = 2, CampsiteTypeName = "RV", FeePerNight = 26.50M, MaxReservationDays = 14},
            new CampsiteType {Id = 3, CampsiteTypeName = "Primitive", FeePerNight = 10.00M, MaxReservationDays = 3},
            new CampsiteType {Id = 4, CampsiteTypeName = "Hammock", FeePerNight = 12M, MaxReservationDays = 7}
        });

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[] {
            new UserProfile
            {
                Id = 1,
                FirstName = "Austin",
                LastName = "Mangum",
                Email = "mangumaustin@gmail.com" }
            });

        modelBuilder.Entity<Reservation>().HasData(new Reservation[] {
            new Reservation
            {
                Id = 1,
                CampsiteId = 2,
                UserProfileId = 1,
                CheckinDate = new DateTime(2023, 12, 23),
                CheckoutDate = new DateTime(2024, 1, 17)},
        });
    }
}

