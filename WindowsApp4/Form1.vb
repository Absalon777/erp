﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización si es necesaria
    End Sub

    ' Evento para Button1
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        ' Cambia el color del fondo de Button2 a azul cuando se presiona Button1
        Button2.BackColor = Color.Blue
    End Sub

    ' Evento para Button2 (puedes agregar código adicional si es necesario)
    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        ' Puedes agregar código aquí para Button2 si deseas hacer algo cuando se haga clic
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Text = "hola"
    End Sub
End Class

