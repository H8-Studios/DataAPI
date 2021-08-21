using System;

namespace DataAPI
{
    public partial class ExampleModel1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public override string ToString() => $"{ID}: {Vorname} {Name}";
    }
    public partial class ExampleModel2
    {
        public int ID { get; set; }
        public string Bezeichnung { get; set; }
        public DateTime TimeStamp { get; set; }
        public override string ToString() => $"[{TimeStamp.ToString("dd.MM.yyyy HH:mm:ss")}] {ID}: {Bezeichnung}";
    }
    public partial class ExampleModel3
    {
        public Guid ProgramID { get; set; }
        public string Bezeichnung { get; set; }
        public override string ToString() => $"{Bezeichnung} #{ProgramID.ToString()}";
    }
}
