<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NVProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
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
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
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
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
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
End Class
