using System.Data.SqlTypes;

namespace Entities;

public class Student
{
    /// <summary>
    /// Код студента
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
    /// Дата рождения
    /// </summary>
    public DateTime Birthday { get; set; }
    
    /// <summary>
    /// Стипендия
    /// </summary>
    /// <remarks>
    /// Класс SqlMoney используется в качестве аналога типа данных money в sql.
    /// </remarks>
    public SqlMoney Scholarship { get; set; }
    
    /// <summary>
    /// Возраст. 
    /// </summary>
    /// <remarks>
    /// Используется как свойство студента, не сохраняющееся в базе данных.
    /// </remarks>
    public TimeSpan Age => DateTime.Now - Birthday;
}