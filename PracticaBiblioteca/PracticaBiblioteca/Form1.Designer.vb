<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblAutorID = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gridLibros = New System.Windows.Forms.DataGridView()
        Me.LibroIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPublicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.gridLibros,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LibroBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(337, 22)
        Me.txtNombre.TabIndex = 3
        '
        'lblAutorID
        '
        Me.lblAutorID.AutoSize = true
        Me.lblAutorID.Location = New System.Drawing.Point(106, 26)
        Me.lblAutorID.Name = "lblAutorID"
        Me.lblAutorID.Size = New System.Drawing.Size(16, 17)
        Me.lblAutorID.TabIndex = 4
        Me.lblAutorID.Text = "0"
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(124, 137)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 32)
        Me.btnInsertar.TabIndex = 5
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = true
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(205, 137)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 32)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "M&odificar"
        Me.btnModificar.UseVisualStyleBackColor = true
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(286, 137)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 32)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = true
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(368, 137)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 32)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = true
        '
        'gridLibros
        '
        Me.gridLibros.AutoGenerateColumns = false
        Me.gridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LibroIdDataGridViewTextBoxColumn, Me.TituloDataGridViewTextBoxColumn, Me.FechaPublicacionDataGridViewTextBoxColumn, Me.AutorIdDataGridViewTextBoxColumn, Me.GeneroIdDataGridViewTextBoxColumn, Me.AutorDataGridViewTextBoxColumn, Me.GeneroDataGridViewTextBoxColumn})
        Me.gridLibros.DataSource = Me.LibroBindingSource
        Me.gridLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridLibros.Location = New System.Drawing.Point(0, 0)
        Me.gridLibros.Name = "gridLibros"
        Me.gridLibros.RowTemplate.Height = 24
        Me.gridLibros.Size = New System.Drawing.Size(695, 241)
        Me.gridLibros.TabIndex = 9
        '
        'LibroIdDataGridViewTextBoxColumn
        '
        Me.LibroIdDataGridViewTextBoxColumn.DataPropertyName = "libroId"
        Me.LibroIdDataGridViewTextBoxColumn.HeaderText = "libroId"
        Me.LibroIdDataGridViewTextBoxColumn.Name = "LibroIdDataGridViewTextBoxColumn"
        '
        'TituloDataGridViewTextBoxColumn
        '
        Me.TituloDataGridViewTextBoxColumn.DataPropertyName = "titulo"
        Me.TituloDataGridViewTextBoxColumn.HeaderText = "titulo"
        Me.TituloDataGridViewTextBoxColumn.Name = "TituloDataGridViewTextBoxColumn"
        '
        'FechaPublicacionDataGridViewTextBoxColumn
        '
        Me.FechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "fechaPublicacion"
        Me.FechaPublicacionDataGridViewTextBoxColumn.HeaderText = "fechaPublicacion"
        Me.FechaPublicacionDataGridViewTextBoxColumn.Name = "FechaPublicacionDataGridViewTextBoxColumn"
        '
        'AutorIdDataGridViewTextBoxColumn
        '
        Me.AutorIdDataGridViewTextBoxColumn.DataPropertyName = "autorId"
        Me.AutorIdDataGridViewTextBoxColumn.HeaderText = "autorId"
        Me.AutorIdDataGridViewTextBoxColumn.Name = "AutorIdDataGridViewTextBoxColumn"
        '
        'GeneroIdDataGridViewTextBoxColumn
        '
        Me.GeneroIdDataGridViewTextBoxColumn.DataPropertyName = "generoId"
        Me.GeneroIdDataGridViewTextBoxColumn.HeaderText = "generoId"
        Me.GeneroIdDataGridViewTextBoxColumn.Name = "GeneroIdDataGridViewTextBoxColumn"
        '
        'AutorDataGridViewTextBoxColumn
        '
        Me.AutorDataGridViewTextBoxColumn.DataPropertyName = "autor"
        Me.AutorDataGridViewTextBoxColumn.HeaderText = "autor"
        Me.AutorDataGridViewTextBoxColumn.Name = "AutorDataGridViewTextBoxColumn"
        '
        'GeneroDataGridViewTextBoxColumn
        '
        Me.GeneroDataGridViewTextBoxColumn.DataPropertyName = "genero"
        Me.GeneroDataGridViewTextBoxColumn.HeaderText = "genero"
        Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
        '
        'LibroBindingSource
        '
        Me.LibroBindingSource.DataSource = GetType(PracticaBiblioteca.Libro)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gridLibros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 274)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 241)
        Me.Panel1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.lblAutorID)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gridLibros,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LibroBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents LibroIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TituloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPublicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneroIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibroBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend  WithEvents gridLibros As DataGridView
    Friend  WithEvents txtNombre As TextBox
    Friend  WithEvents lblAutorID As Label
End Class
