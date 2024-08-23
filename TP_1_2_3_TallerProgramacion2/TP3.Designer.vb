<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TP3
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
        BEliminar = New Button()
        BGuardar = New Button()
        TBNombre = New TextBox()
        TBApellido = New TextBox()
        TBDNI = New TextBox()
        LModificar = New Label()
        LNyA = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LDNI = New Label()
        Panel1 = New Panel()
        CBMasterCard = New CheckBox()
        CBVisa = New CheckBox()
        CBNaranja = New CheckBox()
        LTarjeta = New Label()
        TBTelefono = New TextBox()
        LTelefono = New Label()
        PictureBox1 = New PictureBox()
        RBHombre = New RadioButton()
        RBMujer = New RadioButton()
        LNuevoCliente = New Label()
        BSalir = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BEliminar
        ' 
        BEliminar.Image = My.Resources.Resources.eliminar
        BEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BEliminar.Location = New Point(302, 536)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(153, 71)
        BEliminar.TabIndex = 19
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' BGuardar
        ' 
        BGuardar.Image = My.Resources.Resources.guardar
        BGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BGuardar.Location = New Point(48, 536)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(153, 71)
        BGuardar.TabIndex = 18
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' TBNombre
        ' 
        TBNombre.Location = New Point(121, 152)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(125, 27)
        TBNombre.TabIndex = 17
        ' 
        ' TBApellido
        ' 
        TBApellido.Location = New Point(121, 115)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(125, 27)
        TBApellido.TabIndex = 16
        ' 
        ' TBDNI
        ' 
        TBDNI.Location = New Point(121, 78)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(125, 27)
        TBDNI.TabIndex = 15
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(173, 17)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(73, 20)
        LModificar.TabIndex = 14
        LModificar.Text = "modificar"
        ' 
        ' LNyA
        ' 
        LNyA.AutoSize = True
        LNyA.Location = New Point(34, 17)
        LNyA.Name = "LNyA"
        LNyA.Size = New Size(139, 20)
        LNyA.TabIndex = 13
        LNyA.Text = "Nombre y Apellido:"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(34, 159)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(74, 20)
        LNombre.TabIndex = 12
        LNombre.Text = "* Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(34, 122)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(76, 20)
        LApellido.TabIndex = 11
        LApellido.Text = "* Apellido"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Location = New Point(34, 85)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(45, 20)
        LDNI.TabIndex = 10
        LDNI.Text = "* DNI"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonShadow
        Panel1.Controls.Add(CBMasterCard)
        Panel1.Controls.Add(CBVisa)
        Panel1.Controls.Add(CBNaranja)
        Panel1.Controls.Add(LTarjeta)
        Panel1.Controls.Add(TBTelefono)
        Panel1.Controls.Add(LTelefono)
        Panel1.Controls.Add(TBDNI)
        Panel1.Controls.Add(LDNI)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(TBNombre)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(TBApellido)
        Panel1.Controls.Add(LNyA)
        Panel1.Controls.Add(LModificar)
        Panel1.Location = New Point(93, 69)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(308, 437)
        Panel1.TabIndex = 20
        ' 
        ' CBMasterCard
        ' 
        CBMasterCard.AutoSize = True
        CBMasterCard.Location = New Point(173, 330)
        CBMasterCard.Name = "CBMasterCard"
        CBMasterCard.Size = New Size(107, 24)
        CBMasterCard.TabIndex = 25
        CBMasterCard.Text = "MasterCard"
        CBMasterCard.UseVisualStyleBackColor = True
        ' 
        ' CBVisa
        ' 
        CBVisa.AutoSize = True
        CBVisa.Location = New Point(173, 300)
        CBVisa.Name = "CBVisa"
        CBVisa.Size = New Size(58, 24)
        CBVisa.TabIndex = 24
        CBVisa.Text = "Visa"
        CBVisa.UseVisualStyleBackColor = True
        ' 
        ' CBNaranja
        ' 
        CBNaranja.AutoSize = True
        CBNaranja.Location = New Point(173, 270)
        CBNaranja.Name = "CBNaranja"
        CBNaranja.Size = New Size(83, 24)
        CBNaranja.TabIndex = 23
        CBNaranja.Text = "Naranja"
        CBNaranja.UseVisualStyleBackColor = True
        ' 
        ' LTarjeta
        ' 
        LTarjeta.AutoSize = True
        LTarjeta.Location = New Point(43, 247)
        LTarjeta.Name = "LTarjeta"
        LTarjeta.Size = New Size(128, 20)
        LTarjeta.TabIndex = 22
        LTarjeta.Text = "Tarjeta de crédito:"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.Location = New Point(121, 192)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(125, 27)
        TBTelefono.TabIndex = 21
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Location = New Point(41, 199)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(67, 20)
        LTelefono.TabIndex = 20
        LTelefono.Text = "Teléfono"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(513, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 219)
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' RBHombre
        ' 
        RBHombre.AutoSize = True
        RBHombre.Checked = True
        RBHombre.Location = New Point(513, 316)
        RBHombre.Name = "RBHombre"
        RBHombre.Size = New Size(68, 24)
        RBHombre.TabIndex = 22
        RBHombre.TabStop = True
        RBHombre.Text = "Varón"
        RBHombre.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(643, 316)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(68, 24)
        RBMujer.TabIndex = 23
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' LNuevoCliente
        ' 
        LNuevoCliente.AutoSize = True
        LNuevoCliente.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LNuevoCliente.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        LNuevoCliente.Location = New Point(291, 9)
        LNuevoCliente.Name = "LNuevoCliente"
        LNuevoCliente.Size = New Size(218, 41)
        LNuevoCliente.TabIndex = 24
        LNuevoCliente.Text = "Nuevo Cliente"
        ' 
        ' BSalir
        ' 
        BSalir.Image = My.Resources.Resources.Salir
        BSalir.ImageAlign = ContentAlignment.MiddleLeft
        BSalir.Location = New Point(576, 536)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(153, 71)
        BSalir.TabIndex = 25
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' TP3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(779, 664)
        Controls.Add(BSalir)
        Controls.Add(LNuevoCliente)
        Controls.Add(RBMujer)
        Controls.Add(RBHombre)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(BGuardar)
        Controls.Add(BEliminar)
        Name = "TP3"
        Text = "TP3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents LModificar As Label
    Friend WithEvents LNyA As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LTelefono As Label
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents LTarjeta As Label
    Friend WithEvents CBNaranja As CheckBox
    Friend WithEvents CBMasterCard As CheckBox
    Friend WithEvents CBVisa As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents LNuevoCliente As Label
    Friend WithEvents BSalir As Button
End Class
