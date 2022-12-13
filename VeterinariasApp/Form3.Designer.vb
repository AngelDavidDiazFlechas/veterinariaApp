<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NVProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
>>>>>>> 748988119652c47256ea8661c3db71cc4af9c6e5
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
<<<<<<< HEAD
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBNomCliente = New System.Windows.Forms.TextBox()
=======
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NVProducto))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBValor = New System.Windows.Forms.TextBox()
        Me.TBDescripcion = New System.Windows.Forms.TextBox()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.TBProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTAgregarP = New System.Windows.Forms.Button()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTLimpiar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> 748988119652c47256ea8661c3db71cc4af9c6e5
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
<<<<<<< HEAD
        Me.Label3.Location = New System.Drawing.Point(102, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Telefono:"
=======
        Me.Label3.Location = New System.Drawing.Point(154, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Descripcion"
>>>>>>> 748988119652c47256ea8661c3db71cc4af9c6e5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
<<<<<<< HEAD
        Me.Label2.Location = New System.Drawing.Point(98, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Direccion:"
=======
        Me.Label2.Location = New System.Drawing.Point(151, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Stock"
>>>>>>> 748988119652c47256ea8661c3db71cc4af9c6e5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
<<<<<<< HEAD
        Me.Label1.Location = New System.Drawing.Point(102, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Nombres:"
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(206, 168)
        Me.TBDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(262, 27)
        Me.TBDireccion.TabIndex = 65
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(205, 230)
        Me.TBTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(262, 27)
        Me.TBTelefono.TabIndex = 64
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(403, 307)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 307)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 20)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Registro de Cliente"
        '
        'TBNomCliente
        '
        Me.TBNomCliente.Location = New System.Drawing.Point(205, 102)
        Me.TBNomCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBNomCliente.Name = "TBNomCliente"
        Me.TBNomCliente.Size = New System.Drawing.Size(262, 27)
        Me.TBNomCliente.TabIndex = 73
        '
        'FormNuevoC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 386)
        Me.Controls.Add(Me.TBNomCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBDireccion)
        Me.Controls.Add(Me.TBTelefono)
        Me.Name = "FormNuevoC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Cliente"
=======
        Me.Label1.Location = New System.Drawing.Point(151, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre Producto"
        '
        'TBValor
        '
        Me.TBValor.Location = New System.Drawing.Point(324, 239)
        Me.TBValor.Name = "TBValor"
        Me.TBValor.Size = New System.Drawing.Size(100, 23)
        Me.TBValor.TabIndex = 15
        '
        'TBDescripcion
        '
        Me.TBDescripcion.Location = New System.Drawing.Point(324, 199)
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Size = New System.Drawing.Size(100, 23)
        Me.TBDescripcion.TabIndex = 14
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(324, 157)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(100, 23)
        Me.TBStock.TabIndex = 13
        '
        'TBProducto
        '
        Me.TBProducto.Location = New System.Drawing.Point(324, 119)
        Me.TBProducto.Name = "TBProducto"
        Me.TBProducto.Size = New System.Drawing.Size(100, 23)
        Me.TBProducto.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(481, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BTAgregarP
        '
        Me.BTAgregarP.Location = New System.Drawing.Point(150, 357)
        Me.BTAgregarP.Name = "BTAgregarP"
        Me.BTAgregarP.Size = New System.Drawing.Size(75, 23)
        Me.BTAgregarP.TabIndex = 22
        Me.BTAgregarP.Text = "Agregar"
        Me.BTAgregarP.UseVisualStyleBackColor = True
        '
        'BTCancelar
        '
        Me.BTCancelar.Location = New System.Drawing.Point(266, 357)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTCancelar.TabIndex = 23
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = True
        '
        'BTLimpiar
        '
        Me.BTLimpiar.Location = New System.Drawing.Point(379, 357)
        Me.BTLimpiar.Name = "BTLimpiar"
        Me.BTLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTLimpiar.TabIndex = 24
        Me.BTLimpiar.Text = "Limpiar"
        Me.BTLimpiar.UseVisualStyleBackColor = True
        '
        'NVProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 401)
        Me.Controls.Add(Me.BTLimpiar)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTAgregarP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBValor)
        Me.Controls.Add(Me.TBDescripcion)
        Me.Controls.Add(Me.TBStock)
        Me.Controls.Add(Me.TBProducto)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "NVProducto"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> 748988119652c47256ea8661c3db71cc4af9c6e5
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
<<<<<<< HEAD
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TBNomCliente As TextBox
=======
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBValor As TextBox
    Friend WithEvents TBDescripcion As TextBox
    Friend WithEvents TBStock As TextBox
    Friend WithEvents TBProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTAgregarP As Button
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTLimpiar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CBMascota As ComboBox
>>>>>>> 748988119652c47256ea8661c3db71cc4af9c6e5
End Class
