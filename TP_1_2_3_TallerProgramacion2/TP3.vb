Public Class TP3

    Private Sub TBDNI_TextChanged(sender As Object, e As EventArgs) Handles TBDNI.TextChanged

    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim textoDNI As String
        Dim dni As Integer
        Dim apellido, nombre As String

        textoDNI = TBDNI.Text
        apellido = TBApellido.Text
        nombre = TBNombre.Text

        If (textoDNI = "" Or apellido = "" Or nombre = "") Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf Not Integer.TryParse(textoDNI, dni) Then
            MessageBox.Show("DNI solo acepta números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf Not sonTodosLetras(nombre) Then
            MessageBox.Show("Nombre solo acepta letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf Not sonTodosLetras(apellido) Then
            MessageBox.Show("Apellido solo acepta letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ask As MsgBoxResult

            ask = MessageBox.Show("Seguro que desea agregar un nuevo cliente?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (ask = MsgBoxResult.Yes) Then
                MessageBox.Show("El cliente: " & apellido & " " & nombre & " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LModificar.Text = apellido & " " & nombre
            End If
        End If






    End Sub

    Private Function sonTodosLetras(text As String) As Boolean
        For Each a As Char In text
            If Not Char.IsLetter(a) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click

        Dim cliente As String

        cliente = LModificar.text

        Dim ask As MsgBoxResult

        ask = MessageBox.Show("Está a punto de eliminar el cliente: " & cliente, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

        If ask = MsgBoxResult.Yes Then
            MessageBox.Show("El cliente: " & cliente & " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TBDNI.Clear
            TBApellido.Clear
            TBNombre.Clear
            LModificar.Text = "modificar"
            TBTelefono.Clear()
            CBNaranja.Checked = False
            CBVisa.Checked = False
            CBMasterCard.Checked = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TBTelefono.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LTarjeta.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBHombre.CheckedChanged
        PictureBox1.BackgroundImage = My.Resources.hombre
    End Sub

    Private Sub TP3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        PictureBox1.BackgroundImage = My.Resources.mujer

    End Sub
End Class