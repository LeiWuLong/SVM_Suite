namespace SVM_Processor.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MySql.Data;
    using MySql.Data.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<SVM_Processor.Models.SVMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
            //CodeGenerator = new MySql.Data.Entity.MySqlMigrationCodeGenerator();
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
            SetHistoryContextFactory("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
            CodeGenerator = new MySqlMigrationCodeGenerator();
        }

        protected override void Seed(SVM_Processor.Models.SVMContext context)
        {
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
