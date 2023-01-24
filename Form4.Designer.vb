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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnred = New System.Windows.Forms.Button()
        Me.btnblue = New System.Windows.Forms.Button()
        Me.btngreen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbsel = New System.Windows.Forms.ComboBox()
        Me.btnorange = New System.Windows.Forms.Button()
        Me.btnindigo = New System.Windows.Forms.Button()
        Me.btnyellow = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(288, 79)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(98, 30)
        Me.label1.TabIndex = 1
        Me.label1.Text = "User id :"
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(392, 79)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(228, 27)
        Me.txtuserid.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(408, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reset Password"
        '
        'btnred
        '
        Me.btnred.BackColor = System.Drawing.Color.Red
        Me.btnred.Location = New System.Drawing.Point(259, 377)
        Me.btnred.Name = "btnred"
        Me.btnred.Size = New System.Drawing.Size(112, 61)
        Me.btnred.TabIndex = 5
        Me.btnred.UseVisualStyleBackColor = False
        '
        'btnblue
        '
        Me.btnblue.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnblue.Location = New System.Drawing.Point(427, 377)
        Me.btnblue.Name = "btnblue"
        Me.btnblue.Size = New System.Drawing.Size(112, 61)
        Me.btnblue.TabIndex = 6
        Me.btnblue.UseVisualStyleBackColor = False
        '
        'btngreen
        '
        Me.btngreen.BackColor = System.Drawing.Color.LimeGreen
        Me.btngreen.Location = New System.Drawing.Point(583, 377)
        Me.btngreen.Name = "btngreen"
        Me.btngreen.Size = New System.Drawing.Size(112, 61)
        Me.btngreen.TabIndex = 7
        Me.btngreen.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(427, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbsel
        '
        Me.cmbsel.FormattingEnabled = True
        Me.cmbsel.Items.AddRange(New Object() {"Red", "Blue", "Green", "Pink", "Indigo", "Yellow", "Orange"})
        Me.cmbsel.Location = New System.Drawing.Point(408, 204)
        Me.cmbsel.Name = "cmbsel"
        Me.cmbsel.Size = New System.Drawing.Size(151, 28)
        Me.cmbsel.TabIndex = 19
        '
        'btnorange
        '
        Me.btnorange.BackColor = System.Drawing.Color.OrangeRed
        Me.btnorange.Location = New System.Drawing.Point(259, 291)
        Me.btnorange.Name = "btnorange"
        Me.btnorange.Size = New System.Drawing.Size(112, 61)
        Me.btnorange.TabIndex = 23
        Me.btnorange.UseVisualStyleBackColor = False
        '
        'btnindigo
        '
        Me.btnindigo.BackColor = System.Drawing.Color.Indigo
        Me.btnindigo.Location = New System.Drawing.Point(427, 291)
        Me.btnindigo.Name = "btnindigo"
        Me.btnindigo.Size = New System.Drawing.Size(112, 61)
        Me.btnindigo.TabIndex = 24
        Me.btnindigo.UseVisualStyleBackColor = False
        '
        'btnyellow
        '
        Me.btnyellow.BackColor = System.Drawing.Color.Yellow
        Me.btnyellow.Location = New System.Drawing.Point(583, 291)
        Me.btnyellow.Name = "btnyellow"
        Me.btnyellow.Size = New System.Drawing.Size(112, 61)
        Me.btnyellow.TabIndex = 25
        Me.btnyellow.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button7.Location = New System.Drawing.Point(762, 204)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 36)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "Add Colour"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1013, 721)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnyellow)
        Me.Controls.Add(Me.btnindigo)
        Me.Controls.Add(Me.btnorange)
        Me.Controls.Add(Me.cmbsel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btngreen)
        Me.Controls.Add(Me.btnblue)
        Me.Controls.Add(Me.btnred)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnred As Button
    Friend WithEvents btnblue As Button
    Friend WithEvents btngreen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbsel As ComboBox
    Friend WithEvents btnorange As Button
    Friend WithEvents btnindigo As Button
    Friend WithEvents btnyellow As Button
    Friend WithEvents Button7 As Button
End Class
