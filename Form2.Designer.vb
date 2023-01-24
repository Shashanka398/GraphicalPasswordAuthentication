<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.btnred = New System.Windows.Forms.Button()
        Me.btnblue = New System.Windows.Forms.Button()
        Me.btngreen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmbsel = New System.Windows.Forms.ComboBox()
        Me.btnyellow = New System.Windows.Forms.Button()
        Me.btnindigo = New System.Windows.Forms.Button()
        Me.btnorange = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label1.Location = New System.Drawing.Point(299, 166)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(98, 30)
        Me.label1.TabIndex = 0
        Me.label1.Text = "User id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(465, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(446, 166)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(217, 27)
        Me.txtuserid.TabIndex = 2
        '
        'btnred
        '
        Me.btnred.BackColor = System.Drawing.Color.Red
        Me.btnred.Location = New System.Drawing.Point(274, 372)
        Me.btnred.Name = "btnred"
        Me.btnred.Size = New System.Drawing.Size(112, 61)
        Me.btnred.TabIndex = 3
        Me.btnred.UseVisualStyleBackColor = False
        '
        'btnblue
        '
        Me.btnblue.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnblue.Location = New System.Drawing.Point(446, 372)
        Me.btnblue.Name = "btnblue"
        Me.btnblue.Size = New System.Drawing.Size(112, 61)
        Me.btnblue.TabIndex = 4
        Me.btnblue.UseVisualStyleBackColor = False
        '
        'btngreen
        '
        Me.btngreen.BackColor = System.Drawing.Color.LimeGreen
        Me.btngreen.Location = New System.Drawing.Point(603, 372)
        Me.btngreen.Name = "btngreen"
        Me.btngreen.Size = New System.Drawing.Size(112, 61)
        Me.btngreen.TabIndex = 5
        Me.btngreen.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Location = New System.Drawing.Point(465, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.GreenYellow
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.ForestGreen
        Me.LinkLabel1.Location = New System.Drawing.Point(796, 540)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(160, 28)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot password"
        '
        'cmbsel
        '
        Me.cmbsel.FormattingEnabled = True
        Me.cmbsel.Items.AddRange(New Object() {"Red", "Blue", "Green", "Pink", "Indigo", "Yellow", "Orange"})
        Me.cmbsel.Location = New System.Drawing.Point(446, 264)
        Me.cmbsel.Name = "cmbsel"
        Me.cmbsel.Size = New System.Drawing.Size(151, 28)
        Me.cmbsel.TabIndex = 18
        '
        'btnyellow
        '
        Me.btnyellow.BackColor = System.Drawing.Color.Yellow
        Me.btnyellow.Location = New System.Drawing.Point(603, 454)
        Me.btnyellow.Name = "btnyellow"
        Me.btnyellow.Size = New System.Drawing.Size(112, 61)
        Me.btnyellow.TabIndex = 20
        Me.btnyellow.UseVisualStyleBackColor = False
        '
        'btnindigo
        '
        Me.btnindigo.BackColor = System.Drawing.Color.Indigo
        Me.btnindigo.Location = New System.Drawing.Point(446, 454)
        Me.btnindigo.Name = "btnindigo"
        Me.btnindigo.Size = New System.Drawing.Size(112, 61)
        Me.btnindigo.TabIndex = 21
        Me.btnindigo.UseVisualStyleBackColor = False
        '
        'btnorange
        '
        Me.btnorange.BackColor = System.Drawing.Color.OrangeRed
        Me.btnorange.Location = New System.Drawing.Point(274, 454)
        Me.btnorange.Name = "btnorange"
        Me.btnorange.Size = New System.Drawing.Size(112, 61)
        Me.btnorange.TabIndex = 22
        Me.btnorange.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button7.Location = New System.Drawing.Point(862, 264)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 36)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "Add Colour"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 704)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnorange)
        Me.Controls.Add(Me.btnindigo)
        Me.Controls.Add(Me.btnyellow)
        Me.Controls.Add(Me.cmbsel)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btngreen)
        Me.Controls.Add(Me.btnblue)
        Me.Controls.Add(Me.btnred)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmLogin"
        Me.Text = "Login page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents btnred As Button
    Friend WithEvents btnblue As Button
    Friend WithEvents btngreen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cmbsel As ComboBox
    Friend WithEvents btnyellow As Button
    Friend WithEvents btnindigo As Button
    Friend WithEvents btnorange As Button
    Friend WithEvents Button7 As Button
End Class
