namespace AnnouncementAPI;

public static class AnnouncementAPIDbProperties
{
    public static string DbTablePrefix { get; set; } = "AnnouncementAPI";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AnnouncementAPI";
}
