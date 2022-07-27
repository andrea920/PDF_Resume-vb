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
        Me.btnCreatePDF = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreatePDF
        '
        Me.btnCreatePDF.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnCreatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatePDF.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCreatePDF.Location = New System.Drawing.Point(124, 82)
        Me.btnCreatePDF.Name = "btnCreatePDF"
        Me.btnCreatePDF.Size = New System.Drawing.Size(141, 54)
        Me.btnCreatePDF.TabIndex = 0
        Me.btnCreatePDF.Text = "Create PDF"
        Me.btnCreatePDF.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepPink
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(124, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(406, 275)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCreatePDF)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resume Creator (PDF)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreatePDF As Button
    Friend WithEvents Button1 As Button
End Class
