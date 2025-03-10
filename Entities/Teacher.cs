using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("teacher")]
public class Teacher
{
    /// <summary>
    /// Код
    /// </summary>
    [Key]
    [Column("code")]
    public int Code { get; set; }
    
    /// <summary>
    /// Имя
    /// </summary>
    [Required]
    [MaxLength(50)]
    [Column("firstname")]
    public string FirstName { get; set; }
    
    /// <summary>
    /// Отчество
    /// </summary>
    [Required]
    [MaxLength(50)]
    [Column("lastname")]
    public string LastName { get; set; }
 
    /// <summary>
    /// Фамилия
    /// </summary>
    [MaxLength(50)]
    [Column("surname")]
    public string Surname { get; set; }
    
    /// <summary>
    /// Код кафедры, к которой привязан преподаватель
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице department
    /// </remarks>
    [Column("department")]
    public int DepartmentFK { get; set; }
    
    /// <summary>
    /// Кафедра 
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public Department Department { get; set; }
    
    /// <summary>
    /// Ученая степень
    /// </summary>
    [MaxLength(50)]
    [Column("rank")]
    public string Rank { get; set; }
    
    /// <summary>
    /// Должность на кафедре
    /// </summary>
    [MaxLength(50)]
    [Column("post")]
    public string Post { get; set; }
    
    /// <summary>
    /// Дисциплины, которые сдавали студенты данному преподавателю
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public virtual List<SessionResults> SessionResults { get; set; }
    
    /// <summary>
    /// Группы, у которых преподаватель является куратором 
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public virtual List<StudentGroup> StudentGroups { get; set; }
}