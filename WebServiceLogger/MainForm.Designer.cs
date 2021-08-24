
namespace WebServiceLogger
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ()
    {
      this.LogTextBox = new System.Windows.Forms.RichTextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.FileWatcher = new System.IO.FileSystemWatcher();
      ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).BeginInit();
      this.SuspendLayout();
      // 
      // LogTextBox
      // 
      this.LogTextBox.AcceptsTab = true;
      this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LogTextBox.Location = new System.Drawing.Point(0, 24);
      this.LogTextBox.Name = "LogTextBox";
      this.LogTextBox.ReadOnly = true;
      this.LogTextBox.Size = new System.Drawing.Size(800, 426);
      this.LogTextBox.TabIndex = 0;
      this.LogTextBox.Text = "";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 428);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(800, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // FileWatcher
      // 
      this.FileWatcher.EnableRaisingEvents = true;
      this.FileWatcher.SynchronizingObject = this;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.LogTextBox);
      this.Controls.Add(this.menuStrip1);
      this.HelpButton = true;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Logger";
      ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox LogTextBox;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.IO.FileSystemWatcher FileWatcher;
  }
}

