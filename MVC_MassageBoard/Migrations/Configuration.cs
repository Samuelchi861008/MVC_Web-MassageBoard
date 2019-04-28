namespace MVC_MassageBoard.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using MVC_MassageBoard.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_MassageBoard.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_MassageBoard.Models.Model1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Testtables.AddOrUpdate(
                p => new {p.user, p.title, p.commet},
                new Testtb {user = "Sam", title = "First Massage", commet = "I Love Superstar", date = DateTime.Parse("2019/04/11").Date}
            );
        }
    }
}
