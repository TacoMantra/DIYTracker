namespace DIYTracker.Migrations
{
    using DIYTracker.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DIYTracker.Models.MyDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DIYTracker.Models.MyDatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var systemUser = new User
            {
                FirstName = "DIY",
                LastName = "Tracker",
                UserType = 0
            };

            var replaceOutletCover = new Project
            {
                User = systemUser,
                Name = "Replace Outlet Cover"
            };

            var outletCover = new Material
            {
                Name = "Outlet cover",
                Price = 2.99,
                SingleUnits = "Cover",
                PluralUnits = "Covers"
            };

            var flatHeadScrewdriver = new Tool
            {
                Name = "Flat head screwdriver",
                Price = 8.99
            };

            var shutDownPower = new Step
            {
                Order = 1,
                Description = "Shut off power to the outlet from your breaker box.",
                Project = replaceOutletCover
            };

            var removeOldCover = new Step
            {
                Order = 2,
                Description = "Using your flat head screwdriver, remove the screw attaching the cover to the outlet. Gently pry away the cover.",
                Project = replaceOutletCover
            };

            var placeNewCover = new Step
            {
                Order = 3,
                Description = "Line up the new outlet cover over the outlet. Attach the screw with the flathead screwdriver, being careful not to over-tighten.",
                Project = replaceOutletCover
            };

            try
            {
                context.Users.AddOrUpdate(systemUser);
                context.Projects.AddOrUpdate(p => p.Name, replaceOutletCover);
                context.Materials.AddOrUpdate(outletCover);
                context.Tools.AddOrUpdate(flatHeadScrewdriver);
                context.Steps.AddOrUpdate(
                    shutDownPower,
                    removeOldCover,
                    placeNewCover
                );
                context.ProjectMaterials.AddOrUpdate(
                    new ProjectMaterial
                    {
                        Item = outletCover,
                        Project = replaceOutletCover,
                        Quantity = 1
                    }
                );
                context.ProjectTools.AddOrUpdate(
                    new ProjectTool
                    {
                        Item = flatHeadScrewdriver,
                        Project = replaceOutletCover
                    }
                );

                context.SaveChanges();
            }
            catch (DbEntityValidationException exception)
            {
                foreach (var error in exception.EntityValidationErrors)
                {
                    Console.WriteLine($"Error with entity {error.Entry.Entity.GetType().Name}");
                }            
            }
            //try
            //{
            //    //context.Users.AddOrUpdate(systemUser);
            //    context.Projects.AddOrUpdate(p => p.Name, replaceOutletCover);
            //    //context.Materials.AddOrUpdate(outletCover);
            //    //context.Tools.AddOrUpdate(flatHeadScrewdriver);
            //    //context.Steps.AddOrUpdate(
            //    //    shutDownPower,
            //    //    removeOldCover,
            //    //    placeNewCover
            //    //);
            //    //context.ProjectMaterials.AddOrUpdate(
            //    //    new ProjectMaterial
            //    //    {
            //    //        Item = outletCover,
            //    //        Project = replaceOutletCover,
            //    //        Quantity = 1
            //    //    }
            //    //);
            //    //context.ProjectTools.AddOrUpdate(
            //    //    new ProjectTool
            //    //    {
            //    //        Item = flatHeadScrewdriver,
            //    //        Project = replaceOutletCover
            //    //    }
            //    //);
            //}
            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Debug.Write($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
            //        }
            //    }
            //    throw;
            //}
        }
    }
}
