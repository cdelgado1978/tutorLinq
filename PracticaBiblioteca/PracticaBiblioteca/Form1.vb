Public Class Form1

    Dim db As biblioDataContext = new biblioDataContext()

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim _frmBuscar As New frmBuscar

        _frmBuscar.Show

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        if MsgBox("Seguro que desea Eliminar?", vbYesNo) = vbYes Then
            deleteAutores(lblAutorID.Text)
        End If

    End Sub

    ' public Shared _autorId As Integer
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        AgregarAutor(txtNombre.Text)
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        modificarAutor(lblAutorID.Text, txtNombre.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#Region "Funciones"

    Public sub buscarAutor(_autorId as Integer)

        'Busco el primer registro de la tabla autors.
        dim _autor As autor = db.autors.FirstOrDefault(Function(a) a.autorId = _autorId)

        txtNombre.Text = _autor.nombre
        lblAutorId.Text = _autor.autorId

        gridLibros.DataSource = _autor.Libros

    End sub

    Private Sub AgregarAutor(_nombre As String)

        dim autor1 As autor = New autor With {
            .nombre = _nombre
        }

        db.autors.InsertOnSubmit(autor1)

        db.SubmitChanges()
    End Sub

    Private Sub deleteAutores(_autorId As Integer)

        dim _autor As autor = db.autors.FirstOrDefault(Function(a) a.autorId = _autorId)

        If Not (_autor Is Nothing) Then

            db.autors.DeleteOnSubmit(_autor)

            db.SubmitChanges
            
        End If
    End Sub

    Private Sub modificarAutor(_autorId As Integer, _nombre As String)

        dim _autor  As autor = db.autors.FirstOrDefault(Function(a) a.autorId = _autorId  )

        If Not (_autor Is Nothing) Then 

            _autor.nombre = _nombre
               db.SubmitChanges()               
        End If 
    End Sub
#End Region




End Class
