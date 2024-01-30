namespace PdfDocxFileConvertToBase64.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PdfDocxFileConvertToBase64.Models.MyAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PdfDocxFileConvertToBase64.Models.MyAppContext";
        }

        protected override void Seed(PdfDocxFileConvertToBase64.Models.MyAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
