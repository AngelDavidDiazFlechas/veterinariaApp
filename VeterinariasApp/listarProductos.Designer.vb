<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarProductos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBTraerp = New System.Windows.Forms.Button()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.BTExcel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(272, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'TBTraerp
        '
        Me.TBTraerp.Location = New System.Drawing.Point(148, 341)
        Me.TBTraerp.Name = "TBTraerp"
        Me.TBTraerp.Size = New System.Drawing.Size(109, 25)
        Me.TBTraerp.TabIndex = 6
        Me.TBTraerp.Text = "Listar productos"
        Me.TBTraerp.UseVisualStyleBackColor = True
        '
        'DGVProductos
        '
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.Location = New System.Drawing.Point(114, 138)
        Me.DGVProductos.Name = "DGVProductos"
        Me.DGVProductos.RowTemplate.Height = 25
        Me.DGVProductos.Size = New System.Drawing.Size(509, 166)
        Me.DGVProductos.TabIndex = 7
        '
        'BTExcel
        '
        Me.BTExcel.Location = New System.Drawing.Point(455, 341)
        Me.BTExcel.Name = "BTExcel"
        Me.BTExcel.Size = New System.Drawing.Size(130, 23)
        Me.BTExcel.TabIndex = 8
        Me.BTExcel.Text = "Exportar a excel"
        Me.BTExcel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(559, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'listarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTExcel)
        Me.Controls.Add(Me.DGVProductos)
        Me.Controls.Add(Me.TBTraerp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listarProductos"
        Me.Text = "listarProductos"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBTraerp As Button
    Friend WithEvents DGVProductos As DataGridView
    Friend WithEvents BTExcel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
