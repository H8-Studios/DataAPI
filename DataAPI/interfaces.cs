namespace DataAPI
{
    public interface IDataService
    {
        #region Base
        void SyncData();
        protected static bool offlineMode = false;
        public void SetOfflineMode(bool mode) => offlineMode = mode;
        public bool GetOfflineMode() => offlineMode;
        public bool IsOfflineMode() => offlineMode == true;
        #endregion

        DataService.example1 Example1 => example1;
        static DataService.example1 example1 = new DataService.example1();
        DataService.example2 Example2 => example2;
        static DataService.example2 example2 = new DataService.example2();
        DataService.example3 Example3 => example3;
        static DataService.example3 example3 = new DataService.example3();
    }

    public interface IExample<T>
    {
        T GetExample();
        void AddExample(T data);
        void DelExample();
        bool ExistsExample();
    }
}
