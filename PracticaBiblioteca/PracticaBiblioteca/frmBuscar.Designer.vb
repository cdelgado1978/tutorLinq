<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar
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
        Me.gridAutores = New System.Windows.Forms.DataGridView()
        Me.AutorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.autorId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gridAutores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.AutorBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LibrosBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LibrosBindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'gridAutores
        '
        Me.gridAutores.AutoGenerateColumns = false
        Me.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAutores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.autorId, Me.NombreDataGridViewTextBoxColumn})
        Me.gridAutores.DataSource = Me.AutorBindingSource
        Me.gridAutores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAutores.Location = New System.Drawing.Point(0, 0)
        Me.gridAutores.Name = "gridAutores"
        Me.gridAutores.RowTemplate.Height = 24
        Me.gridAutores.Size = New System.Drawing.Size(545, 272)
        Me.gridAutores.TabIndex = 0
        '
        'AutorBindingSource
        '
        Me.AutorBindingSource.DataSource = GetType(PracticaBiblioteca.autor)
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "Libros"
        Me.LibrosBindingSource.DataSource = Me.AutorBindingSource
        '
        'LibrosBindingSource1
        '
        Me.LibrosBindingSource1.DataMember = "Libros"
        Me.LibrosBindingSource1.DataSource = Me.AutorBindingSource
        '
        'autorId
        '
        Me.autorId.DataPropertyName = "autorId"
        Me.autorId.HeaderText = "autorId"
        Me.autorId.Name = "autorId"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'frmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 272)
        Me.Controls.Add(Me.gridAutores)
        Me.Name = "frmBuscar"
        Me.Text = "frmBuscar"
        CType(Me.gridAutores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.AutorBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LibrosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LibrosBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents gridAutores As DataGridView
    Friend WithEvents AutorBindingSource As BindingSource
    Friend WithEvents LibrosBindingSource As BindingSource
    Friend WithEvents LibrosBindingSource1 As BindingSource
    Friend WithEvents autorId As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
