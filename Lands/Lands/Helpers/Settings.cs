namespace Lands.Helpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    public static class Settings
    {
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        const string sourceId = "SourceId";
        const string targetId = "TargetId";
        static readonly int intDefault = 0;

        public static int SourceId
        {
            get
            {
                return AppSettings.GetValueOrDefault(sourceId, intDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(sourceId, value);
            }
        }


        public static int TargetId
        {
            get
            {
                return AppSettings.GetValueOrDefault(targetId, intDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(targetId, value);
            }
        }
    }

}
