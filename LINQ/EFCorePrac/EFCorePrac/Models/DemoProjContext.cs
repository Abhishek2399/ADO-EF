using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class DemoProjContext : DbContext
    {
        public DemoProjContext()
        {
        }

        public DemoProjContext(DbContextOptions<DemoProjContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditMul> AuditMuls { get; set; }
        public virtual DbSet<Auditemp> Auditemps { get; set; }
        public virtual DbSet<ConstraintEg> ConstraintEgs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Depart> Departs { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Dummy> Dummies { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Emp1> Emps1 { get; set; }
        public virtual DbSet<Empdup> Empdups { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employees1 { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Logerror> Logerrors { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Prime> Primes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Simp> Simps { get; set; }
        public virtual DbSet<Simpview> Simpviews { get; set; }
        public virtual DbSet<Simpview1> Simpview1s { get; set; }
        public virtual DbSet<Tab1> Tab1s { get; set; }
        public virtual DbSet<Tab2> Tab2s { get; set; }
        public virtual DbSet<UniqueName> UniqueNames { get; set; }
        public virtual DbSet<UpdateAudit> UpdateAudits { get; set; }
        public virtual DbSet<V1> V1s { get; set; }
        public virtual DbSet<Viewemp> Viewemps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = NOOB; Database = DemoProj; Trusted_connection = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditMul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("audit_mul");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Sal).HasColumnName("sal");

                entity.Property(e => e.Trans)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trans");
            });

            modelBuilder.Entity<Auditemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("auditemp");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Trans)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("trans");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trans_date");
            });

            modelBuilder.Entity<ConstraintEg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConstraintEg");

                entity.Property(e => e.RollNo).HasColumnName("rollNo");

                entity.Property(e => e.StudName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("studName");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");
            });

            modelBuilder.Entity<Depart>(entity =>
            {
                entity.HasKey(e => e.DId)
                    .HasName("PK__Depart__D95F582BD467CB3F");

                entity.ToTable("Depart");

                entity.Property(e => e.DId)
                    .ValueGeneratedNever()
                    .HasColumnName("d_id");

                entity.Property(e => e.DName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("d_name");
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.DId)
                    .HasName("PK__depts__D95F582B02BA8DA2");

                entity.ToTable("depts");

                entity.Property(e => e.DId)
                    .ValueGeneratedNever()
                    .HasColumnName("d_id");

                entity.Property(e => e.DName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("d_name");

                entity.Property(e => e.LocId).HasColumnName("loc_id");
            });

            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy");

                entity.Property(e => e.Num).HasColumnName("num");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("pkeid");

                entity.ToTable("emp");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");
            });

            modelBuilder.Entity<Emp1>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__emps__D9509F6D97016DE6");

                entity.ToTable("emps");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Sal).HasColumnName("sal");

                entity.HasOne(d => d.DIdNavigation)
                    .WithMany(p => p.Emp1s)
                    .HasForeignKey(d => d.DId)
                    .HasConstraintName("FK__emps__d_id__60A75C0F");
            });

            modelBuilder.Entity<Empdup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("empdup");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__employee__D9509F6D6DDD6E63");

                entity.ToTable("employee");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasKey(e => e.EId)
                    .HasName("PK__Employee__3E2ED64A795E1B36");

                entity.ToTable("Employees");

                entity.Property(e => e.EId)
                    .ValueGeneratedNever()
                    .HasColumnName("e_id");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.HasOne(d => d.DIdNavigation)
                    .WithMany(p => p.Employee1s)
                    .HasForeignKey(d => d.DId)
                    .HasConstraintName("FK__Employees__d_id__36B12243");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("grade");

                entity.Property(e => e.Grd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grd")
                    .IsFixedLength(true);

                entity.Property(e => e.Maxsal).HasColumnName("maxsal");

                entity.Property(e => e.Minsal).HasColumnName("minsal");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocId)
                    .HasName("PK__location__BF539ED30310A8C0");

                entity.ToTable("location");

                entity.Property(e => e.LocId)
                    .ValueGeneratedNever()
                    .HasColumnName("loc_id");

                entity.Property(e => e.LocName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("loc_name");
            });

            modelBuilder.Entity<Logerror>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logerror");

                entity.Property(e => e.Em)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("em");

                entity.Property(e => e.En).HasColumnName("en");
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("marks");

                entity.Property(e => e.Rno).HasColumnName("rno");
            });

            modelBuilder.Entity<Prime>(entity =>
            {
                entity.HasKey(e => e.Pkid)
                    .HasName("primepk");

                entity.ToTable("prime");

                entity.Property(e => e.Pkid)
                    .ValueGeneratedNever()
                    .HasColumnName("pkid");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__DD37D91A7FEFFD56");

                entity.ToTable("Product");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Pcost).HasColumnName("pcost");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pname");
            });

            modelBuilder.Entity<Simp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("simp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Simpview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("simpview");

                entity.Property(e => e.DName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("d_name");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");
            });

            modelBuilder.Entity<Simpview1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("simpview1");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Tab1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tab1");

                entity.Property(e => e.Srno).HasColumnName("srno");
            });

            modelBuilder.Entity<Tab2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tab2");

                entity.Property(e => e.Srno).HasColumnName("srno");
            });

            modelBuilder.Entity<UniqueName>(entity =>
            {
                entity.ToTable("UniqueName");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NoName')");
            });

            modelBuilder.Entity<UpdateAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("update_audit");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Info)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("info");
            });

            modelBuilder.Entity<V1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v1");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");
            });

            modelBuilder.Entity<Viewemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewemp");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");
            });

            modelBuilder.HasSequence<int>("mySeq")
                .StartsAt(10)
                .IncrementsBy(10)
                .HasMin(10)
                .HasMax(200);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
