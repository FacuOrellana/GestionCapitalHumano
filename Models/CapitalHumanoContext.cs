using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace GestionCapitalHumano.Models;

public partial class CapitalHumanoContext : DbContext
{
    public CapitalHumanoContext()
    {
    }

    public CapitalHumanoContext(DbContextOptions<CapitalHumanoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Asistencia> Asistencia { get; set; }

    public virtual DbSet<Capacitacion> Capacitaciones { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EmpleadoCapacitacion> EmpleadoCapacitaciones { get; set; }

    public virtual DbSet<EmpleadoHabilidad> EmpleadoHabilidades { get; set; }

    public virtual DbSet<EquipoTrabajo> EquipoTrabajos { get; set; }

    public virtual DbSet<Experiencia> Experiencia { get; set; }

    public virtual DbSet<Habilidad> Habilidades { get; set; }

    public virtual DbSet<ObraSocial> ObraSociales { get; set; }

    public virtual DbSet<PuestoTrabajo> PuestoTrabajos { get; set; }

    public virtual DbSet<Sindicato> Sindicatos { get; set; }

    public virtual DbSet<Tarea> Tareas { get; set; }

    public virtual DbSet<TipoExperiencia> TipoExperiencia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source =DESKTOP-765RO3K; Initial Catalog =CapitalHumano; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.IdArea);

            entity.ToTable("Area");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Asistencia>(entity =>
        {
            entity.HasKey(e => e.IdAsistencia).HasName("PK_tabla1");

            entity.Property(e => e.IdAsistencia).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.HoraSalida)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Asistencia)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Asistenci__IdEmp__5CD6CB2B");
        });

        modelBuilder.Entity<Capacitacion>(entity =>
        {
            entity.HasKey(e => e.IdCapacitacion);

            entity.ToTable("Capacitacion");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.HasKey(e => e.IdContrato);

            entity.ToTable("Contrato");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Seniority)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento);

            entity.ToTable("Departamento");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK_Empleados");

            entity.ToTable("Empleado");

            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Ciudad)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Direccion).HasMaxLength(50);
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpleadoCapacitacion>(entity =>
        {
            entity.HasKey(e => e.IdEmpleadoCapacitacion);

            entity.ToTable("Empleado_Capacitacion");

            entity.Property(e => e.IdEmpleadoCapacitacion)
                .ValueGeneratedNever()
                .HasColumnName("IdEmpleado_Capacitacion");

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.EmpleadoCapacitaciones)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_Empleado_Capacitacion_Capacitacion");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.EmpleadoCapacitacions)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK_Empleado_Capacitacion_Empleado");
        });

        modelBuilder.Entity<EmpleadoHabilidad>(entity =>
        {
            entity.HasKey(e => e.IdEmpleadoHabilidad).HasName("PK_dawdawd");

            entity.ToTable("Empleado_Habilidad");

            entity.Property(e => e.IdEmpleadoHabilidad)
                .ValueGeneratedNever()
                .HasColumnName("IdEmpleado_Habilidad");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.EmpleadoHabilidads)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK_Empleado_Habilidad_Empleado");

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany(p => p.EmpleadoHabilidads)
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_Empleado_Habilidad_Habilidad");
        });

        modelBuilder.Entity<EquipoTrabajo>(entity =>
        {
            entity.HasKey(e => e.IdEquipoTrabajo);

            entity.ToTable("EquipoTrabajo");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Experiencia>(entity =>
        {
            entity.HasKey(e => e.IdExperiencia);

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Habilidad>(entity =>
        {
            entity.HasKey(e => e.IdHabilidad);

            entity.ToTable("Habilidad");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<ObraSocial>(entity =>
        {
            entity.HasKey(e => e.IdObraSocial);

            entity.ToTable("ObraSocial");

            entity.Property(e => e.Aporte).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<PuestoTrabajo>(entity =>
        {
            entity.HasKey(e => e.IdPuestoTrabajo);

            entity.ToTable("PuestoTrabajo");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Sindicato>(entity =>
        {
            entity.HasKey(e => e.IdSindicato);

            entity.ToTable("Sindicato");

            entity.Property(e => e.Aporte).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.IdTarea);

            entity.ToTable("Tarea");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoExperiencia>(entity =>
        {
            entity.HasKey(e => e.IdTipoExperiencia);

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
