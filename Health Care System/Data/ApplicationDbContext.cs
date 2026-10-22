using Health_Care_System.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Care_System.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(@"Server = .\SQLEXPRESS; Database = HealthCare System; Trusted_Connection = True; TrustServerCertificate = True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                        .HasKey(a => new { a.PatientId, a.DoctorId });

            modelBuilder.Entity<Appointment>()
                        .HasOne(a => a.Patient)
                        .WithMany(p => p.Appointments)
                        .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<Appointment>()
                        .HasOne(a => a.Doctor)
                        .WithMany(d => d.Appointments)
                        .HasForeignKey(a => a.DoctorId);
        }


        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}
