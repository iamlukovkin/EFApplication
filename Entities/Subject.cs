namespace Entities;

public class Subject
{
     /// <summary>
     /// Код предмета
     /// </summary>
     public int Code { get; set; }
     
     /// <summary>
     /// Полное наименование дисциплины
     /// </summary>
     public string FullName { get; set; }
     
     /// <summary>
     /// Число академических часов, отведенных на дисциплину
     /// </summary>
     public int HoursCount { get; set; }
     
     /// <summary>
     /// Число семестров, отведенных на дисциплину
     /// </summary>
     public int SemestersCount { get; set; }
}