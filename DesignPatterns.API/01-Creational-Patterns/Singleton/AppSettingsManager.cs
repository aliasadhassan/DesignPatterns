namespace DesignPatterns.API._01_Creational_Patterns.Singleton
{
    // Thread-safe Singleton Class
    public sealed class AppSettingsManager
    {
        private static AppSettingsManager? _instance = null;
        private static readonly object _lock = new object();

        // 1. Private Constructor taake koi bahar se 'new' na kar sake
        private AppSettingsManager()
        {
            // Hypothetical settings load ho rahi hain
            ApplicationName = "Design Patterns Learning API";
            Version = "1.0.0";
        }

        // 2. Public Property jahan se poori app me ek hi instance milega
        public static AppSettingsManager Instance
        {
            get
            {
                // Double-check locking for thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new AppSettingsManager();
                        }
                    }
                }
                return _instance;
            }
        }

        // Dummy Properties to test
        public string ApplicationName { get; set; }
        public string Version { get; set; }
    }
}
