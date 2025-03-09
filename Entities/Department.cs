using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Department
{
    /// <summary>
    /// Код кафедры
    /// </summary>
    public int Code { get; set; }
    
    /// <summary>
    /// Полное наименование кафедры
    /// </summary>
    public string FullName { get; set; }
    
    /// <summary>
    /// Код преподавателя, являющегося заведующим кафедрой.
    /// </summary>
    /// <remarks>
    /// Внешний ключ к таблице teacher
    /// </remarks>
    public int Manager { get; set; }
}