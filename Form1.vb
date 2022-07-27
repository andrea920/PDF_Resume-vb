Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Public Class Form1
    Dim GetJsonFile As String = File.ReadAllText("mydetails.json")
    Dim JsonOutput As MyDetails = JsonConvert.DeserializeObject(Of MyDetails)(GetJsonFile)


    Private Sub BtnCreatePDF_Click(sender As Object, e As EventArgs) Handles BtnCreatePDF.Click
        Dim CreatedPDF As Document = New Document
        PdfWriter.GetInstance(CreatedPDF, New FileStream("Perido, Ma. Andrea.pdf", FileMode.Create))
        CreatedPDF.Open()
        Dim Name As Paragraph = New Paragraph(JsonOutput.Name)

        'CreatedPDF.Add(New Paragraph(JsonOutput.Name))
        'CreatedPDF.Add(New Paragraph(JsonOutput.Objectives))
        'CreatedPDF.Add(New Paragraph(JsonOutput.ContactNumber))
        'CreatedPDF.Add(New Paragraph(JsonOutput.Address))
        'CreatedPDF.Add(New Paragraph(JsonOutput.Age))
        'CreatedPDF.Add(New Paragraph(JsonOutput.Email))
        'CreatedPDF.Add(New Paragraph(JsonOutput.Education))
        'CreatedPDF.Add(New Paragraph(JsonOutput.Skills))
        'CreatedPDF.Add(New Paragraph(JsonOutput.Name2))


        Name.Font.Size = 30
        CreatedPDF.Add(Name)






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
