using DataAPI.Service;
using System;

namespace DataAPI
{
    public partial class DataService : IDataService
    {
        public void SyncData()
        {
            throw new NotImplementedException();
        }

        public partial class example1 : IExample<ExampleModel1>
        {
            public void AddExample(ExampleModel1 data)
            {
                if (IDataService.offlineMode) OfflineData.Example1.AddExample(data);
                else OnlineData.Example1.AddExample(data);
            }

            public void DelExample()
            {
                if (IDataService.offlineMode) OfflineData.Example1.DelExample();
                else OnlineData.Example1.DelExample();
            }

            public bool ExistsExample()
            {
                if (IDataService.offlineMode) return OfflineData.Example1.ExistsExample();
                else return OnlineData.Example1.ExistsExample();
            }

            public ExampleModel1 GetExample()
            {
                if (IDataService.offlineMode) return OfflineData.Example1.GetExample();
                else return OnlineData.Example1.GetExample();
            }

            public bool IsSameExample(ExampleModel1 data)
            {
                if (IDataService.offlineMode) return OfflineData.Example1.GetExample().Equals(data);
                else return OnlineData.Example1.GetExample().Equals(data);
            }
        }
        public partial class example2 : IExample<ExampleModel2>
        {
            public void AddExample(ExampleModel2 data)
            {
                if (IDataService.offlineMode) OfflineData.Example2.AddExample(data);
                else OnlineData.Example2.AddExample(data);
            }

            public void DelExample()
            {
                if (IDataService.offlineMode) OfflineData.Example2.DelExample();
                else OnlineData.Example2.DelExample();
            }

            public bool ExistsExample()
            {
                if (IDataService.offlineMode) return OfflineData.Example2.ExistsExample();
                else return OnlineData.Example2.ExistsExample();
            }

            public ExampleModel2 GetExample()
            {
                if (IDataService.offlineMode) return OfflineData.Example2.GetExample();
                else return OnlineData.Example2.GetExample();
            }

            public bool IsSameExample(ExampleModel2 data)
            {
                if (IDataService.offlineMode) return OfflineData.Example2.GetExample().Equals(data);
                else return OnlineData.Example2.GetExample().Equals(data);
            }
        }
        public partial class example3 : IExample<ExampleModel3>
        {
            public void AddExample(ExampleModel3 data)
            {
                if (IDataService.offlineMode) OfflineData.Example3.AddExample(data);
                else OnlineData.Example3.AddExample(data);
            }

            public void DelExample()
            {
                if (IDataService.offlineMode) OfflineData.Example3.DelExample();
                else OnlineData.Example3.DelExample();
            }

            public bool ExistsExample()
            {
                if (IDataService.offlineMode) return OfflineData.Example3.ExistsExample();
                else return OnlineData.Example3.ExistsExample();
            }

            public ExampleModel3 GetExample()
            {
                if (IDataService.offlineMode) return OfflineData.Example3.GetExample();
                else return OnlineData.Example3.GetExample();
            }

            public bool IsSameExample(ExampleModel3 data)
            {
                if (IDataService.offlineMode) return OfflineData.Example3.GetExample().Equals(data);
                else return OnlineData.Example3.GetExample().Equals(data);
            }
        }
    }
}
