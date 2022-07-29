using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VSPAYROLL.Models
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Advance> Advances { get; set; }
        public virtual DbSet<AdvancePayment> AdvancePayments { get; set; }
        public virtual DbSet<AprovedType> AprovedTypes { get; set; }
        public virtual DbSet<BatchMaster> BatchMasters { get; set; }
        public virtual DbSet<BiometricMaster> BiometricMasters { get; set; }
        public virtual DbSet<CategoryMaster> CategoryMasters { get; set; }
        public virtual DbSet<ConcernMaster> ConcernMasters { get; set; }
        public virtual DbSet<DashboardMaster> DashboardMasters { get; set; }
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual DbSet<DesignationMaster> DesignationMasters { get; set; }
        public virtual DbSet<ECategoryMaster> ECategoryMasters { get; set; }
        public virtual DbSet<EmpEduDetail> EmpEduDetails { get; set; }
        public virtual DbSet<EmpFamilyDetail> EmpFamilyDetails { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<EmpServiceDetail> EmpServiceDetails { get; set; }
        public virtual DbSet<ESIPFSetting> ESIPFSettings { get; set; }
        public virtual DbSet<HolidayMaster> HolidayMasters { get; set; }
        public virtual DbSet<LeaveMaster> LeaveMasters { get; set; }
        public virtual DbSet<LeaveOpening> LeaveOpenings { get; set; }
        public virtual DbSet<LeaveSetting> LeaveSettings { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
        public virtual DbSet<LevelMaster> LevelMasters { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<LoanDetail> LoanDetails { get; set; }
        public virtual DbSet<MenuMaster> MenuMasters { get; set; }
        public virtual DbSet<PayAttendance> PayAttendances { get; set; }
        public virtual DbSet<PayAttImport> PayAttImports { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<RolePermissionMaster> RolePermissionMasters { get; set; }
        public virtual DbSet<ShiftMaster> ShiftMasters { get; set; }
        public virtual DbSet<SubMenuMaster> SubMenuMasters { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<Wage> Wages { get; set; }
        public virtual DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advance>()
                .Property(e => e.Amount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Advance>()
                .HasMany(e => e.AdvancePayments)
                .WithRequired(e => e.Advance)
                .HasForeignKey(e => e.AdvanceCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdvancePayment>()
                .Property(e => e.PaidAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<AprovedType>()
                .Property(e => e.ApprovedType)
                .IsUnicode(false);

            modelBuilder.Entity<AprovedType>()
                .HasMany(e => e.LeaveMasters)
                .WithOptional(e => e.AprovedType)
                .HasForeignKey(e => e.ApprovedType);

            modelBuilder.Entity<BatchMaster>()
                .Property(e => e.BatchName)
                .IsUnicode(false);

            modelBuilder.Entity<BatchMaster>()
                .HasMany(e => e.PayAttendances)
                .WithOptional(e => e.BatchMaster)
                .HasForeignKey(e => e.BatchCode);

            modelBuilder.Entity<BiometricMaster>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BiometricMaster>()
                .Property(e => e.MachineType)
                .IsUnicode(false);

            modelBuilder.Entity<BiometricMaster>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryMaster>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryMaster>()
                .Property(e => e.WagesType)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryMaster>()
                .HasMany(e => e.LeaveSettings)
                .WithRequired(e => e.CategoryMaster)
                .HasForeignKey(e => e.CatCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CategoryMaster>()
                .HasMany(e => e.PayAttendances)
                .WithOptional(e => e.CategoryMaster)
                .HasForeignKey(e => e.CatCode);

            modelBuilder.Entity<CategoryMaster>()
                .HasMany(e => e.Wages)
                .WithRequired(e => e.CategoryMaster)
                .HasForeignKey(e => e.CatCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.ConcernName)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.PrintName)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.GST)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .Property(e => e.ContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.AdvancePayments)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.AprovedTypes)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.BatchMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.CategoryMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.DashboardMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.DepartmentMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.DesignationMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.EmpEduDetails)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.EmpFamilyDetails)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.EmployeeDetails)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.EmpServiceDetails)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.HolidayMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.LeaveMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.LeaveOpenings)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.LeaveSettings)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.LeaveTypes)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.LevelMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.Loans)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.LoanDetails)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.MenuMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.PayAttendances)
                .WithOptional(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.PayAttImports)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.RoleMasters)
                .WithOptional(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.RolePermissionMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.ShiftMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.SubMenuMasters)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.UserDetails)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConcernMaster>()
                .HasMany(e => e.Wages)
                .WithRequired(e => e.ConcernMaster)
                .HasForeignKey(e => e.ConCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DashboardMaster>()
                .Property(e => e.Dashboard)
                .IsUnicode(false);

            modelBuilder.Entity<DashboardMaster>()
                .HasMany(e => e.RoleMasters)
                .WithOptional(e => e.DashboardMaster)
                .HasForeignKey(e => e.DashCode);

            modelBuilder.Entity<DepartmentMaster>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<DepartmentMaster>()
                .HasMany(e => e.PayAttendances)
                .WithOptional(e => e.DepartmentMaster)
                .HasForeignKey(e => e.DeptCode);

            modelBuilder.Entity<DepartmentMaster>()
                .HasMany(e => e.Wages)
                .WithRequired(e => e.DepartmentMaster)
                .HasForeignKey(e => e.DeptCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DesignationMaster>()
                .Property(e => e.DesignationName)
                .IsUnicode(false);

            modelBuilder.Entity<DesignationMaster>()
                .HasMany(e => e.PayAttendances)
                .WithOptional(e => e.DesignationMaster)
                .HasForeignKey(e => e.DesigCode);

            modelBuilder.Entity<DesignationMaster>()
                .HasMany(e => e.Wages)
                .WithRequired(e => e.DesignationMaster)
                .HasForeignKey(e => e.DesigCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ECategoryMaster>()
                .Property(e => e.ECategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<EmpEduDetail>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<EmpEduDetail>()
                .Property(e => e.Experience)
                .IsUnicode(false);

            modelBuilder.Entity<EmpEduDetail>()
                .Property(e => e.Percentage)
                .IsUnicode(false);

            modelBuilder.Entity<EmpFamilyDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EmpFamilyDetail>()
                .Property(e => e.RelationShips)
                .IsUnicode(false);

            modelBuilder.Entity<EmpFamilyDetail>()
                .Property(e => e.Age)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.EmpNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.EmpName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.ESINo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.PFNo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.FatherName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.FatherOccupation)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.Spouse)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.SpouseOccupation)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.EmployeeType)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.PermenantAddress)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.HomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.AadharCard)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.PanCard)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.WeekOff)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.AdvanceLimit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.LoanLimit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.Advances)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.AdvancePayments)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.EmpEduDetails)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.EmpFamilyDetails)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.EmpServiceDetails)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.LeaveMasters)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.LeaveMasters1)
                .WithOptional(e => e.EmployeeDetail1)
                .HasForeignKey(e => e.ApprovedBy);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.LeaveOpenings)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.Loans)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.LoanDetails)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.UserDetails)
                .WithOptional(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpId);

            modelBuilder.Entity<EmployeeDetail>()
                .HasMany(e => e.Wages)
                .WithRequired(e => e.EmployeeDetail)
                .HasForeignKey(e => e.EmpCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpServiceDetail>()
                .Property(e => e.PreviousCompany)
                .IsUnicode(false);

            modelBuilder.Entity<EmpServiceDetail>()
                .Property(e => e.PreviousCompanyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<EmpServiceDetail>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<EmpServiceDetail>()
                .Property(e => e.Experiense)
                .IsUnicode(false);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.ESIPercentange)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.ESIMinLimit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.ESIMaxLimit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.ESIEmployer)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.ESIEmployes)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.PFPercentange)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.PFMinLimit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.PFMaxLimit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.EPS)
                .HasPrecision(9, 2);

            modelBuilder.Entity<ESIPFSetting>()
                .Property(e => e.EPF)
                .HasPrecision(9, 2);

            modelBuilder.Entity<HolidayMaster>()
                .Property(e => e.HolidayName)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveMaster>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveMaster>()
                .Property(e => e.LeaveDuration)
                .HasPrecision(3, 2);

            modelBuilder.Entity<LeaveSetting>()
                .Property(e => e.ClPerMonth)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LeaveSetting>()
                .Property(e => e.SlPerMonth)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LeaveSetting>()
                .Property(e => e.ElPerMonth)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LeaveSetting>()
                .HasMany(e => e.LeaveOpenings)
                .WithRequired(e => e.LeaveSetting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeaveType>()
                .Property(e => e.LeaveType1)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveType>()
                .HasMany(e => e.HolidayMasters)
                .WithRequired(e => e.LeaveType)
                .HasForeignKey(e => e.LeaveTypeCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LeaveType>()
                .HasMany(e => e.LeaveMasters)
                .WithRequired(e => e.LeaveType1)
                .HasForeignKey(e => e.LeaveType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.LoanAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Loan>()
                .Property(e => e.MonthlyDue)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Loan>()
                .HasMany(e => e.LoanDetails)
                .WithRequired(e => e.Loan)
                .HasForeignKey(e => e.LoanCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.DueAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LoanDetail>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<MenuMaster>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<PayAttendance>()
                .Property(e => e.WeeklyOff)
                .IsUnicode(false);

            modelBuilder.Entity<PayAttendance>()
                .Property(e => e.LeaveType)
                .IsUnicode(false);

            modelBuilder.Entity<PayAttendance>()
                .Property(e => e.Present)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PayAttendance>()
                .Property(e => e.OT)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PayAttImport>()
                .Property(e => e.TicketNo)
                .IsUnicode(false);

            modelBuilder.Entity<PayAttImport>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<PayAttImport>()
                .Property(e => e.Flag)
                .IsUnicode(false);

            modelBuilder.Entity<PayAttImport>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<RoleMaster>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<RoleMaster>()
                .HasMany(e => e.RolePermissionMasters)
                .WithRequired(e => e.RoleMaster)
                .HasForeignKey(e => e.RoleCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleMaster>()
                .HasMany(e => e.UserDetails)
                .WithRequired(e => e.RoleMaster)
                .HasForeignKey(e => e.RoleCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubMenuMaster>()
                .Property(e => e.SubMenuName)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.EmpNumber)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.PrimaryPassword)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.SecondaryPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Wage>()
                .Property(e => e.WagesType)
                .IsUnicode(false);

            modelBuilder.Entity<Wage>()
                .Property(e => e.BasicSalary)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Wage>()
                .Property(e => e.DearnessAllowance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Wage>()
                .Property(e => e.HouseRentAllowance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Wage>()
                .Property(e => e.ConveyanceAllowance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Wage>()
                .Property(e => e.LeaveTravelAllowance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Wage>()
                .Property(e => e.MedicalAllowance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Wage>()
                .Property(e => e.PerformanceBonusAndSpecialAllowance)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Wage>()
                .Property(e => e.OtherAllowances)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Log>()
                .Property(e => e.Thread)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Logger)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Exception)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.ExceptionCode)
                .IsUnicode(false);
        }
    }
}
