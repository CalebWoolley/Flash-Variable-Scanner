Public Class varEditor

    Public Function GetVariable(ByVal var As String) As String
        Try
            Return frmMain.flash.GetVariable(var)
        Catch obj1 As Exception
            Return ""
        End Try
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not GetVariable(TextBox1.Text) = "" Then
            TextBox2.Text = GetVariable(TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmMain.flash.SetVariable(TextBox1.Text, TextBox2.Text)
    End Sub
End Class