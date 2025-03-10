using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("student_group")]
public class StudentGroup
{
    /// <summary>
    /// Номер группы 
    /// </summary>
    [Key]
    [MaxLength(6)]
    [Column("code")]
    public string Code { get; set; }
    
    /// <summary>
    /// Код куратора
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице teacher
    /// </remarks>
    [Column("teacher")]
    public int TeacherFK { get; set; }
    
    /// <summary>
    /// Преподаватель
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public Teacher Teacher { get; set; }
    
    /// <summary>
    /// Код кафедры
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
    /// Студенты, входящие в состав группы
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public List<Student> Students { get; set; }
}