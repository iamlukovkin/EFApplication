namespace Entities;

public class StudentGroup
{
    /// <summary>
    /// Номер группы 
    /// </summary>
    public string Code { get; set; }
    
    /// <summary>
    /// Код куратора
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице teacher
    /// </remarks>
    public int Teacher { get; set; }
    
    /// <summary>
    /// Код кафедры
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице department
    /// </remarks>
    public int Department { get; set; }
}