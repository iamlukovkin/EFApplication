using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("subject")]
public class Subject
{
    /// <summary>
    /// Код предмета
    /// </summary>
    [Key]
    [Column("code")]
    public int Code { get; set; }

    /// <summary>
    /// Полное наименование дисциплины
    /// </summary>
    [Required]
    [MaxLength(50)]
    [Column("full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// Число академических часов, отведенных на дисциплину
    /// </summary>
    [Required]
    [Column("hours_count")]
    public int HoursCount { get; set; }

    /// <summary>
    /// Число семестров, отведенных на дисциплину
    /// </summary>
    [Required]
    [Column("semesters_count")]
    public int SemestersCount { get; set; }
}