<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLibroId = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbAutor = New System.Windows.Forms.ComboBox()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "autor"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "genero"
        '
        'lblLibroId
        '
        Me.lblLibroId.AutoSize = true
        Me.lblLibroId.Location = New System.Drawing.Point(109, 28)
        Me.lblLibroId.Name = "lblLibroId"
        Me.lblLibroId.Size = New System.Drawing.Size(51, 17)
        Me.lblLibroId.TabIndex = 4
        Me.lblLibroId.Text = "Label5"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(112, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 5
        '
        'cbAutor
        '
        Me.cbAutor.FormattingEnabled = true
        Me.cbAutor.Location = New System.Drawing.Point(112, 83)
        Me.cbAutor.Name = "cbAutor"
        Me.cbAutor.Size = New System.Drawing.Size(214, 24)
        Me.cbAutor.TabIndex = 6
        '
        'cbGenero
        '
        Me.cbGenero.FormattingEnabled = true
        Me.cbGenero.Location = New System.Drawing.Point(112, 117)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(214, 24)
        Me.cbGenero.TabIndex = 8
        '
        'frmLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 303)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.cbAutor)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblLibroId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLibros"
        Me.Text = "frmLibros"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblLibroId As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cbAutor As ComboBox
    Friend WithEvents cbGenero As ComboBox
End Class
