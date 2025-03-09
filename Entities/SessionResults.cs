namespace Entities;

public class SessionResults
{
    /// <summary>
    /// Код студента.
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице student
    /// </remarks>
    public int Student { get; set; }
    
    /// <summary>
    /// Код предмета.
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице subject
    /// </remarks>
    public int Subject { get; set; }
    
    /// <summary>
    /// Код преподавателя.
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице teacher
    /// </remarks>
    public int Teacher { get; set; }
    
    /// <summary>
    /// Дата экзамена
    /// </summary>
    public DateTime DateOfExam { get; set; }

    /// <summary>
    /// Оценка. 
    /// </summary>
    /// <remarks>
    /// По умолчанию - 3 (Аналог default в sql).
    /// </remarks>
    public int Mark { get; set; } = 3; 
}