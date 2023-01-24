<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsignup))
        Me.btnred = New System.Windows.Forms.Button()
        Me.btnblue = New System.Windows.Forms.Button()
        Me.btngreen = New System.Windows.Forms.Button()
        Me.lblfirst = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblsecond = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.txtfisrt = New System.Windows.Forms.TextBox()
        Me.txtsecond = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.cmbsel = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnorange = New System.Windows.Forms.Button()
        Me.btnindigo = New System.Windows.Forms.Button()
        Me.btnyellow = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnred
        '
        Me.btnred.BackColor = System.Drawing.Color.Red
        Me.btnred.Location = New System.Drawing.Point(339, 365)
        Me.btnred.Name = "btnred"
        Me.btnred.Size = New System.Drawing.Size(94, 48)
        Me.btnred.TabIndex = 4
        Me.btnred.UseVisualStyleBackColor = False
        '
        'btnblue
        '
        Me.btnblue.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnblue.Location = New System.Drawing.Point(477, 365)
        Me.btnblue.Name = "btnblue"
        Me.btnblue.Size = New System.Drawing.Size(94, 48)
        Me.btnblue.TabIndex = 5
        Me.btnblue.UseVisualStyleBackColor = False
        '
        'btngreen
        '
        Me.btngreen.BackColor = System.Drawing.Color.LimeGreen
        Me.btngreen.Location = New System.Drawing.Point(604, 365)
        Me.btngreen.Name = "btngreen"
        Me.btngreen.Size = New System.Drawing.Size(94, 48)
        Me.btngreen.TabIndex = 6
        Me.btngreen.UseVisualStyleBackColor = False
        '
        'lblfirst
        '
        Me.lblfirst.AutoSize = True
        Me.lblfirst.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblfirst.Location = New System.Drawing.Point(321, 51)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(125, 30)
        Me.lblfirst.TabIndex = 7
        Me.lblfirst.Text = "FirstName:"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblpass.Location = New System.Drawing.Point(466, 308)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(151, 30)
        Me.lblpass.TabIndex = 8
        Me.lblpass.Text = "Set Password"
        '
        'lblsecond
        '
        Me.lblsecond.AutoSize = True
        Me.lblsecond.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblsecond.Location = New System.Drawing.Point(291, 119)
        Me.lblsecond.Name = "lblsecond"
        Me.lblsecond.Size = New System.Drawing.Size(155, 30)
        Me.lblsecond.TabIndex = 9
        Me.lblsecond.Text = "SecondName:"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblemail.Location = New System.Drawing.Point(339, 182)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(107, 30)
        Me.lblemail.TabIndex = 10
        Me.lblemail.Text = "Email id :"
        '
        'txtfisrt
        '
        Me.txtfisrt.Location = New System.Drawing.Point(466, 51)
        Me.txtfisrt.Name = "txtfisrt"
        Me.txtfisrt.Size = New System.Drawing.Size(232, 27)
        Me.txtfisrt.TabIndex = 11
        '
        'txtsecond
        '
        Me.txtsecond.Location = New System.Drawing.Point(466, 119)
        Me.txtsecond.Name = "txtsecond"
        Me.txtsecond.Size = New System.Drawing.Size(232, 27)
        Me.txtsecond.TabIndex = 12
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(466, 185)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(232, 27)
        Me.txtemail.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(484, 609)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnsubmit.TabIndex = 16
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'cmbsel
        '
        Me.cmbsel.FormattingEnabled = True
        Me.cmbsel.Items.AddRange(New Object() {"Red", "Blue", "Green", "Pink", "Indigo", "Yellow", "Orange"})
        Me.cmbsel.Location = New System.Drawing.Point(466, 266)
        Me.cmbsel.Name = "cmbsel"
        Me.cmbsel.Size = New System.Drawing.Size(151, 28)
        Me.cmbsel.TabIndex = 19
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button7.Location = New System.Drawing.Point(728, 266)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 36)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Add Colour"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnorange
        '
        Me.btnorange.BackColor = System.Drawing.Color.OrangeRed
        Me.btnorange.Location = New System.Drawing.Point(352, 469)
        Me.btnorange.Name = "btnorange"
        Me.btnorange.Size = New System.Drawing.Size(94, 51)
        Me.btnorange.TabIndex = 25
        Me.btnorange.UseVisualStyleBackColor = False
        '
        'btnindigo
        '
        Me.btnindigo.BackColor = System.Drawing.Color.Indigo
        Me.btnindigo.Location = New System.Drawing.Point(477, 469)
        Me.btnindigo.Name = "btnindigo"
        Me.btnindigo.Size = New System.Drawing.Size(97, 51)
        Me.btnindigo.TabIndex = 26
        Me.btnindigo.UseVisualStyleBackColor = False
        '
        'btnyellow
        '
        Me.btnyellow.BackColor = System.Drawing.Color.Yellow
        Me.btnyellow.Location = New System.Drawing.Point(604, 469)
        Me.btnyellow.Name = "btnyellow"
        Me.btnyellow.Size = New System.Drawing.Size(94, 51)
        Me.btnyellow.TabIndex = 27
        Me.btnyellow.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(495, 231)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(94, 29)
        Me.btnnext.TabIndex = 14
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'frmsignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1044, 702)
        Me.Controls.Add(Me.btnyellow)
        Me.Controls.Add(Me.btnindigo)
        Me.Controls.Add(Me.btnorange)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cmbsel)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtsecond)
        Me.Controls.Add(Me.txtfisrt)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblsecond)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblfirst)
        Me.Controls.Add(Me.btngreen)
        Me.Controls.Add(Me.btnblue)
        Me.Controls.Add(Me.btnred)
        Me.Name = "frmsignup"
        Me.Text = "SignUp page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnred As Button
    Friend WithEvents btnblue As Button
    Friend WithEvents btngreen As Button
    Friend WithEvents lblfirst As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lblsecond As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents txtfisrt As TextBox
    Friend WithEvents txtsecond As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnsubmit As Button
    Friend WithEvents cmbsel As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents btnorange As Button
    Friend WithEvents btnindigo As Button
    Friend WithEvents btnyellow As Button
    Friend WithEvents btnnext As Button
End Class
