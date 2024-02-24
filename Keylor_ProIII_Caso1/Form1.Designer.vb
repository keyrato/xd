<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListaObjetos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SinIVA = New System.Windows.Forms.RadioButton()
        Me.ConIVA = New System.Windows.Forms.RadioButton()
        Me.Precio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListaObjetos
        '
        Me.ListaObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListaObjetos.FormattingEnabled = True
        Me.ListaObjetos.Location = New System.Drawing.Point(20, 58)
        Me.ListaObjetos.Name = "ListaObjetos"
        Me.ListaObjetos.Size = New System.Drawing.Size(225, 24)
        Me.ListaObjetos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SinIVA)
        Me.GroupBox1.Controls.Add(Me.ConIVA)
        Me.GroupBox1.Location = New System.Drawing.Point(277, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'SinIVA
        '
        Me.SinIVA.AutoSize = True
        Me.SinIVA.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SinIVA.Location = New System.Drawing.Point(6, 60)
        Me.SinIVA.Name = "SinIVA"
        Me.SinIVA.Size = New System.Drawing.Size(74, 22)
        Me.SinIVA.TabIndex = 2
        Me.SinIVA.TabStop = True
        Me.SinIVA.Text = "Sin IVA"
        Me.SinIVA.UseVisualStyleBackColor = True
        '
        'ConIVA
        '
        Me.ConIVA.AutoSize = True
        Me.ConIVA.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConIVA.Location = New System.Drawing.Point(6, 34)
        Me.ConIVA.Name = "ConIVA"
        Me.ConIVA.Size = New System.Drawing.Size(79, 22)
        Me.ConIVA.TabIndex = 2
        Me.ConIVA.TabStop = True
        Me.ConIVA.Text = "Con IVA"
        Me.ConIVA.UseVisualStyleBackColor = True
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.Location = New System.Drawing.Point(274, 169)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(0, 17)
        Me.Precio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Productos disponibles:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 270)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListaObjetos)
        Me.Name = "Form1"
        Me.Text = "CalculoIVA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaObjetos As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SinIVA As RadioButton
    Friend WithEvents ConIVA As RadioButton
    Friend WithEvents Precio As Label
    Friend WithEvents Label1 As Label
End Class
