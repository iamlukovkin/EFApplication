using Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConfiguration;

/// <summary>
/// Контекст базы данных
/// </summary>
public class StudentSessionContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<SessionResults> SessionResults { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentGroup> StudentGroups { get; set; }
    public DbSet<StudentsInGroup> StudentsInGroups { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    /// <summary>
    /// Процедура настройки моделей БД.
    /// Используется для Настройки таблиц с использованием Fluent API.
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SessionResults>()
            .HasKey(u => new { u.StudentFK, u.SubjectFK, u.DateOfExam});
        modelBuilder.Entity<StudentsInGroup>()
            .HasKey(u => new { u.StudentFK, u.GroupName });
        modelBuilder.Entity<Student>()
                    .HasMany(e => e.Groups)
                    .WithMany(e => e.Students)
                    .UsingEntity<StudentsInGroup>();
        modelBuilder.Entity<Department>()
            .HasOne(e => e.Manager)
            .WithOne(e => e.Department)
            .HasForeignKey<Teacher>(e => e.DepartmentFK);
    }
    
    /// <summary>
    /// Процедура, вызываемая при формировании базы данных.
    /// Добавлен вызов класса <c>ConnectionConfiguration</c> для получения строки подключения.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            ConnectionConfiguration.GetConnectionString(),
            options => options.UseAdminDatabase(ConnectionConfiguration.AdminDatabase));
    }
    
}