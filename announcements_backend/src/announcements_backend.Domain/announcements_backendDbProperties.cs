namespace announcements_backend;

public static class announcements_backendDbProperties
{
    public static string DbTablePrefix { get; set; } = "announcements_backend";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "announcements_backend";
}
