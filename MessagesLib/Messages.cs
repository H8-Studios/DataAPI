namespace Datext.MessagesLib
{
  public partial class Messages
  {
    public string Titel { get; set; }
    public string Message { get; set; }

    public Messages (string Titel, string Message)
    {
      this.Titel = Titel;
      this.Message = Message;
    }

    public override string ToString () => this.Message;
    public static implicit operator string(Messages msg) => msg;
  }
}
