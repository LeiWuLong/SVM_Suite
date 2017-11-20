namespace SVM_Processor.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class SVMContext : DbContext
    {
        public SVMContext()
            : base("name=SVMContext")
        {

            //rob
            //enable below to automatically drop-create dbase
            //not recommended, use add migration/update database via package manager console instead

            //Database.SetInitializer(new DropCreateDatabaseAlways<SVMContext>());
        }

        public virtual DbSet<tblmisc> tblmisc { get; set; }
        public virtual DbSet<tblroles> tblroles { get; set; }
        public virtual DbSet<tblschoolyear> tblschoolyear { get; set; }
        public virtual DbSet<tblterms> tblterms { get; set; }
        public virtual DbSet<tbltuition> tbltuition { get; set; }
        public virtual DbSet<tbluser> tbluser { get; set; }
        public virtual DbSet<tbluseraccess> tbluseraccess { get; set; }
        public virtual DbSet<tblaccess> tblaccess { get; set; }
        public virtual DbSet<tbldimeducationlevel> tbldimeducationlevel { get; set; }
       
        public virtual DbSet<tblhealthconcern> tblhealthconcern { get; set; }
        public virtual DbSet<tblrelationship> tblrelationship { get; set; }
        public virtual DbSet<tblstudenthealthrecord> tblstudenthealthrecord { get; set; }
        public virtual DbSet<tblstudent> tblstudent { get; set; }
        public virtual DbSet<tblgender> tblgender { get; set; }
        public virtual DbSet<tblstudentfamily> tblstudentfamily { get; set; }
        public virtual DbSet<tblstudenteducationalbackground> tblstudenteducationalbackground { get; set; }

        public virtual DbSet<tblpaymentterm> tblpaymentterm { get; set; }
        public virtual DbSet<tbldimenrollment> tbldimenrollment { get; set; }
        public virtual DbSet<tblacademicyear> tblacademicyear { get; set; }
        public virtual DbSet<tblassessment> tblassessment { get; set; }
        public virtual DbSet<tbldimsection> tbldimsection { get; set; }
        public virtual DbSet<tblvendor> tblvendor { get; set; }
        public virtual DbSet<tblpayment> tblpayment { get; set; }
        public virtual DbSet<tbldimbank> tbldimbank { get; set; }

         public virtual DbSet<tblmodeofpayment> tblmodeofpayment { get; set; }

        public virtual DbSet<tbldimassessmentstatus> tbldimassessmentstatus { get; set; }
       // public virtual DbSet<tbldimfamassistdiscount> tbldiscount { get; set; }
        public virtual DbSet<tbldimhonor> tbldimhonor { get; set; }

        public virtual DbSet<tbldimalumnidiscount> tbldimalumnidiscount { get; set; }
        public virtual DbSet<tbldimfamassistdiscount> tbldimfamassistdiscount { get; set; }
        public virtual DbSet<tbldimearlybirddiscount> tbldimearlybirddiscount { get; set; }
        public virtual DbSet<tbldimscholarshipdiscount> tbldimscholarshipdiscount { get; set; }

        public virtual DbSet<tbldimreferrals> tbldimreferrals { get; set; }
        public virtual DbSet<tbldimsiblings> tbldimsiblings { get; set; }

        public virtual DbSet<tbldimdiscounttype> tbldimdiscounttype { get; set; }
        public virtual DbSet<tbldiscount> tbldiscount { get; set; }

        public virtual DbSet<tbldimdateparameter> tbldimdateparameter { get; set; }
        public virtual DbSet<tbldimschoolyearparam> tbldimschoolyearparam { get; set; }

        public virtual DbSet<tblsiblingreferralmap> tblsiblingreferralmap { get; set; }
        public virtual DbSet<tblduedates> tblduedates { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)


        {

            modelBuilder.HasDefaultSchema("dbo" );
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<tblmisc>()
            //    .Property(e => e.MiscDescription)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tblroles>()
            //    .Property(e => e.RoleDescription)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbltuition>()
            //    .Property(e => e.TuitionDescription)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluser>()
            //    .Property(e => e.FirstName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluser>()
            //    .Property(e => e.MiddleName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluser>()
            //    .Property(e => e.LastName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluser>()
            //    .Property(e => e.Suffix)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluser>()
            //    .Property(e => e.MobileNo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluser>()
            //    .Property(e => e.Email)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluseraccess>()
            //    .Property(e => e.UserName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tbluseraccess>()
            //    .Property(e => e.Password)
            //    .IsUnicode(false);
        }
    }
}
