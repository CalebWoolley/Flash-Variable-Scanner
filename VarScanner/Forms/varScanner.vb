Imports System.IO
Imports System.IO.Compression

Public Class Form1
    Dim ActionScript, loadedMovie As String
    Dim axFlash As New AxShockwaveFlashObjects.AxShockwaveFlash
    Dim VariableList As New List(Of String)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        loadedMovie = frmMain.loadedMovie
        axFlash = frmMain.flash
        Dim T As New Threading.Thread(AddressOf flashStartup)
        T.SetApartmentState(Threading.ApartmentState.STA)
        T.Start()
        filterTxt.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If VariableList.Count = 0 Then
            Status("No actionscript has been loaded yet.")
            Exit Sub
        End If
        ListSet.Items.Clear() : frozenVars.Clear()
        axFlash = frmMain.flash
        Dim T As New Threading.Thread(AddressOf checkVariables)
        T.SetApartmentState(Threading.ApartmentState.STA)
        T.Start()
    End Sub

#Region " Flash File Loading "
    Sub flashStartup()
        VariableList.Clear()
        If IO.File.Exists(Application.StartupPath & "\temp.swf") Then IO.File.Delete(Application.StartupPath & "\temp.swf")
        If loadedMovie.StartsWith("http") Then
            Status("Flash document is online.  Downloading it (temporarily) for decompiling.")
            downloadSWF() : Status("Finished download.")
        Else
            Status("Temporarily copying flash file for decompiling.")
            IO.File.Copy(loadedMovie, Application.StartupPath & "\temp.swf", True)
        End If

        Dim ms As New MemoryStream
        readSWF(Application.StartupPath & "\temp.swf", ms)
        parseSWF(VariableList, ms)

        Status("Finished grabbing " & VariableList.Count & " possible variables.")
        Try
            If IO.File.Exists(Application.StartupPath & "\temp.swf") Then IO.File.Delete(Application.StartupPath & "\temp.swf")
        Catch

        End Try
    End Sub

    Public Sub downloadSWF()
        Try
            Dim WC As New Net.WebClient
            WC.DownloadFile(loadedMovie, Application.StartupPath & "\temp.swf")
        Catch x As Exception
            Status("Error: Couldn't download file.")
        End Try
    End Sub

    Public Function GetBetween(ByRef strSource As String, ByRef strStart As String, ByRef strEnd As String, Optional ByRef startPos As Integer = 0) As String
        On Error Resume Next
        Dim iPos As Integer, iEnd As Integer, lenStart As Integer = strStart.Length
        Dim strResult As String = "" : iPos = strSource.IndexOf(strStart, startPos)
        iEnd = strSource.IndexOf(strEnd, iPos + lenStart)
        If iPos <> -1 AndAlso iEnd <> -1 Then strResult = strSource.Substring(iPos + lenStart, iEnd - (iPos + lenStart))
        Return strResult
    End Function
#End Region

#Region " Flash Parsing "
    Public Sub AddToList(ByRef t1 As String, ByRef t2 As String)
        Dim objItems As ListViewItem
        objItems = ListSet.Items.Add(t1, 0)
        objItems.SubItems.Add(t2)
    End Sub
    Public Function GetVariable(ByVal var As String) As String
        On Error Resume Next
        Return Me.axFlash.GetVariable(var)
        Return ""
    End Function

    Public Sub checkVariables()
        Dim varCount, goodVars As Integer
        Dim varValue As String
        Dim totalCount As Integer = VariableList.Count

        For Each C As String In VariableList
            If varCount Mod 50 = 0 Then
                Status("Checking variables - pause game if slow... (" & varCount & "/" & totalCount & ")")
            End If
            varValue = GetVariable(C)
            If Not varValue = "" Then
                If varValue.Contains(filterTxt.Text) Or C.Contains(filterTxt.Text) Then
                    AddToList(C, varValue)
                    goodVars += 1
                End If
            End If
            varCount += 1
        Next

        Status("Finished.  Total variables grabbed: " & goodVars & ".") : axFlash = Nothing : GC.Collect()
    End Sub
#End Region

#Region " Status Changing "
    Public Sub Status(ByRef text As String)
        frmMain.SetControlPropertyThreadSafe(Status1, "Text", text)
    End Sub
    Private Sub Status1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Status1.TextChanged
        frmMain.Status.Text = Status1.Text
    End Sub
#End Region

#Region " Var Freezing "
    Dim frozenVars As New Dictionary(Of String, String)
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If frozenVars.Count = 0 Then Exit Sub
        For Each var As KeyValuePair(Of String, String) In frozenVars
            frmMain.flash.SetVariable(var.Key, var.Value)
        Next
    End Sub
#End Region

