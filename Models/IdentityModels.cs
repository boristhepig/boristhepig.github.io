using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MGRescue_System.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        [Column(Order = 2)]
        public string FirstName { get; set; }

        [Column(Order = 3)]
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }

        // Use a sensible display name for views:
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }



        // Concatenate the address info for display in tables and such:
        public string DisplayAddress
        {
            get
            {
                string dspAddress =
                    string.IsNullOrWhiteSpace(this.Address) ? "" : this.Address;
                string dspCity =
                    string.IsNullOrWhiteSpace(this.City) ? "" : this.City;
                string dspCounty =
                    string.IsNullOrWhiteSpace(this.County) ? "" : this.County;
                string dspPostCode =
                    string.IsNullOrWhiteSpace(this.PostCode) ? "" : this.PostCode;

                return string
                    .Format("{0} {1} {2} {3}", dspAddress, dspCity, dspCounty, dspPostCode);
            }
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
        public string Description { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MGR_DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Species> Species { get; set; }



        static ApplicationDbContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }



    }
}