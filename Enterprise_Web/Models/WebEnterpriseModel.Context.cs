﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enterprise_Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebEnterpriseEntities : DbContext
    {
        public WebEnterpriseEntities()
            : base("name=WebEnterpriseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Closure_Day> Closure_Days { get; set; }
        public virtual DbSet<Contribution> Contributions { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<User_Admin_Detail> User_Admin_Detail { get; set; }
        public virtual DbSet<User_Guest_Detail> User_Guest_Detail { get; set; }
        public virtual DbSet<User_Marketing_Coordinator_Detail> User_Marketing_Coordinator_Detail { get; set; }
        public virtual DbSet<User_Marketing_Manager_Detail> User_Marketing_Manager_Detail { get; set; }
        public virtual DbSet<User_Student_Detail> User_Student_Detail { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Image> Images { get; set; }
    }
}
