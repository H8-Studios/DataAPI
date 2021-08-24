namespace Datext.MessagesLib
{
  public partial class Global
  {

    //private static Messages _Msg900 = new Messages ("Erfolgreich", "Erfolgreich");
    //private static Messages _Msg901 = new Messages ("Anmeldefehler", "Die Zugangsdaten für den Benutzer „su“ sind ungültig.");
    //private static Messages _Msg902 = new Messages ("Verbindungsfehler", "Die Verbindung zum Server „%Server%“ konnte nicht hergestellt werden.");
    //private static Messages _Msg903 = new Messages ("Verbindungsfehler", "Die Verbindung zur Datenbank „%Datenbank%“ konnte nicht hergestellt werden.");
    //private static Messages _Msg904 = new Messages ("Fehler", "Hier ist ein Fehler aufgetreten.");
    //private static Messages _Msg905 = new Messages ("Verbindungsfehler", "Die Datenbank „%Datenbank%“ hat nicht das erwartete Format.");
    //private static Messages _Msg906 = new Messages ("Verbindungsfehler", "Die Datenbank „%Datenbank%“ hat nicht das erwartete Format oder der Benutzer „su“ hat keine ausreichenden Berechtigung für die Datenbank „%Datenbank%“");
    //private static Messages _Msg907 = new Messages ("Verbindungsfehler", "Der Benutzer „su“ hat keine ausreichenden Berechtigung für die Datenbank „%Datenbank%“");
    //private static Messages _Msg908 = new Messages ("Versionskonflikt", "Die Datenbankversion ist zu alt!\n\nBitte führen Sie ein Update von %Service% aus.");

    public Messages Msg900 { get; } = new Messages ("Erfolgreich", "Erfolgreich");
    public Messages Msg901 { get; } = new Messages ("Anmeldefehler", "Die Zugangsdaten für den Benutzer „su“ sind ungültig.");
    public Messages Msg902 { get; } = new Messages ("Verbindungsfehler", "Die Verbindung zum Server „%Server%“ konnte nicht hergestellt werden.");
    public Messages Msg903 { get; } = new Messages ("Verbindungsfehler", "Die Verbindung zur Datenbank „%Datenbank%“ konnte nicht hergestellt werden.");
    public Messages Msg904 { get; } = new Messages ("Fehler", "Hier ist ein Fehler aufgetreten.");
    public Messages Msg905 { get; } = new Messages ("Verbindungsfehler", "Die Datenbank „%Datenbank%“ hat nicht das erwartete Format.");
    public Messages Msg906 { get; } = new Messages ("Verbindungsfehler", "Die Datenbank „%Datenbank%“ hat nicht das erwartete Format oder der Benutzer „su“ hat keine ausreichenden Berechtigung für die Datenbank „%Datenbank%“");
    public Messages Msg907 { get; } = new Messages ("Verbindungsfehler", "Der Benutzer „su“ hat keine ausreichenden Berechtigung für die Datenbank „%Datenbank%“");
    public Messages Msg908 { get; } = new Messages ("Versionskonflikt", "Die Datenbankversion ist zu alt!\n\nBitte führen Sie ein Update von %Service% aus.");
  }
}
