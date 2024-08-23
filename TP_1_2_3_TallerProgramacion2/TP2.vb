Public Class TP2
    Private Sub TBDNI_TextChanged(sender As Object, e As EventArgs) Handles TBDNI.TextChanged

    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim textoDNI As String
        Dim dni As Integer
        Dim apellido, nombre As String
        Dim formError As Boolean

        textoDNI = TBDNI.Text
        apellido = TBApellido.Text
        nombre = TBNombre.Text
        formError = False

        If (textoDNI = "" Or apellido = "" Or nombre = "") Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            formError = True

        Else
            If Not Integer.TryParse(textoDNI, dni) Then
                MessageBox.Show("DNI solo acepta números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                formError = True
            End If

            If Not sonTodosLetras(nombre) Then
                MessageBox.Show("Nombre solo acepta letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                formError = True
            End If
            If Not sonTodosLetras(apellido) Then
                MessageBox.Show("Apellido solo acepta letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                formError = True
            End If

        End If

        If Not formError Then
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

        If (ask = MsgBoxResult.Yes) Then
            MessageBox.Show("El cliente: " & cliente & " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TBDNI.Clear()
            TBApellido.Clear()
            TBNombre.Clear()
            LModificar.Text = "modificar"
        End If
    End Sub

    Private Sub TP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class