#Region " Listset Methods "
    Private Sub ListSet_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListSet.DoubleClick
        EditValueToolStripMenuItem.PerformClick()
    End Sub
    Private Sub ListSet_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListSet.MouseDown
        If ListSet.SelectedItems.Count = 0 Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.ContextMenuStrip1.Show(ListSet, e.Location)
        Else
            Try
                ListSet.SelectedItems(0).SubItems(1).Text = frmMain.flash.GetVariable(ListSet.SelectedItems(0).Text)
            Catch
                ListSet.SelectedItems(0).SubItems(1).Text = "Inactivated."
            End Try
        End If
    End Sub

    Private Sub FreezeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreezeToolStripMenuItem.Click
        If ListSet.SelectedItems(0).ForeColor = Color.SteelBlue Then Exit Sub
        Dim var As String = ListSet.SelectedItems(0).Text
        Dim val As String = ListSet.SelectedItems(0).SubItems(1).Text
        frozenVars.Add(var, val)
        ListSet.SelectedItems(0).ForeColor = Color.SteelBlue
    End Sub

    Private Sub UnfreezeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnfreezeToolStripMenuItem.Click
        If ListSet.SelectedItems(0).ForeColor = Color.Black Then Exit Sub
        Dim var As String = ListSet.SelectedItems(0).Text
        Dim val As String = ListSet.SelectedItems(0).SubItems(1).Text
        frozenVars.Remove(var)
        ListSet.SelectedItems(0).ForeColor = Color.Black
    End Sub

    Private Sub EditValueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditValueToolStripMenuItem.Click
        Dim Input As String = InputBox("Input the value that you'd like to set the variable to.", "Variable Editor", ListSet.SelectedItems(0).SubItems(1).Text)
        If Not Input = "" Then
            frmMain.flash.SetVariable(ListSet.SelectedItems(0).Text, Input)
            ListSet.SelectedItems(0).SubItems(1).Text = Input : Status("Updated variable.")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveListToolStripMenuItem.Click
        Dim varList As String = "Variable List" & vbNewLine
        For Each LVI As ListViewItem In ListSet.SelectedItems
            varList &= LVI.Text & ": " & LVI.SubItems(1).Text & vbNewLine
        Next
        Dim S As New SaveFileDialog
        S.Filter = "Text File (*.txt)|*.txt"
        S.Title = "Save Variables"
        S.ShowDialog()
        If S.FileName = "" Then Exit Sub
        IO.File.WriteAllText(S.FileName, varList)
    End Sub

    Private Sub RefreshAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshAllToolStripMenuItem.Click
        For Each LVI As ListViewItem In ListSet.Items
            Try
                LVI.SubItems(1).Text = frmMain.flash.GetVariable(LVI.Text)
            Catch x As Exception
                LVI.SubItems(1).Text = "Inactivated."
            End Try
        Next
        Status("Refreshed.")
    End Sub
    Private Sub RefreshSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshSelectedToolStripMenuItem.Click
        For Each LVI As ListViewItem In ListSet.SelectedItems
            Try
                LVI.SubItems(1).Text = frmMain.flash.GetVariable(LVI.Text)
            Catch x As Exception
                LVI.SubItems(1).Text = "Inactivated."
            End Try
        Next
        Status("Refreshed.")
    End Sub
#End Region



#Region " My Scanner "
    Private Sub readSWF(ByVal swfSource As String, ByRef ms As MemoryStream)
        Dim buffer(8 - 1) As Byte
        Dim WC As New Net.WebClient
        Try
            Dim plainStream As Stream = WC.OpenRead(swfSource)
            plainStream.Read(buffer, 0, 8)
            plainStream.Position = 10

            Dim stream As New DeflateStream(plainStream, CompressionMode.Decompress)
            Dim buffer2(8 - 1) As Byte

            Do While True
                Dim counter As Integer = stream.Read(buffer2, 0, buffer2.Length)
                If (counter <= 0) Then Exit Do
                ms.Write(buffer2, 0, counter)
            Loop
        Catch
        End Try
    End Sub

    Private Sub parseSWF(ByRef vars As List(Of String), ByVal ms As IO.MemoryStream)
        Dim buffer As Byte() = ms.ToArray
        Dim num, length As Integer
        Dim flag As Boolean = False

        For i As Integer = 1 To buffer.Length - 1
            Dim chrc As Byte = buffer(i)
            If ((((chrc = 95) Or ((chrc >= 48) And (chrc <= 57))) Or ((chrc >= 97) And (chrc <= 122))) Or ((chrc >= 65) And (chrc <= 90))) Then
                If flag Then
                    length += 1
                ElseIf (buffer((i - 1)) = 0) Then
                    flag = True
                    num = i
                    length = 1
                End If
            ElseIf flag Then
                If (((length > 1) And (length < 200)) And (chrc = 0)) Then
                    Dim chArray(length - 1) As Char
                    For m As Integer = 0 To length - 1
                        chArray(m) = ChrW(buffer(num + m))
                    Next
                    Dim var As New String(chArray, 0, length)
                    If Not vars.Contains(var) Then
                        vars.Add(var)
                    End If
                End If
                flag = False
            End If
        Next
        For UC As Integer = 65 To 90
            vars.Add(ChrW(UC))
        Next
        For lc As Integer = 97 To 122
            vars.Add(ChrW(lc))
        Next
    End Sub

    Private Sub InitFlashMovie(ByVal flashObj As AxShockwaveFlashObjects.AxShockwaveFlash, ByVal swfFile As Byte()) 'Not mine.
        Using stm As New MemoryStream()
            Using writer As New BinaryWriter(stm)
                ' Write length of stream for AxHost.State 

                writer.Write(8 + swfFile.Length)
                ' Write Flash magic 'hohoho' 

                writer.Write(&H55665566)
                ' Length of swf file 

                writer.Write(swfFile.Length)
                writer.Write(swfFile)
                stm.Seek(0, SeekOrigin.Begin)
                ' 1 == IPeristStreamInit 

                flashObj.OcxState = New AxHost.State(stm, 1, False, Nothing)
            End Using
        End Using
    End Sub
#End Region

End Class
