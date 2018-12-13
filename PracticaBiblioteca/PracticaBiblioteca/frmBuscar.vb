Public Class frmBuscar

    Dim db As new biblioDataContext 
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim _autorId As Integer = DataGridView1.Rows(e.RowIndex).Cells("autorId").Value

        Form1.buscarAutor(_autorId)

        Me.Close()

    End Sub

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = db.autors

    End Sub
End Class