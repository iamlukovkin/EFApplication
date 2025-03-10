using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("student")]
public class Student
{
    /// <summary>
    /// Код студента
    /// </summary>
    [Key]
    [Column("code")]
    public int Code { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    [Required]
    [Column("firstname")]
    public string FirstName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    [Required]
    [Column("lastname")]
    public string LastName { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    [Column("surname")]
    public string Surname { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    [Column("birthday")]
    public DateTime Birthday { get; set; }

    /// <summary>
    /// Стипендия
    /// </summary>
    /// <remarks>
    /// Класс decimal используется в качестве аналога типа данных money в sql.
    /// </remarks>
    [Column("scholarship", TypeName = "money")]
    public decimal Scholarship { get; set; }

    /// <summary>
    /// Возраст. 
    /// </summary>
    /// <remarks>
    /// Используется как свойство студента, не сохраняющееся в базе данных.
    /// </remarks>
    [NotMapped]
    public TimeSpan Age => DateTime.Now - Birthday;
    
    /// <summary>
    /// Экзамены, сдаваемые студентом
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public virtual List<SessionResults> SessionResults { get; set; }
    
    /// <summary>
    /// Группы, в которых числится студент 
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public virtual List<StudentGroup> Groups { get; set; }
}