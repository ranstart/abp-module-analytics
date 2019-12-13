namespace Ran.Analytics
{
    public static class AnalyticsDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Analytics";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Analytics";
    }
}
