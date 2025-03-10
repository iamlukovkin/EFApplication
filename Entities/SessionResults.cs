using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("session_results")]
public class SessionResults
{
    // TODO: Описать составной ключ (student, subject, date_of_exam) во FluentAPI
    
    /// <summary>
    /// Код студента.
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
    /// Код предмета.
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице subject
    /// </remarks>
    [Column("subject")]
    public int SubjectFK { get; set; }
    
    /// <summary>
    /// Дисциплина
    /// </summary>
    /// <remarks>Свойство навишации</remarks>
    public Subject Subject { get; set; }
    
    /// <summary>
    /// Код преподавателя.
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
    /// Дата экзамена
    /// </summary>
    [Column("date_of_exam")]
    public DateTime DateOfExam { get; set; }

    /// <summary>
    /// Оценка. 
    /// </summary>
    /// <remarks>
    /// По умолчанию - 3 (Аналог default в sql).
    /// </remarks>
    [Required]
    [Column("mark")]
    public int Mark { get; set; } = 3; 
}