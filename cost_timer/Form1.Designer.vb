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
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComBox2 = New System.Windows.Forms.ComboBox()
        Me.LbJob = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnendwork = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.ComBox1 = New System.Windows.Forms.ComboBox()
        Me.LbAct = New System.Windows.Forms.Label()
        Me.txtBoxConsole = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        Me.LbNM.Size = New System.Drawing.Size(86, 26)
        Me.LbNM.TabIndex = 0
        Me.LbNM.Text = "Project:"
        '
        'txtBox1
        '
        Me.txtBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox1.Location = New System.Drawing.Point(238, 56)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(279, 26)
        Me.txtBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComBox2)
        Me.GroupBox1.Controls.Add(Me.LbJob)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnendwork)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnstop)
        Me.GroupBox1.Controls.Add(Me.btnstart)
        Me.GroupBox1.Controls.Add(Me.ComBox1)
        Me.GroupBox1.Controls.Add(Me.txtBox1)
        Me.GroupBox1.Controls.Add(Me.LbAct)
        Me.GroupBox1.Controls.Add(Me.LbNM)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dane wejściowe"
        '
        'ComBox2
        '
        Me.ComBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBox2.Items.AddRange(New Object() {"Wycena", "m - modelowanie", "r - rysunki", "d - dokumentacja", "s - schematy", "p - poprawki z błędów konstrukcyjnych", "lm - lista materiałowa", "mod - modyfikacje na prośbę klienta", "dod - dodatkowe elementy", "mon - spotkanie montażowe", "sk - spotkanie z klientem", "sa - spotkanie z automatykami", "so - spotkanie firmowe od projektu", "t - testy stanowiska", "k - kooperacja"})
        Me.ComBox2.Location = New System.Drawing.Point(98, 56)
        Me.ComBox2.Name = "ComBox2"
        Me.ComBox2.Size = New System.Drawing.Size(134, 24)
        Me.ComBox2.TabIndex = 8
        Me.ComBox2.Tag = ""
        '
        'LbJob
        '
        Me.LbJob.BackColor = System.Drawing.Color.White
        Me.LbJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbJob.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJob.Location = New System.Drawing.Point(98, 27)
        Me.LbJob.Name = "LbJob"
        Me.LbJob.Size = New System.Drawing.Size(86, 26)
        Me.LbJob.TabIndex = 7
        Me.LbJob.Text = "Job:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cost_Timer.My.Resources.Resources.sda1
        Me.PictureBox1.Location = New System.Drawing.Point(238, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnendwork
        '
        Me.btnendwork.Location = New System.Drawing.Point(431, 86)
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
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
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(6, 86)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(86, 47)
        Me.btnstart.TabIndex = 3
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'ComBox1
        '
        Me.ComBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBox1.Items.AddRange(New Object() {"DMA", "DKO", "DMO", "OP40", "19003", "19035"})
        Me.ComBox1.Location = New System.Drawing.Point(6, 56)
        Me.ComBox1.Name = "ComBox1"
        Me.ComBox1.Size = New System.Drawing.Size(86, 24)
        Me.ComBox1.TabIndex = 1
        Me.ComBox1.Tag = ""
        '
        'LbAct
        '
        Me.LbAct.BackColor = System.Drawing.Color.White
        Me.LbAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbAct.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAct.Location = New System.Drawing.Point(238, 29)
        Me.LbAct.Name = "LbAct"
        Me.LbAct.Size = New System.Drawing.Size(101, 26)
        Me.LbAct.TabIndex = 0
        Me.LbAct.Text = "Activities:"
        '
        'txtBoxConsole
        '
        Me.txtBoxConsole.BackColor = System.Drawing.Color.Black
        Me.txtBoxConsole.ForeColor = System.Drawing.Color.White
        Me.txtBoxConsole.Location = New System.Drawing.Point(12, 176)
        Me.txtBoxConsole.Multiline = True
        Me.txtBoxConsole.Name = "txtBoxConsole"
        Me.txtBoxConsole.ReadOnly = True
        Me.txtBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBoxConsole.Size = New System.Drawing.Size(523, 197)
        Me.txtBoxConsole.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(547, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Orange
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(47, 24)
        Me.ToolStripMenuItem1.Text = "Info"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Orange
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(547, 385)
        Me.Controls.Add(Me.txtBoxConsole)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(565, 430)
        Me.MinimumSize = New System.Drawing.Size(565, 430)
        Me.Name = "Form1"
        Me.Text = "Work Timer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LbNM As System.Windows.Forms.Label
    Friend WithEvents txtBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LbAct As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnendwork As System.Windows.Forms.Button
    Friend WithEvents btnstop As System.Windows.Forms.Button
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents txtBoxConsole As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LbJob As System.Windows.Forms.Label

End Class
