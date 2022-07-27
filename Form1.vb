Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports Newtonsoft.Json
Public Class Form1
    Dim GetJsonFile As String = File.ReadAllText("mydetails.json")
    Dim JsonOutput As MyDetails = JsonConvert.DeserializeObject(Of MyDetails)(GetJsonFile)


    Private Sub BtnCreatePDF_Click(sender As Object, e As EventArgs) Handles BtnCreatePDF.Click
        Dim CreatedPDF As Document = New Document()
        PdfWriter.GetInstance(CreatedPDF, New FileStream("Perido, Ma. Andrea.pdf", FileMode.Create))
        CreatedPDF.Open()
        Dim Name As Paragraph = New Paragraph(JsonOutput.Name & vbLf & vbLf)
        Dim MyObjectives As Paragraph = New Paragraph("OBJECTIVES" & vbLf & vbLf)
        Dim Divider As LineSeparator = New LineSeparator(5.0F, 110.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim Objectives As Paragraph = New Paragraph(JsonOutput.Objectives)
        Dim ContactNumber As Paragraph = New Paragraph(JsonOutput.ContactNumber)
        Dim Address As Paragraph = New Paragraph(JsonOutput.Address)
        Dim Age As Paragraph = New Paragraph(JsonOutput.Age)
        Dim Email As Paragraph = New Paragraph(JsonOutput.Email)
        Dim Education As Paragraph = New Paragraph(JsonOutput.Education)
        Dim Skills As Paragraph = New Paragraph(JsonOutput.Skills)
        Dim Name2 As Paragraph = New Paragraph(JsonOutput.Name2)



        Name.Font.Size = 30
        Name.Alignment = Element.ALIGN_CENTER
        CreatedPDF.Add(Name)

        MyObjectives.Font.Size = 20
        MyObjectives.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(MyObjectives)

        CreatedPDF.Add(Divider)

        Objectives.Font.Size = 12
        Objectives.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Objectives)

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
