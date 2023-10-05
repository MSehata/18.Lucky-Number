<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New Label()
        lblAge = New Label()
        lblYourLuckyNumber = New Label()
        txtComment = New TextBox()
        btnClose = New Button()
        btnDraw = New Button()
        txtName = New TextBox()
        txtYourLuckyNumber = New TextBox()
        txtAge = New TextBox()
        lblHeading = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(141, 109)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(141, 170)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(36, 20)
        lblAge.TabIndex = 1
        lblAge.Text = "Age"
        ' 
        ' lblYourLuckyNumber
        ' 
        lblYourLuckyNumber.AutoSize = True
        lblYourLuckyNumber.Location = New Point(141, 229)
        lblYourLuckyNumber.Name = "lblYourLuckyNumber"
        lblYourLuckyNumber.Size = New Size(130, 20)
        lblYourLuckyNumber.TabIndex = 2
        lblYourLuckyNumber.Text = "Your lucky number"
        ' 
        ' txtComment
        ' 
        txtComment.Location = New Point(154, 314)
        txtComment.Name = "txtComment"
        txtComment.Size = New Size(462, 27)
        txtComment.TabIndex = 3
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(330, 379)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 4
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnDraw
        ' 
        btnDraw.Location = New Point(532, 229)
        btnDraw.Name = "btnDraw"
        btnDraw.Size = New Size(94, 29)
        btnDraw.TabIndex = 4
        btnDraw.Text = "Draw"
        btnDraw.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(319, 102)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 5
        ' 
        ' txtYourLuckyNumber
        ' 
        txtYourLuckyNumber.Location = New Point(319, 222)
        txtYourLuckyNumber.Name = "txtYourLuckyNumber"
        txtYourLuckyNumber.Size = New Size(125, 27)
        txtYourLuckyNumber.TabIndex = 5
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(319, 167)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 5
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblHeading.ForeColor = SystemColors.Highlight
        lblHeading.Location = New Point(132, 29)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(548, 35)
        lblHeading.TabIndex = 0
        lblHeading.Text = "How Lucky is your lucky number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtAge)
        Controls.Add(txtYourLuckyNumber)
        Controls.Add(txtName)
        Controls.Add(btnDraw)
        Controls.Add(btnClose)
        Controls.Add(txtComment)
        Controls.Add(lblYourLuckyNumber)
        Controls.Add(lblAge)
        Controls.Add(lblHeading)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Lucky Number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblYourLuckyNumber As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDraw As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYourLuckyNumber As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblHeading As Label
End Class
