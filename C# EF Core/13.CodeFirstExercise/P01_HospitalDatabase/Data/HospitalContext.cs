using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Visitation> Visitations { get; set; }
        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<PatientMedicament> PatientMedicaments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=Hospital;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(ent =>
            {
                ent.Property(p => p.FirstName)
                    .IsRequired()
                    .IsUnicode();

                ent.Property(p => p.LastName)
                    .IsRequired()
                    .IsUnicode();

                ent.Property(p => p.Address)
                    .IsUnicode();

                ent.Property(p => p.Email)
                    .IsUnicode(false);
            });

            // modelBuilder.Entity<Visitation>(ent =>
            // {
            //     ent.Property(v => v.Comments)
            //         .IsUnicode();
            // });

            // modelBuilder.Entity<Diagnose>(ent =>
            // {
            //     ent.Property(d => d.Name)
            //         .IsRequired()
            //         .IsUnicode();

            //     ent.Property(d => d.Comments)
            //         .IsUnicode();
            // });

            // modelBuilder.Entity<Medicament>(ent =>
            // {
            //     ent.Property(m => m.Name)
            //         .IsUnicode();
            // });

            modelBuilder.Entity<PatientMedicament>(ent =>
            {
                ent.HasKey(pm => new { pm.PatientId, pm.MedicamentId });
            });
        }
    }
}