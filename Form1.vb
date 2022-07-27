Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Public Class Form1
    Private Sub BtnCreatePDF_Click(sender As Object, e As EventArgs) Handles BtnCreatePDF.Click

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim AppExit = MessageBox.Show("Are you sure to exit the application?", "Resume Creator (PDF)", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If AppExit = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class
