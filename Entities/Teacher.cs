namespace Entities;

public class Teacher
{
    /// <summary>
    /// Код
    /// </summary>
    public int Code { get; set; }
    
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Отчество
    /// </summary>
    public string LastName { get; set; }
 
    /// <summary>
    /// Фамилия
    /// </summary>
    public string Surname { get; set; }
    
    /// <summary>
    /// Код кафедры, к которой привязан преподаватель
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице department
    /// </remarks>
    public int Department { get; set; }
    
    /// <summary>
    /// Ученая степень
    /// </summary>
    public string Rank { get; set; }
    
    /// <summary>
    /// Должность на кафедре
    /// </summary>
    public string Post { get; set; }
}