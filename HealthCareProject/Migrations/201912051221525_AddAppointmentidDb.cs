namespace HealthCareProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAppointmentidDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Appointments", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.Appointments", new[] { "Employee_Id" });
            RenameColumn(table: "dbo.Appointments", name: "Doctor_DoctorId", newName: "DoctorDoctorId");
            RenameColumn(table: "dbo.Appointments", name: "Employee_Id", newName: "EmployeeId");
            AlterColumn("dbo.Appointments", "DoctorDoctorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Appointments", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "DoctorDoctorId");
            CreateIndex("dbo.Appointments", "EmployeeId");
            AddForeignKey("dbo.Appointments", "DoctorDoctorId", "dbo.Doctors", "DoctorId", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            DropColumn("dbo.Appointments", "DoctorSapId");
            DropColumn("dbo.Appointments", "EmployeeSapId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "EmployeeSapId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "DoctorSapId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Appointments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Appointments", "DoctorDoctorId", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "EmployeeId" });
            DropIndex("dbo.Appointments", new[] { "DoctorDoctorId" });
            AlterColumn("dbo.Appointments", "EmployeeId", c => c.Int());
            AlterColumn("dbo.Appointments", "DoctorDoctorId", c => c.Int());
            RenameColumn(table: "dbo.Appointments", name: "EmployeeId", newName: "Employee_Id");
            RenameColumn(table: "dbo.Appointments", name: "DoctorDoctorId", newName: "Doctor_DoctorId");
            CreateIndex("dbo.Appointments", "Employee_Id");
            CreateIndex("dbo.Appointments", "Doctor_DoctorId");
            AddForeignKey("dbo.Appointments", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.Appointments", "Doctor_DoctorId", "dbo.Doctors", "DoctorId");
        }
    }
}
