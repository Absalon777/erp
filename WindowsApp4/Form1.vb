Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización si es necesaria
    End Sub

    ' Evento para Button1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Cambia el color del fondo de Button2 a azul cuando se presiona Button1
        Button2.BackColor = Color.Blue
    End Sub

    ' Evento para Button2 (puedes agregar código adicional si es necesario)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Puedes agregar código aquí para Button2 si deseas hacer algo cuando se haga clic
    End Sub
End Class

