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
        Me.ingresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelS = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBclave = New System.Windows.Forms.TextBox()
        Me.TBNusuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelS.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ingresar
        '
        Me.ingresar.BackColor = System.Drawing.SystemColors.Highlight
        Me.ingresar.Location = New System.Drawing.Point(409, 456)
        Me.ingresar.Margin = New System.Windows.Forms.Padding(0)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(94, 29)
        Me.ingresar.TabIndex = 1
        Me.ingresar.Text = "Ingresar"
        Me.ingresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VeterinariasApp.My.Resources.Resources.portada
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(953, 531)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'panelS
        '
        Me.panelS.Controls.Add(Me.Button2)
        Me.panelS.Controls.Add(Me.Button1)
        Me.panelS.Controls.Add(Me.TBclave)
        Me.panelS.Controls.Add(Me.TBNusuario)
        Me.panelS.Controls.Add(Me.Label3)
        Me.panelS.Controls.Add(Me.Label2)
        Me.panelS.Controls.Add(Me.Label1)
        Me.panelS.Controls.Add(Me.PictureBox2)
        Me.panelS.Location = New System.Drawing.Point(800, 336)
        Me.panelS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelS.Name = "panelS"
        Me.panelS.Size = New System.Drawing.Size(623, 462)
        Me.panelS.TabIndex = 3
        Me.panelS.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(356, 407)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(209, 407)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TBclave
        '
        Me.TBclave.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TBclave.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.TBclave.Location = New System.Drawing.Point(245, 349)
        Me.TBclave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBclave.Name = "TBclave"
        Me.TBclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBclave.Size = New System.Drawing.Size(279, 27)
        Me.TBclave.TabIndex = 4
        '
        'TBNusuario
        '
        Me.TBNusuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TBNusuario.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.TBNusuario.Location = New System.Drawing.Point(245, 280)
        Me.TBNusuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBNusuario.Name = "TBNusuario"
        Me.TBNusuario.Size = New System.Drawing.Size(279, 27)
        Me.TBNusuario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(88, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " Contraseña: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(88, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INICIAR SESION"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VeterinariasApp.My.Resources.Resources.portada
        Me.PictureBox2.Location = New System.Drawing.Point(16, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(604, 303)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(951, 533)
        Me.Controls.Add(Me.panelS)
        Me.Controls.Add(Me.ingresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelS.ResumeLayout(False)
        Me.panelS.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ingresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelS As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TBclave As TextBox
    Friend WithEvents TBNusuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
