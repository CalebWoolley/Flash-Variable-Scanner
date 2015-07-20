''' <summary>
''' Programmed entirely by Caleb Woolley, 2015.
''' </summary>
''' <remarks></remarks>

Public Class frmMain

#Region " Methods and Declarations "
    Public loadedMovie As String

    Private Delegate Sub SetControlPropertyThreadSafeDelegate(ByVal control As Control, ByVal propertyName As String, ByVal propertyValue As Object)
    Public Shared Sub SetControlPropertyThreadSafe(ByVal control As Control, ByVal propertyName As String, ByVal propertyValue As Object)
        If control.InvokeRequired Then
            control.Invoke(New SetControlPropertyThreadSafeDelegate(AddressOf SetControlPropertyThreadSafe), New Object() {control, propertyName, propertyValue})
        Else
            control.[GetType]().InvokeMember(propertyName, Reflection.BindingFlags.SetProperty, Nothing, control, New Object() {propertyValue})
        End If
        control.Refresh()
    End Sub
#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

    End Sub
#Region " File "
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next
        Status.Text = "Thank you - please be sure to leave your name!"
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JTBTYQRK7NX6C")
    End Sub
    Private Sub DonateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonateToolStripMenuItem.Click
        On Error Resume Next
        Status.Text = "Thank you - please be sure to leave your name!"
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JTBTYQRK7NX6C")
    End Sub

    Private Sub LoadNewMovieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadNewMovieToolStripMenuItem.Click
        loadSWF.ShowDialog()
    End Sub
#End Region

#Region " Flash Tools "
    Private Sub VariableScannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableScannerToolStripMenuItem.Click
        If loadedMovie = "" Then
            Status.Text = "Please load a flash document first." : Exit Sub
        End If
        Form1.Show()
        Form1.Focus()
    End Sub

    Private Sub DownloadMovieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadMovieToolStripMenuItem.Click
        If loadedMovie = "" Then
            Status.Text = "Please load a flash document first." : Exit Sub
        End If
        If loadSWF.UrlExists(loadedMovie) = False Then
            Status.Text = "The loaded movie isn't a valid file." : Exit Sub
        End If
        Dim t As New Threading.Thread(AddressOf downloadLoadedSwf)
        t.SetApartmentState(Threading.ApartmentState.STA)
        t.Start()
    End Sub

    Sub downloadLoadedSwf()
        Dim S As New SaveFileDialog
        S.Filter = "Flash File (*.swf)|*.swf"
        S.Title = "Save Flash Movie"
        S.ShowDialog()
        If S.FileName = "" Then Exit Sub
        Status.Text = "Downloading flash file..."
        Try
            Dim WC As New Net.WebClient
            WC.DownloadFile(loadedMovie, S.FileName)
            Status.Text = "Finished downloading flash file."
        Catch x As Exception
            Status.Text = ("Error: Couldn't download file.")
        End Try
    End Sub

    Private Sub VariableEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableEditorToolStripMenuItem.Click
        varEditor.Show()
        varEditor.Focus()
    End Sub

    Private Sub ForcePlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForcePlayToolStripMenuItem.Click
        flash.Play()
        Status.Text = ("Forced flash document to play.  Use this function to force a flash document to load.")
    End Sub

    Private Sub SkipFrameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkipFrameToolStripMenuItem.Click
        flash.FrameNum = flash.CurrentFrame + 1
    End Sub

    Private Sub HighToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighToolStripMenuItem.Click
        flash.Quality2 = "High" : HighToolStripMenuItem.Checked = True : MediumToolStripMenuItem.Checked = False : LowToolStripMenuItem.Checked = False
    End Sub

    Private Sub MediumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem.Click
        flash.Quality2 = "Medium" : HighToolStripMenuItem.Checked = False : MediumToolStripMenuItem.Checked = True : LowToolStripMenuItem.Checked = False
    End Sub

    Private Sub LowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowToolStripMenuItem.Click
        flash.Quality2 = "Low" : HighToolStripMenuItem.Checked = False : MediumToolStripMenuItem.Checked = False : LowToolStripMenuItem.Checked = True
    End Sub
#End Region

End Class