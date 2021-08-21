using System;

namespace DataAPI
{
    public partial class Program
    {
        ExampleModel1 empty = new() { Name = "Empty" };
        IDataService dataService = new DataService();
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
            Program p2 = new Program();
            p2.test();
        }

        public void Start()
        {
            ExampleModel1 value1 = new() { ID = 1, Name = "Max", Vorname = "Mustermann" };
            ExampleModel1 value2 = new() { ID = 2, Name = "Maxine", Vorname = "Musterfrau" };
            ExampleModel2 value3 = new() { ID = 1, Bezeichnung = "iSiLog App test", TimeStamp = DateTime.MinValue };
            ExampleModel2 value4 = new() { ID = 3, Bezeichnung = "iSiLog App test2", TimeStamp = DateTime.Now };
            ExampleModel3 value5 = new() { Bezeichnung = "iSiLog App", ProgramID = Guid.NewGuid() };
            ExampleModel3 value6 = new() { Bezeichnung = "isiSecure", ProgramID = Guid.Empty };

            Console.WriteLine("###################\nOnline Test\n");
            #region OnlineTest
            Console.WriteLine(this.dataService.IsOfflineMode());
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            this.dataService.Example1.AddExample(value1);
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            Console.WriteLine(this.dataService.Example1.GetExample() ?? empty);
            this.dataService.Example1.DelExample();
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            this.dataService.Example1.AddExample(value2);
            #endregion

            this.dataService.SetOfflineMode(true);
            Console.WriteLine("###################\nOffline Test\n");
            #region OfflineTest
            Console.WriteLine(this.dataService.IsOfflineMode());
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            this.dataService.Example1.AddExample(value2);
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            Console.WriteLine(this.dataService.Example1.GetExample() ?? empty);
            this.dataService.Example1.DelExample();
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            #endregion

            this.dataService.SetOfflineMode(false);

            Console.WriteLine("###################\nOnline Test 2\n");
            #region OnlineTest
            Console.WriteLine(this.dataService.IsOfflineMode());
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            Console.WriteLine(this.dataService.Example1.GetExample() ?? empty);
            #endregion

            this.dataService.SetOfflineMode(true);
            Console.WriteLine("###################\nOffline Test 2\n");
            #region OfflineTest
            Console.WriteLine(this.dataService.IsOfflineMode());
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            Console.WriteLine(this.dataService.Example1.GetExample() ?? empty);
            #endregion

            this.dataService.SetOfflineMode(false);
        }

        public void test()
        {
            Console.WriteLine("###################\nTest 3\n");
            Console.WriteLine(this.dataService.IsOfflineMode());
            Console.WriteLine(this.dataService.Example1.ExistsExample());
            Console.WriteLine(this.dataService.Example1.GetExample() ?? empty);
        }
    }
}
