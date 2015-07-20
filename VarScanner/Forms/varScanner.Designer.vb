<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.flashinfotxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListSet = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.filterTxt = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Status1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyForeignAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FreezeValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreezeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnfreezeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.flashinfotxt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 55)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SWF File Information and Details"
        '
        'flashinfotxt
        '
        Me.flashinfotxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.flashinfotxt.ForeColor = System.Drawing.Color.Black
        Me.flashinfotxt.Location = New System.Drawing.Point(116, 34)
        Me.flashinfotxt.Name = "flashinfotxt"
        Me.flashinfotxt.ReadOnly = True
        Me.flashinfotxt.Size = New System.Drawing.Size(278, 13)
        Me.flashinfotxt.TabIndex = 8
        Me.flashinfotxt.Text = "flash version, total frames, frame rate in fps, resolution, and etc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Flash File Information:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(72, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "      Highlight and scroll to see more information below."
        '
        'ListSet
        '
        Me.ListSet.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListSet.FullRowSelect = True
        Me.ListSet.GridLines = True
        Me.ListSet.Location = New System.Drawing.Point(12, 115)
        Me.ListSet.Name = "ListSet"
        Me.ListSet.Size = New System.Drawing.Size(403, 230)
        Me.ListSet.TabIndex = 3
        Me.ListSet.UseCompatibleStateImageBehavior = False
        Me.ListSet.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Variables"
        Me.ColumnHeader1.Width = 126
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Current Value"
        Me.ColumnHeader2.Width = 222
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Variable Filter:"
        '
        'filterTxt
        '
        Me.filterTxt.Location = New System.Drawing.Point(87, 88)
        Me.filterTxt.Name = "filterTxt"
        Me.filterTxt.Size = New System.Drawing.Size(231, 20)
        Me.filterTxt.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(324, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Grab Variables"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Status1
        '
        Me.Status1.AutoSize = True
        Me.Status1.Location = New System.Drawing.Point(19, 143)
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(27, 13)
        Me.Status1.TabIndex = 8
        Me.Status1.Text = "Idle."
        Me.Status1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "      This window scans for flash variables to be edited by right clicking on the" & _
            "m."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditValueToolStripMenuItem, Me.FreezeValueToolStripMenuItem, Me.RefreshValueToolStripMenuItem, Me.ToolStripSeparator1, Me.CopyToolStripMenuItem, Me.SaveListToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(140, 142)
        '
        'EditValueToolStripMenuItem
        '
        Me.EditValueToolStripMenuItem.Image = CType(resources.GetObject("EditValueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditValueToolStripMenuItem.Name = "EditValueToolStripMenuItem"
        Me.EditValueToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EditValueToolStripMenuItem.Text = "Edit Value"
        '
        'RefreshValueToolStripMenuItem
        '
        Me.RefreshValueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshSelectedToolStripMenuItem, Me.RefreshAllToolStripMenuItem})
        Me.RefreshValueToolStripMenuItem.Image = CType(resources.GetObject("RefreshValueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshValueToolStripMenuItem.Name = "RefreshValueToolStripMenuItem"
        Me.RefreshValueToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RefreshValueToolStripMenuItem.Text = "Refresh"
        '
        'RefreshSelectedToolStripMenuItem
        '
        Me.RefreshSelectedToolStripMenuItem.Image = CType(resources.GetObject("RefreshSelectedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshSelectedToolStripMenuItem.Name = "RefreshSelectedToolStripMenuItem"
        Me.RefreshSelectedToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RefreshSelectedToolStripMenuItem.Text = "Refresh Selected"
        '
        'RefreshAllToolStripMenuItem
        '
        Me.RefreshAllToolStripMenuItem.Image = CType(resources.GetObject("RefreshAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshAllToolStripMenuItem.Name = "RefreshAllToolStripMenuItem"
        Me.RefreshAllToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RefreshAllToolStripMenuItem.Text = "Refresh All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyAddressToolStripMenuItem, Me.CopyForeignAddressToolStripMenuItem})
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CopyAddressToolStripMenuItem
        '
        Me.CopyAddressToolStripMenuItem.Image = CType(resources.GetObject("CopyAddressToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyAddressToolStripMenuItem.Name = "CopyAddressToolStripMenuItem"
        Me.CopyAddressToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CopyAddressToolStripMenuItem.Text = "Copy Variable"
        '
        'CopyForeignAddressToolStripMenuItem
        '
        Me.CopyForeignAddressToolStripMenuItem.Image = CType(resources.GetObject("CopyForeignAddressToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyForeignAddressToolStripMenuItem.Name = "CopyForeignAddressToolStripMenuItem"
        Me.CopyForeignAddressToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CopyForeignAddressToolStripMenuItem.Text = "Copy Value"
        '
        'SaveListToolStripMenuItem
        '
        Me.SaveListToolStripMenuItem.Image = CType(resources.GetObject("SaveListToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveListToolStripMenuItem.Name = "SaveListToolStripMenuItem"
        Me.SaveListToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveListToolStripMenuItem.Text = "Save List"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'FreezeValueToolStripMenuItem
        '
        Me.FreezeValueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FreezeToolStripMenuItem, Me.UnfreezeToolStripMenuItem})
        Me.FreezeValueToolStripMenuItem.Image = CType(resources.GetObject("FreezeValueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FreezeValueToolStripMenuItem.Name = "FreezeValueToolStripMenuItem"
        Me.FreezeValueToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.FreezeValueToolStripMenuItem.Text = "Freeze Value"
        '
        'FreezeToolStripMenuItem
        '
        Me.FreezeToolStripMenuItem.Image = CType(resources.GetObject("FreezeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FreezeToolStripMenuItem.Name = "FreezeToolStripMenuItem"
        Me.FreezeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FreezeToolStripMenuItem.Text = "Freeze"
        '
        'UnfreezeToolStripMenuItem
        '
        Me.UnfreezeToolStripMenuItem.Image = CType(resources.GetObject("UnfreezeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UnfreezeToolStripMenuItem.Name = "UnfreezeToolStripMenuItem"
        Me.UnfreezeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UnfreezeToolStripMenuItem.Text = "Unfreeze"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(13, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(403, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "      No variables showing up?  Try starting the game and pausing it before scann" & _
            "ing."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 364)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Status1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.filterTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListSet)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AS 1/2 Variable Scanner"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents flashinfotxt As System.Windows.Forms.TextBox
    Friend WithEvents ListSet As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents filterTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Status1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyForeignAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FreezeValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreezeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnfreezeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
