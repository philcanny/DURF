namespace DesignUrFixie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<DesignUrFixie.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DesignUrFixie.Models.MyDbContext";
        }

        protected override void Seed(DesignUrFixie.Models.MyDbContext context)
        {
                                      //      var userStore = new UserStore<ApplicationUser>(context);
                                      //      var userManager = new UserManager<ApplicationUser>(userStore);

                                      //      if (!context.Users.Any(t=>t.UserName == "Phil@pleanala.ie"))
                                      //      {
                                      //          var user = new ApplicationUser { UserName = "Phil@pleanala.ie", Email = "Phil@pleanala.ie" };
                                      //          userManager.CreateAsync(user, "Aa123456");

                                      //          context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Admin" });
                                      //          context.SaveChanges();

                                      //           userManager.AddToRole(user.Id, "Admin");
                                // }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
