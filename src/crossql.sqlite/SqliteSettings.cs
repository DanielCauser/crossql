using System;

namespace crossql.sqlite
{
    public class SqliteSettings
    {
        // Default Values
        //-----------------------------
        private int _pageSize = 1024;
        //-----------------------------

        public SQLiteJournalModeEnum JournalMode { get; set; } = SQLiteJournalModeEnum.Delete;

        public int PageSize
        {
            get => _pageSize;
            set
            {
                if (value > 65536)
                {
                    CacheSize = 65536;
                }
                else
                {
                    _pageSize = value;
                }
            }
        }

        public TimeSpan DefaultTimeout { get; set; } = TimeSpan.FromSeconds(0.1);

        public SynchronizationModes SynchronizationModes { get; set; } = SynchronizationModes.Normal;

        public int CacheSize { get; set; } = 2000;

        public bool FailIfMissing { get; set; } = true;

        public bool ReadOnly { get; set; }

        public bool EnforceForeignKeys { get; set; } = true;
        public static SqliteSettings Default => new SqliteSettings();
    }

    public enum SynchronizationModes
    {
        Full,
        Normal,
        Off
    }

    public enum SQLiteJournalModeEnum
    {
        Delete,
        Off,
        Persist
    }
}