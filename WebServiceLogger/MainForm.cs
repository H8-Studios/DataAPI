using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WebServiceLogger
{
  public partial class MainForm : Form
  {
    public string logPath { get; set; }
    //public string regKey { get; } = @"HKEY_LOCAL_MACHINE\SOFTWARE\Datext\";
    public string regKey { get; } = @"HKEY_LOCAL_MACHINE\SOFTWARE\IT-Keller\";
    public List<string> logFiles { get; set; } = new List<string>
    {
      "Service.log",
      "Tool.log",
      "App.log",
      "Software.log",
      "Common.log",
    };
    public List<string> softwareList { get; set; } = new List<string>
    {
      "iSiLog App",
      "Zahnstyle Lanservice",
    };

    public int logFileIndex { get; set; } = 0;
    public int softwareIndex { get; set; } = 1;

    public MainForm ()
    {
      InitializeComponent ();
      logPath = ((string) Registry.GetValue (regKey.PathMerge (softwareList[softwareIndex]), "InstPath", null)).PathMerge("Log", logFiles[logFileIndex]);
      FileWatcher.Path = logPath.RemoveFileFromPath();
      ReadFile (true);
      FileWatcher.Changed += FileWatcher_Changed;
    }
    
    private void FileWatcher_Changed (object sender, FileSystemEventArgs e)
    {
      ReadFile ();
    }

    private async void ReadFile (bool init = false)
    {
      if (string.IsNullOrEmpty (logPath)) return;
      if (!File.Exists (logPath)) return;
      string[] lines = await File.ReadAllLinesAsync (logPath);
      if (init) LogTextBox.Lines = lines;
      else this.Invoke ((MethodInvoker) (() => LogTextBox.Lines = lines));
    }
  }
}
