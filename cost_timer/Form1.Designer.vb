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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbNM = New System.Windows.Forms.Label()
        Me.txtNM = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnendwork = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.ComBoxPyt1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LbNM
        '
        Me.LbNM.BackColor = System.Drawing.Color.White
        Me.LbNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNM.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNM.Location = New System.Drawing.Point(6, 27)
        Me.LbNM.Name = "LbNM"
        Me.LbNM.Size = New System.Drawing.Size(126, 26)
        Me.LbNM.TabIndex = 0
        Me.LbNM.Text = "Project"
        '
        'txtNM
        '
        Me.txtNM.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNM.Location = New System.Drawing.Point(138, 56)
        Me.txtNM.Name = "txtNM"
        Me.txtNM.Size = New System.Drawing.Size(156, 26)
        Me.txtNM.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnendwork)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnstop)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnstart)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt1)
        Me.GroupBox1.Controls.Add(Me.txtNM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LbNM)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dane wejściowe"
        '
        'btnendwork
        '
        Me.btnendwork.Location = New System.Drawing.Point(366, 86)
        Me.btnendwork.Name = "btnendwork"
        Me.btnendwork.Size = New System.Drawing.Size(86, 47)
        Me.btnendwork.TabIndex = 5
        Me.btnendwork.Text = "End Work"
        Me.btnendwork.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(300, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label3"
        '
        'btnstop
        '
        Me.btnstop.Location = New System.Drawing.Point(98, 86)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(86, 47)
        Me.btnstop.TabIndex = 4
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(300, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(6, 86)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(86, 47)
        Me.btnstart.TabIndex = 3
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'ComBoxPyt1
        '
        Me.ComBoxPyt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxPyt1.Items.AddRange(New Object() {"DMA", "DKO", "DMO", "19003", "19035"})
        Me.ComBoxPyt1.Location = New System.Drawing.Point(6, 56)
        Me.ComBoxPyt1.Name = "ComBoxPyt1"
        Me.ComBoxPyt1.Size = New System.Drawing.Size(126, 24)
        Me.ComBoxPyt1.TabIndex = 1
        Me.ComBoxPyt1.Tag = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activities:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 157)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(458, 186)
        Me.TextBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(482, 355)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 450)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "Form1"
        Me.Text = "Work Timer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LbNM As System.Windows.Forms.Label
    Friend WithEvents txtNM As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComBoxPyt1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnendwork As System.Windows.Forms.Button
    Friend WithEvents btnstop As System.Windows.Forms.Button
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
