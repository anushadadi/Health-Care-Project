namespace HealthCareProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropfkPropdb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "DoctorDoctorId", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "DoctorDoctorId" });
            DropColumn("dbo.Appointments", "DoctorDoctorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "DoctorDoctorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "DoctorDoctorId");
            AddForeignKey("dbo.Appointments", "DoctorDoctorId", "dbo.Doctors", "DoctorId", cascadeDelete: true);
        }
    }
}
