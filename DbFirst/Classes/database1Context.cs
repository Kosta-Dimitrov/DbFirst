namespace DbFirst.Classes
{
    using Microsoft.EntityFrameworkCore;
    public partial class database1Context : DbContext
    {
        public database1Context()
        {
        }

        public database1Context(DbContextOptions<database1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Educationalqualification> Educationalqualifications { get; set; } = null!;
        public virtual DbSet<Educationformtype> Educationformtypes { get; set; } = null!;
        public virtual DbSet<Institution> Institutions { get; set; } = null!;
        public virtual DbSet<Institutionspeciality> Institutionspecialities { get; set; } = null!;
        public virtual DbSet<Speciality> Specialities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5433;Database=database1;Username=postgres;Password=k31072001");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Educationalqualification>(entity =>
            {
                entity.ToTable("educationalqualification");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias).HasColumnName("alias");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Vieworder).HasColumnName("vieworder");
            });

            modelBuilder.Entity<Educationformtype>(entity =>
            {
                entity.ToTable("educationformtype");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Vieworder).HasColumnName("vieworder");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("institution");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Externalid).HasColumnName("externalid");

                entity.Property(e => e.Institutionownershiptypeid).HasColumnName("institutionownershiptypeid");

                entity.Property(e => e.Institutiontypeid).HasColumnName("institutiontypeid");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Rootid).HasColumnName("rootid");

                entity.Property(e => e.Vieworder).HasColumnName("vieworder");
            });

            modelBuilder.Entity<Institutionspeciality>(entity =>
            {
                entity.ToTable("institutionspeciality");

                entity.HasIndex(e => e.Educationalformid, "IX_institutionspeciality_educationalformid");

                entity.HasIndex(e => e.Institutionid, "IX_institutionspeciality_institutionid");

                entity.HasIndex(e => e.Researchareaid, "IX_institutionspeciality_researchareaid");

                entity.HasIndex(e => e.Specialityid, "IX_institutionspeciality_specialityid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Educationalformid).HasColumnName("educationalformid");

                entity.Property(e => e.Externalid).HasColumnName("externalid");

                entity.Property(e => e.Institutionid).HasColumnName("institutionid");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Researchareaid).HasColumnName("researchareaid");

                entity.Property(e => e.Specialityid).HasColumnName("specialityid");

                entity.Property(e => e.Vieworder).HasColumnName("vieworder");

                entity.HasOne(d => d.Educationalform)
                    .WithMany(p => p.Institutionspecialities)
                    .HasForeignKey(d => d.Educationalformid)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Institutionspecialities)
                    .HasForeignKey(d => d.Institutionid)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Institutionspecialities)
                    .HasForeignKey(d => d.Specialityid)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("speciality");

                entity.HasIndex(e => e.Educationalqualificationid, "IX_speciality_educationalqualificationid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Educationalqualificationid).HasColumnName("educationalqualificationid");

                entity.Property(e => e.Externalid).HasColumnName("externalid");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Vieworder).HasColumnName("vieworder");

                entity.HasOne(d => d.Educationalqualification)
                    .WithMany(p => p.Specialities)
                    .HasForeignKey(d => d.Educationalqualificationid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_speciality_educationalqualification_educationalqualificatio~");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
