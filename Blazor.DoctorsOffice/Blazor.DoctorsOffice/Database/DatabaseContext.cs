using Blazor.DoctorsOffice.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blazor.DoctorsOffice.Database
{
    public class DatabaseContext : DbContext
    {
        #region Public Constructors

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<Diagnosis> Diagnoses { get; set; }

        public DbSet<Disease> Diseases { get; set; }

        public DbSet<PatientDiagnosis> PatientDiagnoses { get; set; }

        public DbSet<Patient> Patients { get; set; }

        #endregion Public Properties

        #region Protected Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, FirstName = "Klara", LastName = "Schmidt", Birth = new DateTime(1995, 05, 25), SSN = 1234 },
                new Patient { Id = 2, FirstName = "Hans", LastName = "Haubner", Birth = new DateTime(2001, 03, 15), SSN = 4567 },
                new Patient { Id = 3, FirstName = "Ilse", LastName = "Puck", Birth = new DateTime(1990, 06, 03), SSN = 7896 }
            );

            modelBuilder.Entity<Disease>().HasData(
                new Disease { Id = 1, Name = "Allergy" },
                new Disease { Id = 2, Name = "cardiac cycle" },
                new Disease { Id = 3, Name = "Cold" }
            );

            modelBuilder.Entity<Diagnosis>().HasData(
                new Diagnosis { Id = 1, Title = "rash hands", DiseaseId = 1 },
                new Diagnosis { Id = 2, Title = "breathlessness", DiseaseId = 2 },
                new Diagnosis { Id = 3, Title = "rhinitis", DiseaseId = 3 }
            );

            modelBuilder.Entity<PatientDiagnosis>().HasData(
                new PatientDiagnosis { Id = 1, Visit = new DateTime(2020, 11, 19, 09, 03, 40), PatientId = 1, DiagnosisId = 1 },
                new PatientDiagnosis { Id = 2, Visit = new DateTime(2020, 01, 28, 08, 03, 10), PatientId = 2, DiagnosisId = 2 },
                new PatientDiagnosis { Id = 3, Visit = new DateTime(2019, 08, 14, 15, 03, 21), PatientId = 3, DiagnosisId = 2 },
                new PatientDiagnosis { Id = 4, Visit = new DateTime(2021, 01, 17, 11, 15, 26), PatientId = 2, DiagnosisId = 3 },
                new PatientDiagnosis { Id = 5, Visit = new DateTime(2020, 12, 12, 20, 03, 50), PatientId = 1, DiagnosisId = 3 }
            );
        }

        #endregion Protected Methods
    }
}