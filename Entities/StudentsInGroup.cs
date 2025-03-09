namespace Entities;

public class StudentsInGroup
{
    /// <summary>
    /// Код студента
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице student
    /// </remarks>
    public int Student { get; set; }
    
    /// <summary>
    /// Номер группы
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице student_group
    /// </remarks>
    public string GroupName { get; set; }
    
    /// <summary>
    /// Дата начала обучения
    /// </summary>
    public DateOnly DateStart { get; set; }
    
    /// <summary>
    /// Дата окончания обучения
    /// </summary>
    public DateOnly DateEnd { get; set; }
}