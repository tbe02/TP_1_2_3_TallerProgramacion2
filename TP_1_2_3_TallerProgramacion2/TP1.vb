Public Class TP1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGuardar.Click

        Dim nombre, apellido As String

        nombre = TBNombre.Text
        apellido = TBApellido.Text

        TBResultado.Text = nombre & " " & apellido

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TBNombre.Clear()
        TBApellido.Clear()
        TBResultado.Clear()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BSalir.Click
        End

    End Sub

    Private Sub TBResultado_TextChanged(sender As Object, e As EventArgs) Handles TBResultado.TextChanged

    End Sub
End Class
