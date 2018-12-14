Public Class frmBuscar




    Dim db As new biblioDataContext

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAutores.CellContentClick

        Dim _autorId As Integer = gridAutores.Rows(e.RowIndex).Cells("autorId").Value

        form1.buscarAutor(_autorId)

        Me.Close()

    End Sub

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim autores As List(Of autor) = db.autors.ToList()

        gridAutores.DataSource =autores

        
    End Sub
End Class