namespace DataAPI.Service
{
    public partial class OfflineData
    {
        public static example1 Example1 { get; } = new();
        public static example2 Example2 { get; } = new();
        public static example3 Example3 { get; } = new();
        public partial class example1 : IExample<ExampleModel1>
        {
            ExampleModel1 dataStorage;
            public void AddExample(ExampleModel1 data) => this.dataStorage = data;

            public void DelExample() => this.dataStorage = null;

            public bool ExistsExample() => this.dataStorage != null;

            public ExampleModel1 GetExample() => this.dataStorage;
        }
        public partial class example2 : IExample<ExampleModel2>
        {
            ExampleModel2 dataStorage;

            public void AddExample(ExampleModel2 data) => this.dataStorage = data;

            public void DelExample() => this.dataStorage = null;

            public bool ExistsExample() => this.dataStorage != null;

            public ExampleModel2 GetExample() => this.dataStorage;
        }
        public partial class example3 : IExample<ExampleModel3>
        {
            ExampleModel3 dataStorage;

            public void AddExample(ExampleModel3 data) => this.dataStorage = data;

            public void DelExample() => this.dataStorage = null;

            public bool ExistsExample() => this.dataStorage != null;

            public ExampleModel3 GetExample() => this.dataStorage;
        }
    }
}
