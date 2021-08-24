namespace Datext.MessagesLib
{
  public partial class MessageService : IMessageService
  {
    public Global Global
    {
      get { return _Global ?? (_Global = new Global ()); }
    }
    private Global _Global;
    public iSiLogApp iSiLogApp
    {
      get { return _iSiLogApp ?? (_iSiLogApp = new iSiLogApp ()); }
    }
    private iSiLogApp _iSiLogApp;
  }
}
