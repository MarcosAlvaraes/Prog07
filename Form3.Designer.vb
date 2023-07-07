<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxComp = New System.Windows.Forms.TextBox()
        Me.TxtBoxLarg = New System.Windows.Forms.TextBox()
        Me.TxtBoxAltu = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCalcVol = New System.Windows.Forms.Button()
        Me.TxtBoxOutVol = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular volume do tanque:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtBoxAltu)
        Me.Panel1.Controls.Add(Me.TxtBoxLarg)
        Me.Panel1.Controls.Add(Me.TxtBoxComp)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(58, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 335)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Comprimento="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Largura="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 32)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Altura="
        '
        'TxtBoxComp
        '
        Me.TxtBoxComp.Location = New System.Drawing.Point(197, 55)
        Me.TxtBoxComp.Name = "TxtBoxComp"
        Me.TxtBoxComp.Size = New System.Drawing.Size(200, 39)
        Me.TxtBoxComp.TabIndex = 3
        '
        'TxtBoxLarg
        '
        Me.TxtBoxLarg.Location = New System.Drawing.Point(197, 165)
        Me.TxtBoxLarg.Name = "TxtBoxLarg"
        Me.TxtBoxLarg.Size = New System.Drawing.Size(200, 39)
        Me.TxtBoxLarg.TabIndex = 4
        '
        'TxtBoxAltu
        '
        Me.TxtBoxAltu.Location = New System.Drawing.Point(197, 259)
        Me.TxtBoxAltu.Name = "TxtBoxAltu"
        Me.TxtBoxAltu.Size = New System.Drawing.Size(200, 39)
        Me.TxtBoxAltu.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtBoxOutVol)
        Me.Panel2.Controls.Add(Me.BtnCalcVol)
        Me.Panel2.Location = New System.Drawing.Point(663, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 167)
        Me.Panel2.TabIndex = 2
        '
        'BtnCalcVol
        '
        Me.BtnCalcVol.Location = New System.Drawing.Point(45, 67)
        Me.BtnCalcVol.Name = "BtnCalcVol"
        Me.BtnCalcVol.Size = New System.Drawing.Size(210, 44)
        Me.BtnCalcVol.TabIndex = 0
        Me.BtnCalcVol.Text = "Calcular volume:"
        Me.BtnCalcVol.UseVisualStyleBackColor = True
        '
        'TxtBoxOutVol
        '
        Me.TxtBoxOutVol.Location = New System.Drawing.Point(319, 70)
        Me.TxtBoxOutVol.Name = "TxtBoxOutVol"
        Me.TxtBoxOutVol.Size = New System.Drawing.Size(272, 39)
        Me.TxtBoxOutVol.TabIndex = 1
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 642)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtBoxAltu As TextBox
    Friend WithEvents TxtBoxLarg As TextBox
    Friend WithEvents TxtBoxComp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtBoxOutVol As TextBox
    Friend WithEvents BtnCalcVol As Button
End Class
