using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TicketApp.EFLayer.Models
{
    public partial class db_ticketappContext : DbContext
    {
        public db_ticketappContext()
        {
        }

        public db_ticketappContext(DbContextOptions<db_ticketappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=AALAP-JA\\SQLEXPRESS;Initial Catalog=db_ticketapp;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__C190176B412D637E");

                entity.ToTable("Employee");

                entity.Property(e => e.Eid)
                    .HasMaxLength(20)
                    .HasColumnName("EId");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("DOJ");

                entity.Property(e => e.EName)
                    .HasMaxLength(50)
                    .HasColumnName("E_Name");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.TicketId).ValueGeneratedNever();

                entity.Property(e => e.LoggedBy).HasMaxLength(20);

                entity.Property(e => e.RaisedDate).HasColumnType("date");

                entity.Property(e => e.Resolution).HasMaxLength(50);

                entity.Property(e => e.ResolvedBy).HasMaxLength(20);

                entity.Property(e => e.ResolvedDate).HasColumnType("date");

                entity.Property(e => e.Severity).HasMaxLength(20);

                entity.Property(e => e.Tdescription)
                    .HasMaxLength(100)
                    .HasColumnName("TDescription");

                entity.Property(e => e.Tstatus).HasColumnName("TStatus");

                entity.HasOne(d => d.LoggedByNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.LoggedBy)
                    .HasConstraintName("FK__Ticket__LoggedBy__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
