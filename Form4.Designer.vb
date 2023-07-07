<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtBoxResul = New System.Windows.Forms.TextBox()
        Me.BtnSomar = New System.Windows.Forms.Button()
        Me.BtnSubtrair = New System.Windows.Forms.Button()
        Me.BtnMultiplicar = New System.Windows.Forms.Button()
        Me.BtnDividir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(229, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1657, 295)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtBoxResul)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(561, 487)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1059, 233)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnDividir)
        Me.Panel3.Controls.Add(Me.BtnMultiplicar)
        Me.Panel3.Controls.Add(Me.BtnSubtrair)
        Me.Panel3.Controls.Add(Me.BtnSomar)
        Me.Panel3.Location = New System.Drawing.Point(229, 762)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1638, 231)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insira um numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1192, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Insira um numero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Resultado:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(58, 127)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 39)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1110, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(357, 39)
        Me.TextBox2.TabIndex = 3
        '
        'TxtBoxResul
        '
        Me.TxtBoxResul.Location = New System.Drawing.Point(427, 98)
        Me.TxtBoxResul.Name = "TxtBoxResul"
        Me.TxtBoxResul.ReadOnly = True
        Me.TxtBoxResul.Size = New System.Drawing.Size(231, 39)
        Me.TxtBoxResul.TabIndex = 1
        '
        'BtnSomar
        '
        Me.BtnSomar.Location = New System.Drawing.Point(196, 80)
        Me.BtnSomar.Name = "BtnSomar"
        Me.BtnSomar.Size = New System.Drawing.Size(206, 82)
        Me.BtnSomar.TabIndex = 0
        Me.BtnSomar.Text = "Somar"
        Me.BtnSomar.UseVisualStyleBackColor = True
        '
        'BtnSubtrair
        '
        Me.BtnSubtrair.Location = New System.Drawing.Point(530, 80)
        Me.BtnSubtrair.Name = "BtnSubtrair"
        Me.BtnSubtrair.Size = New System.Drawing.Size(244, 82)
        Me.BtnSubtrair.TabIndex = 1
        Me.BtnSubtrair.Text = "Subtrair"
        Me.BtnSubtrair.UseVisualStyleBackColor = True
        '
        'BtnMultiplicar
        '
        Me.BtnMultiplicar.Location = New System.Drawing.Point(896, 80)
        Me.BtnMultiplicar.Name = "BtnMultiplicar"
        Me.BtnMultiplicar.Size = New System.Drawing.Size(253, 82)
        Me.BtnMultiplicar.TabIndex = 2
        Me.BtnMultiplicar.Text = "Multiplicar"
        Me.BtnMultiplicar.UseVisualStyleBackColor = True
        '
        'BtnDividir
        '
        Me.BtnDividir.Location = New System.Drawing.Point(1302, 80)
        Me.BtnDividir.Name = "BtnDividir"
        Me.BtnDividir.Size = New System.Drawing.Size(207, 82)
        Me.BtnDividir.TabIndex = 3
        Me.BtnDividir.Text = "Dividir"
        Me.BtnDividir.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2171, 1141)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtBoxResul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnDividir As Button
    Friend WithEvents BtnMultiplicar As Button
    Friend WithEvents BtnSubtrair As Button
    Friend WithEvents BtnSomar As Button
End Class
