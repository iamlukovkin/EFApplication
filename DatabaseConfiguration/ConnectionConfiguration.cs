namespace DatabaseConfiguration;

/// <summary>
/// Хранит свойства для подключения к СуБД
/// </summary>
public static class ConnectionConfiguration
{
    public static string Host { get; set; }
    public static int Port { get; set; }
    public static string Username { get; set; }
    public static string Password { get; set; }
    public static string Database { get; set; }

    /// <summary>
    /// Метод формирования строки подключения.
    /// </summary>
    /// <returns>Строка подключения с заполненными настройками.</returns>
    public static string GetConnectionString()
    {
        return $"Server={Host};" +
               $"Port={Port};" +
               $"Database={Database};" +
               $"User Id={Username};" +
               $"Password={Password};";
    }
}