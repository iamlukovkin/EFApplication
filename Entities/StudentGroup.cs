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
    public int Teacher { get; set; }
    
    /// <summary>
    /// Код кафедры
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице department
    /// </remarks>
    [Column("department")]
    public int Department { get; set; }
}