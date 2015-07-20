<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.flash = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FlashPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadNewMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashHackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariableScannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariableEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SkipFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForcePlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashQualityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.flash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flash
        '
        Me.flash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flash.Enabled = True
        Me.flash.Location = New System.Drawing.Point(0, 24)
        Me.flash.Name = "flash"
        Me.flash.OcxState = CType(resources.GetObject("flash.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flash.Size = New System.Drawing.Size(556, 424)
        Me.flash.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 448)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(556, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(29, 17)
        Me.Status.Text = "Idle."
        '
        'FlashPlayerToolStripMenuItem
        '
        Me.FlashPlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadNewMovieToolStripMenuItem, Me.ToolStripSeparator1, Me.DonateToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FlashPlayerToolStripMenuItem.Name = "FlashPlayerToolStripMenuItem"
        Me.FlashPlayerToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.FlashPlayerToolStripMenuItem.Text = "Application"
        '
        'LoadNewMovieToolStripMenuItem
        '
        Me.LoadNewMovieToolStripMenuItem.Name = "LoadNewMovieToolStripMenuItem"
        Me.LoadNewMovieToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LoadNewMovieToolStripMenuItem.Text = "Load New Movie"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FlashHackingToolStripMenuItem
        '
        Me.FlashHackingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VariableScannerToolStripMenuItem, Me.VariableEditorToolStripMenuItem, Me.ToolStripSeparator2, Me.SkipFrameToolStripMenuItem, Me.ForcePlayToolStripMenuItem, Me.DownloadMovieToolStripMenuItem, Me.FlashQualityToolStripMenuItem})
        Me.FlashHackingToolStripMenuItem.Name = "FlashHackingToolStripMenuItem"
        Me.FlashHackingToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.FlashHackingToolStripMenuItem.Text = "Flash Tools"
        '
        'VariableScannerToolStripMenuItem
        '
        Me.VariableScannerToolStripMenuItem.Name = "VariableScannerToolStripMenuItem"
        Me.VariableScannerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.VariableScannerToolStripMenuItem.Text = "Variable Scanner"
        '
        'VariableEditorToolStripMenuItem
        '
        Me.VariableEditorToolStripMenuItem.Name = "VariableEditorToolStripMenuItem"
        Me.VariableEditorToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.VariableEditorToolStripMenuItem.Text = "Variable Editor"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(173, 6)
        '
        'SkipFrameToolStripMenuItem
        '
        Me.SkipFrameToolStripMenuItem.Name = "SkipFrameToolStripMenuItem"
        Me.SkipFrameToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SkipFrameToolStripMenuItem.Text = "Skip To Next Frame"
        '
        'ForcePlayToolStripMenuItem
        '
        Me.ForcePlayToolStripMenuItem.Name = "ForcePlayToolStripMenuItem"
        Me.ForcePlayToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ForcePlayToolStripMenuItem.Text = "Force Play"
        '
        'DownloadMovieToolStripMenuItem
        '
        Me.DownloadMovieToolStripMenuItem.Name = "DownloadMovieToolStripMenuItem"
        Me.DownloadMovieToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DownloadMovieToolStripMenuItem.Text = "Download Movie"
        '
        'FlashQualityToolStripMenuItem
        '
        Me.FlashQualityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HighToolStripMenuItem, Me.MediumToolStripMenuItem, Me.LowToolStripMenuItem})
        Me.FlashQualityToolStripMenuItem.Name = "FlashQualityToolStripMenuItem"
        Me.FlashQualityToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FlashQualityToolStripMenuItem.Text = "Flash Quality"
        '
        'HighToolStripMenuItem
        '
        Me.HighToolStripMenuItem.Checked = True
        Me.HighToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HighToolStripMenuItem.Name = "HighToolStripMenuItem"
        Me.HighToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.HighToolStripMenuItem.Text = "High"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'LowToolStripMenuItem
        '
        Me.LowToolStripMenuItem.Name = "LowToolStripMenuItem"
        Me.LowToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.LowToolStripMenuItem.Text = "Low"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.ToolStripMenuItem1.Text = "Donate"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlashPlayerToolStripMenuItem, Me.FlashHackingToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(556, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 470)
        Me.Controls.Add(Me.flash)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flash Variable Scanner"
        CType(Me.flash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flash As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FlashPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadNewMovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlashHackingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariableScannerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariableEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SkipFrameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlashQualityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ForcePlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadMovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
