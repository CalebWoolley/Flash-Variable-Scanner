Public Class loadSWF

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim O As New OpenFileDialog
        O.Filter = "Flash Movie (*.swf)|*.swf"
        O.ShowDialog()
        If O.FileName = "" Then Exit Sub
        TextBox1.Text = O.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not TextBox1.Text.Contains(".swf") Then
            MessageBox.Show("The url you're trying to load doesn't contain .swf.", "Load SWF")
            Exit Sub
        End If
        Form1.Status("Loaded selected movie.")
        frmMain.flash.Movie = TextBox1.Text
        frmMain.loadedMovie = TextBox1.Text
        Form1.Close() : Me.Hide() : frmMain.Focus()
    End Sub

    Private Sub loadSWF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

#Region " URL Grabbing "
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim T As New Threading.Thread(AddressOf GrabURL)
        T.SetApartmentState(Threading.ApartmentState.STA)
        T.Start()
    End Sub

    Public Sub GrabURL()
        Try
            If Not UrlExists(TextBox2.Text) Then
                MessageBox.Show("Invalid URL or URL doesn't exist.", "URL Grabber") : Exit Sub
            End If
            Dim WC As New Net.WebClient
            Dim PageSource As String = WC.DownloadString(TextBox2.Text)

            If Not PageSource.Contains(".swf") Then
                MessageBox.Show("The page you requested doesn't seem to contain any swf URLs.  Check to make sure it actually has a flash movie on it.", "URL Grabber")
                Exit Sub
            End If

            PageSource = PageSource.Substring(PageSource.IndexOf("<param name=""movie"""))
            Dim SWFURL As String = (GetBetween(PageSource, "value=""", """"))

            If Not SWFURL.StartsWith("http") Then
                SWFURL = "http://" & New Uri(TextBox2.Text).Host & "/" & SWFURL
            End If
            MessageBox.Show("Found a flash file url.  Placing it into the loading box.", "URL Grabber")
            TextBox1.Text = SWFURL
        Catch x As Exception
            MessageBox.Show("Couldn't grab URL due to error: " & x.Message & "  Some URLs just can't be grabbed - try to do it manually.")
        End Try
    End Sub

    Public Shared Function UrlExists(ByVal Url As String) As Boolean
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.WebRequest.Create(Url), Net.HttpWebRequest)
            DirectCast(request.GetResponse, Net.HttpWebResponse).Close()
            Return True
        Catch
        End Try
        Return False
    End Function

    Public Function GetBetween(ByRef strSource As String, ByRef strStart As String, ByRef strEnd As String, Optional ByRef startPos As Integer = 0) As String
        On Error Resume Next
        Dim iPos As Integer, iEnd As Integer, lenStart As Integer = strStart.Length
        Dim strResult As String = "" : iPos = strSource.IndexOf(strStart, startPos)
        iEnd = strSource.IndexOf(strEnd, iPos + lenStart)
        If iPos <> -1 AndAlso iEnd <> -1 Then strResult = strSource.Substring(iPos + lenStart, iEnd - (iPos + lenStart))
        Return strResult
    End Function
#End Region

End Class