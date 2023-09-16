using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class SysCexpertContext : DbContext
{
    public SysCexpertContext()
    {
    }

    public SysCexpertContext(DbContextOptions<SysCexpertContext> options)
        : base(options)
    {
    }
    public static SysCexpertContext GetMyDbContext(string databaseName)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SysCexpertContext>();

        optionsBuilder.UseSqlServer($@"Data Source=.\SqlExpress;Initial Catalog={databaseName};Integrated Security=True");

        return new SysCexpertContext(optionsBuilder.Options);

    }
    public virtual DbSet<Diagnostico> Diagnosticos { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<Estudio> Estudios { get; set; }

    public virtual DbSet<EstudioPaciente> EstudioPacientes { get; set; }

    public virtual DbSet<Guardium> Guardia { get; set; }

    public virtual DbSet<HistorialPaciente> HistorialPacientes { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<HorarioProfesional> HorarioProfesionals { get; set; }

    public virtual DbSet<Medico> Medicos { get; set; }

    public virtual DbSet<MedicoPorEspecialidum> MedicoPorEspecialida { get; set; }

    public virtual DbSet<ObraSocial> ObraSocials { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Recepcionistum> Recepcionista { get; set; }

    public virtual DbSet<Sintoma> Sintomas { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=SysCExpert; Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Diagnostico>(entity =>
        {
            entity.ToTable("Diagnostico");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Diagnostico1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Diagnostico");
            entity.Property(e => e.Dnipaciente).HasColumnName("DNIPaciente");
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.DnipacienteNavigation).WithMany(p => p.Diagnosticos)
                .HasForeignKey(d => d.Dnipaciente)
                .HasConstraintName("FK_Diagnostico_Paciente");

            entity.HasOne(d => d.MatriculaMedicoNavigation).WithMany(p => p.Diagnosticos)
                .HasForeignKey(d => d.MatriculaMedico)
                .HasConstraintName("FK_Diagnostico_Medico");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.ToTable("Especialidad");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Especialidad1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Especialidad");
        });

        modelBuilder.Entity<Estudio>(entity =>
        {
            entity.ToTable("Estudio");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Estudio1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estudio");
        });

        modelBuilder.Entity<EstudioPaciente>(entity =>
        {
            entity.ToTable("EstudioPaciente");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Comentario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dnipaciente).HasColumnName("DNIPaciente");
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.DnipacienteNavigation).WithMany(p => p.EstudioPacientes)
                .HasForeignKey(d => d.Dnipaciente)
                .HasConstraintName("FK_EstudioPaciente_Paciente");

            entity.HasOne(d => d.IdEstudioNavigation).WithMany(p => p.EstudioPacientes)
                .HasForeignKey(d => d.IdEstudio)
                .HasConstraintName("FK_EstudioPaciente_Estudio");

            entity.HasOne(d => d.MatriculaMedicoNavigation).WithMany(p => p.EstudioPacientes)
                .HasForeignKey(d => d.MatriculaMedico)
                .HasConstraintName("FK_EstudioPaciente_Medico");
        });

        modelBuilder.Entity<Guardium>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Dnipaciente).HasColumnName("DNIPaciente");
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.DnipacienteNavigation).WithMany(p => p.Guardia)
                .HasForeignKey(d => d.Dnipaciente)
                .HasConstraintName("FK_Guardia_Paciente");

            entity.HasOne(d => d.MatriculaMedicoNavigation).WithMany(p => p.Guardia)
                .HasForeignKey(d => d.MatriculaMedico)
                .HasConstraintName("FK_Guardia_Medico");
        });

        modelBuilder.Entity<HistorialPaciente>(entity =>
        {
            entity.ToTable("HistorialPaciente");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Comentario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dnipaciente).HasColumnName("DNIPaciente");
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.DnipacienteNavigation).WithMany(p => p.HistorialPacientes)
                .HasForeignKey(d => d.Dnipaciente)
                .HasConstraintName("FK_HistorialPaciente_Paciente");

            entity.HasOne(d => d.MatriculaMedicoNavigation).WithMany(p => p.HistorialPacientes)
                .HasForeignKey(d => d.MatriculaMedico)
                .HasConstraintName("FK_HistorialPaciente_Medico");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.ToTable("Horario");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Horario1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Horario");
        });

        modelBuilder.Entity<HorarioProfesional>(entity =>
        {
            entity.HasKey(e => new { e.MatriculaMedico, e.IdHorario });

            entity.ToTable("HorarioProfesional");

            entity.HasOne(d => d.IdHorarioNavigation).WithMany(p => p.HorarioProfesionals)
                .HasForeignKey(d => d.IdHorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioProfesional_Horario");

            entity.HasOne(d => d.MatriculaMedicoNavigation).WithMany(p => p.HorarioProfesionals)
                .HasForeignKey(d => d.MatriculaMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioProfesional_Medico");
        });

        modelBuilder.Entity<Medico>(entity =>
        {
            entity.HasKey(e => e.Matricula);

            entity.ToTable("Medico");

            entity.Property(e => e.Matricula).ValueGeneratedNever();
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedicoPorEspecialidum>(entity =>
        {
            entity.HasKey(e => new { e.MatriculaMedico, e.IdEspecialidad });

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany(p => p.MedicoPorEspecialida)
                .HasForeignKey(d => d.IdEspecialidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicoPorEspecialida_Especialidad");

            entity.HasOne(d => d.MatriculaMedicoNavigation).WithMany(p => p.MedicoPorEspecialida)
                .HasForeignKey(d => d.MatriculaMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicoPorEspecialida_Medico");
        });

        modelBuilder.Entity<ObraSocial>(entity =>
        {
            entity.ToTable("ObraSocial");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ObraSocial1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ObraSocial");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Dni);

            entity.ToTable("Paciente");

            entity.Property(e => e.Dni)
                .ValueGeneratedNever()
                .HasColumnName("DNI");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Domicilio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.IdPaciente).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasMany(d => d.IdObraSocials).WithMany(p => p.Dnipacientes)
                .UsingEntity<Dictionary<string, object>>(
                    "ObraSocialPaciente",
                    r => r.HasOne<ObraSocial>().WithMany()
                        .HasForeignKey("IdObraSocial")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ObraSocialPaciente_ObraSocial"),
                    l => l.HasOne<Paciente>().WithMany()
                        .HasForeignKey("Dnipaciente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ObraSocialPaciente_Paciente"),
                    j =>
                    {
                        j.HasKey("Dnipaciente", "IdObraSocial");
                        j.ToTable("ObraSocialPaciente");
                        j.IndexerProperty<int>("Dnipaciente").HasColumnName("DNIPaciente");
                    });
        });

        modelBuilder.Entity<Recepcionistum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sintoma>(entity =>
        {
            entity.HasKey(e => e.IdSintoma);

            entity.ToTable("Sintoma");

            entity.Property(e => e.IdSintoma).ValueGeneratedNever();
            entity.Property(e => e.Sintoma1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sintoma");

            entity.HasMany(d => d.Dnipacientes).WithMany(p => p.IdSintomas)
                .UsingEntity<Dictionary<string, object>>(
                    "SintomaPaciente",
                    r => r.HasOne<Paciente>().WithMany()
                        .HasForeignKey("Dnipaciente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SintomaPaciente_Paciente"),
                    l => l.HasOne<Sintoma>().WithMany()
                        .HasForeignKey("IdSintoma")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SintomaPaciente_Sintoma"),
                    j =>
                    {
                        j.HasKey("IdSintoma", "Dnipaciente");
                        j.ToTable("SintomaPaciente");
                        j.IndexerProperty<int>("Dnipaciente").HasColumnName("DNIPaciente");
                    });
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.ToTable("Turno");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.DniPacienteNavigation).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.DniPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turno_Paciente");

            entity.HasOne(d => d.IdRecepcionistaNavigation).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.IdRecepcionista)
                .HasConstraintName("FK_Turno_Recepcionista");

            entity.HasOne(d => d.MatriculaMedicoNavigation).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.MatriculaMedico)
                .HasConstraintName("FK_Turno_Medico");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
