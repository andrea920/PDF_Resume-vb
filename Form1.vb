Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Public Class Form1
    Private Sub BtnCreatePDF_Click(sender As Object, e As EventArgs) Handles BtnCreatePDF.Click
        Dim CreatedPDF As Document = New Document
        PdfWriter.GetInstance(CreatedPDF, New FileStream("Perido, Ma. Andrea.pdf", FileMode.Create))

        CreatedPDF.Open()
        CreatedPDF.Add(New Paragraph("Hello I'm Andrea"))
        CreatedPDF.Close()
        MsgBox("Resume Created (PDF)")

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim AppExit = MessageBox.Show("Are you sure to exit the application?", "Resume Creator (PDF)", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If AppExit = vbYes Then
            Application.Exit()
        End If
    End Sub
    Public Class MyDetails
        Public Property Name As String
        Public Property Objectives As String
        Public Property ContactNumber As String
        Public Property Address As String
        Public Property Age As String
        Public Property Email As String
        Public Property Education As String
        Public Property Skills As String
        Public Property Name2 As String
    End Class

End Class
