<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClip = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mi primer carga en GitHub"
        '
        'btnClip
        '
        Me.btnClip.Location = New System.Drawing.Point(15, 35)
        Me.btnClip.Name = "btnClip"
        Me.btnClip.Size = New System.Drawing.Size(75, 23)
        Me.btnClip.TabIndex = 1
        Me.btnClip.Text = "Dame un Clip"
        Me.btnClip.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.cNombre, Me.cApellido, Me.dFNacimiento, Me.iEdad})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(554, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Id
        '
        Me.Id.HeaderText = "Identificador"
        Me.Id.Name = "Id"
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        '
        'cApellido
        '
        Me.cApellido.HeaderText = "Apellido"
        Me.cApellido.Name = "cApellido"
        '
        'dFNacimiento
        '
        Me.dFNacimiento.HeaderText = "FNacimiento"
        Me.dFNacimiento.Name = "dFNacimiento"
        '
        'iEdad
        '
        Me.iEdad.HeaderText = "Edad"
        Me.iEdad.Name = "iEdad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClip)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClip As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents dFNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents iEdad As DataGridViewTextBoxColumn
End Class
