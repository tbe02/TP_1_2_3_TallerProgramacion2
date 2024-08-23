<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TP1
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
        BGuardar = New Button()
        BEliminar = New Button()
        LNombre = New Label()
        LApellido = New Label()
        TBNombre = New TextBox()
        TBApellido = New TextBox()
        TBResultado = New TextBox()
        BSalir = New Button()
        SuspendLayout()
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(172, 191)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(94, 29)
        BGuardar.TabIndex = 0
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(71, 191)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(94, 29)
        BEliminar.TabIndex = 1
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(71, 61)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(64, 20)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(71, 138)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(66, 20)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' TBNombre
        ' 
        TBNombre.Location = New Point(141, 61)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(125, 27)
        TBNombre.TabIndex = 4
        ' 
        ' TBApellido
        ' 
        TBApellido.Location = New Point(141, 131)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(125, 27)
        TBApellido.TabIndex = 5
        ' 
        ' TBResultado
        ' 
        TBResultado.Location = New Point(312, 61)
        TBResultado.Multiline = True
        TBResultado.Name = "TBResultado"
        TBResultado.Size = New Size(125, 97)
        TBResultado.TabIndex = 6
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(343, 191)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(94, 29)
        BSalir.TabIndex = 7
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' TP1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 253)
        Controls.Add(BSalir)
        Controls.Add(TBResultado)
        Controls.Add(TBApellido)
        Controls.Add(TBNombre)
        Controls.Add(LApellido)
        Controls.Add(LNombre)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        KeyPreview = True
        Name = "TP1"
        Text = "Mi Primer Forms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBResultado As TextBox
    Friend WithEvents BSalir As Button

End Class
