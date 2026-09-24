using Microsoft.EntityFrameworkCore;

public class ClinicaOdontologicaAPIContext(DbContextOptions<ClinicaOdontologicaAPIContext> options) : DbContext(options)
{
    public DbSet<ClinicaOdontologica.Cita> Cita { get; set; } = default!;
    public DbSet<ClinicaOdontologica.Consultorio> Consultorio { get; set; } = default!;
    public DbSet<ClinicaOdontologica.DetalleCita> DetalleCita { get; set; } = default!;
    public DbSet<ClinicaOdontologica.Especialidad> Especialidad { get; set; } = default!;
    public DbSet<ClinicaOdontologica.Factura> Factura { get; set; } = default!;
    public DbSet<ClinicaOdontologica.HistorialMedico> HistorialMedico { get; set; } = default!;
    public DbSet<ClinicaOdontologica.Odontologo> Odontologo { get; set; } = default!;
    public DbSet<ClinicaOdontologica.Paciente> Paciente { get; set; } = default!;
    public DbSet<ClinicaOdontologica.Receta> Receta { get; set; } = default!;
    public DbSet<ClinicaOdontologica.Tratamiento> Tratamiento { get; set; } = default!;


}
