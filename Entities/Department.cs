using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("department")]
public class Department
{
    /// <summary>
    /// Код кафедры
    /// </summary>
    [Key]
    [Column("code")]
    public int Code { get; set; }
    
    /// <summary>
    /// Полное наименование кафедры
    /// </summary>
    [Required]
    [MaxLength(50)]
    [Column("full_name")]
    public string FullName { get; set; }
    
    /// <summary>
    /// Код преподавателя, являющегося заведующим кафедрой.
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице teacher
    /// </remarks>
    [Required]
    [Column("manager")] 
    public int ManagerFK { get; set; }
    
    /// <summary>
    /// Преподаватель
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public Teacher Manager { get; set; }
    
    /// <summary>
    /// Группы, привязанные к кафедре 
    /// </summary>
    /// <remarks>Свойство навигации</remarks>
    public virtual List<StudentGroup> StudentGroups { get; set; }
}