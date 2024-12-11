<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txt1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txt2 = New TextBox()
        Label4 = New Label()
        btplus = New Label()
        btnfoix = New Label()
        btnmoin = New Label()
        btnsur = New Label()
        btnm = New Label()
        btneq = New Label()
        Label3 = New Label()
        lbl_res = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(139, 80)
        txt1.Multiline = True
        txt1.Name = "txt1"
        txt1.Size = New Size(170, 54)
        txt1.TabIndex = 0
        txt1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Pink
        Label1.Location = New Point(63, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 60)
        Label1.TabIndex = 1
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Pink
        Label2.Location = New Point(63, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 54)
        Label2.TabIndex = 2
        Label2.Text = "B"
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(139, 162)
        txt2.Multiline = True
        txt2.Name = "txt2"
        txt2.Size = New Size(170, 54)
        txt2.TabIndex = 3
        txt2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 8.25F)
        Label4.ForeColor = Color.IndianRed
        Label4.Location = New Point(539, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(13, 17)
        Label4.TabIndex = 5
        Label4.Text = "-"
        ' 
        ' btplus
        ' 
        btplus.AutoSize = True
        btplus.BackColor = Color.Transparent
        btplus.Font = New Font("Wide Latin", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btplus.ForeColor = Color.Pink
        btplus.Location = New Point(397, 60)
        btplus.Name = "btplus"
        btplus.Size = New Size(83, 98)
        btplus.TabIndex = 9
        btplus.Text = "+"
        ' 
        ' btnfoix
        ' 
        btnfoix.AutoSize = True
        btnfoix.BackColor = Color.Transparent
        btnfoix.Font = New Font("Wide Latin", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnfoix.ForeColor = Color.Pink
        btnfoix.Location = New Point(511, 60)
        btnfoix.Name = "btnfoix"
        btnfoix.Size = New Size(86, 98)
        btnfoix.TabIndex = 10
        btnfoix.Text = "*"
        ' 
        ' btnmoin
        ' 
        btnmoin.AutoSize = True
        btnmoin.BackColor = Color.Transparent
        btnmoin.Font = New Font("Wide Latin", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmoin.ForeColor = Color.Pink
        btnmoin.Location = New Point(637, 60)
        btnmoin.Name = "btnmoin"
        btnmoin.Size = New Size(79, 98)
        btnmoin.TabIndex = 11
        btnmoin.Text = "-"
        ' 
        ' btnsur
        ' 
        btnsur.AutoSize = True
        btnsur.BackColor = Color.Transparent
        btnsur.Font = New Font("Wide Latin", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsur.ForeColor = Color.Pink
        btnsur.Location = New Point(397, 180)
        btnsur.Name = "btnsur"
        btnsur.Size = New Size(102, 98)
        btnsur.TabIndex = 12
        btnsur.Text = "/"
        ' 
        ' btnm
        ' 
        btnm.AutoSize = True
        btnm.BackColor = Color.Transparent
        btnm.Font = New Font("Wide Latin", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnm.ForeColor = Color.Pink
        btnm.Location = New Point(539, 180)
        btnm.Name = "btnm"
        btnm.Size = New Size(148, 98)
        btnm.TabIndex = 13
        btnm.Text = "%"
        ' 
        ' btneq
        ' 
        btneq.AutoSize = True
        btneq.BackColor = Color.Transparent
        btneq.Font = New Font("Wide Latin", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btneq.ForeColor = Color.Pink
        btneq.Location = New Point(494, 319)
        btneq.Name = "btneq"
        btneq.Size = New Size(83, 98)
        btneq.TabIndex = 14
        btneq.Text = "="
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(114, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 41)
        Label3.TabIndex = 15
        ' 
        ' lbl_res
        ' 
        lbl_res.BackColor = Color.LightSteelBlue
        lbl_res.Location = New Point(209, 350)
        lbl_res.Multiline = True
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(224, 54)
        lbl_res.TabIndex = 16
        lbl_res.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Pink
        Label5.Location = New Point(21, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 54)
        Label5.TabIndex = 17
        Label5.Text = "Résultat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(lbl_res)
        Controls.Add(Label3)
        Controls.Add(btneq)
        Controls.Add(btnm)
        Controls.Add(btnsur)
        Controls.Add(btnmoin)
        Controls.Add(btnfoix)
        Controls.Add(btplus)
        Controls.Add(Label4)
        Controls.Add(txt2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt1)
        Name = "Form1"
        Text = "+"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btplus As Label
    Friend WithEvents btnfoix As Label
    Friend WithEvents btnmoin As Label
    Friend WithEvents btnsur As Label
    Friend WithEvents btnm As Label
    Friend WithEvents btneq As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_res As TextBox
    Friend WithEvents Label5 As Label

End Class
