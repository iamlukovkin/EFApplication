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
    public int Department { get; set; }
    
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
}