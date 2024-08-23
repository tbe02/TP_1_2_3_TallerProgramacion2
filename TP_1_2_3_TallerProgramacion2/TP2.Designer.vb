<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TP2
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
        LDNI = New Label()
        LApellido = New Label()
        LNombre = New Label()
        LNyA = New Label()
        LModificar = New Label()
        TBDNI = New TextBox()
        TBApellido = New TextBox()
        TBNombre = New TextBox()
        BGuardar = New Button()
        BEliminar = New Button()
        SuspendLayout()
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Location = New Point(146, 126)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(35, 20)
        LDNI.TabIndex = 0
        LDNI.Text = "DNI"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(146, 163)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(66, 20)
        LApellido.TabIndex = 1
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(148, 196)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(64, 20)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre"
        ' 
        ' LNyA
        ' 
        LNyA.AutoSize = True
        LNyA.Location = New Point(146, 58)
        LNyA.Name = "LNyA"
        LNyA.Size = New Size(139, 20)
        LNyA.TabIndex = 3
        LNyA.Text = "Nombre y Apellido:"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(285, 58)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(73, 20)
        LModificar.TabIndex = 4
        LModificar.Text = "modificar"
        ' 
        ' TBDNI
        ' 
        TBDNI.Location = New Point(233, 119)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(125, 27)
        TBDNI.TabIndex = 5
        ' 
        ' TBApellido
        ' 
        TBApellido.Location = New Point(233, 156)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(125, 27)
        TBApellido.TabIndex = 6
        ' 
        ' TBNombre
        ' 
        TBNombre.Location = New Point(233, 193)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(125, 27)
        TBNombre.TabIndex = 7
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(264, 268)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(94, 29)
        BGuardar.TabIndex = 8
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(146, 268)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(94, 29)
        BEliminar.TabIndex = 9
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' TP2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(TBNombre)
        Controls.Add(TBApellido)
        Controls.Add(TBDNI)
        Controls.Add(LModificar)
        Controls.Add(LNyA)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        Controls.Add(LDNI)
        Name = "TP2"
        Text = "Pequeño formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDNI As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LNyA As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
End Class
