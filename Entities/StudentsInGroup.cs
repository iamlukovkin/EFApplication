using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("students_in_group")]
public class StudentsInGroup
{
    // TODO: Описать составной ключ (student, group_name) во Fluent API
    
    /// <summary>
    /// Код студента
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице student
    /// </remarks>
    [Column("student")]
    public int StudentFK { get; set; }
    
    /// <summary>
    /// Студент 
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public Student Student { get; set; } 
    
    /// <summary>
    /// Номер группы
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице student_group
    /// </remarks>
    [MaxLength(6)]
    [Column("group_name")]
    public string GroupName { get; set; }
    
    /// <summary>
    /// Группа
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public StudentGroup StudentGroup { get; set; }
    
    /// <summary>
    /// Дата начала обучения
    /// </summary>
    [Column("date_start")]
    public DateOnly DateStart { get; set; }
    
    /// <summary>
    /// Дата окончания обучения
    /// </summary>
    [Column("date_end")]
    public DateOnly DateEnd { get; set; }
}