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
        Dim Mypic As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(JsonOutput.MyPicture)
        Dim Name As Paragraph = New Paragraph(JsonOutput.Name & vbLf & vbLf)

        Dim Obj As Paragraph = New Paragraph("OBJECTIVES" & vbLf & vbLf)
        Dim Divider1 As LineSeparator = New LineSeparator(5.0F, 110.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim Objectives As Paragraph = New Paragraph(JsonOutput.Objectives & vbLf & vbLf)

        Dim Data As Paragraph = New Paragraph("DATA" & vbLf & vbLf)
        Dim Divider2 As LineSeparator = New LineSeparator(5.0F, 110.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim ContactNumber As Paragraph = New Paragraph(JsonOutput.ContactNumber)
        Dim Address As Paragraph = New Paragraph(JsonOutput.Address)
        Dim Age As Paragraph = New Paragraph(JsonOutput.Age)
        Dim Email As Paragraph = New Paragraph(JsonOutput.Email & vbLf & vbLf)

        Dim Educ As Paragraph = New Paragraph("EDUCATION" & vbLf & vbLf)
        Dim Divider3 As LineSeparator = New LineSeparator(5.0F, 110.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim Education As Paragraph = New Paragraph(JsonOutput.Education & vbLf & vbLf)

        Dim Skl As Paragraph = New Paragraph("SKILLS" & vbLf & vbLf)
        Dim Divider4 As LineSeparator = New LineSeparator(5.0F, 110.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim Skills As Paragraph = New Paragraph(JsonOutput.Skills & vbLf & vbLf)

        Dim Name2 As Paragraph = New Paragraph(JsonOutput.Name2)

        Mypic.ScalePercent(10.0F)
        Mypic.Alignment = Element.ALIGN_CENTER
        CreatedPDF.Add(Mypic)

        Name.Font.Size = 30
        Name.Alignment = Element.ALIGN_CENTER
        CreatedPDF.Add(Name)

        Obj.Font.Size = 20
        Obj.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Obj)

        CreatedPDF.Add(Divider1)

        Objectives.Font.Size = 12
        Objectives.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Objectives)

        Data.Font.Size = 20
        Data.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Data)

        CreatedPDF.Add(Divider2)

        ContactNumber.Font.Size = 12
        ContactNumber.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(ContactNumber)

        Address.Font.Size = 12
        Address.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Address)

        Age.Font.Size = 12
        Age.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Age)

        Email.Font.Size = 12
        Email.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Email)

        Educ.Font.Size = 20
        Educ.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Educ)

        CreatedPDF.Add(Divider3)

        Education.Font.Size = 12
        Education.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Education)

        Skl.Font.Size = 20
        Skl.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Skl)

        CreatedPDF.Add(Divider4)

        Skills.Font.Size = 12
        Skills.Alignment = Element.ALIGN_LEFT
        CreatedPDF.Add(Skills)

        Name2.Font.Size = 18
        Name2.Alignment = Element.ALIGN_RIGHT
        CreatedPDF.Add(Name2)

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
        Public Property MyPicture As String
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
