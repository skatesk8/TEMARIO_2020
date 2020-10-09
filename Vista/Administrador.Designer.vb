<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_multaLabel As System.Windows.Forms.Label
        Dim PlacaLabel As System.Windows.Forms.Label
        Dim RemisionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Me.MuniDataSet = New Vista.muniDataSet()
        Me.GeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralTableAdapter = New Vista.muniDataSetTableAdapters.GeneralTableAdapter()
        Me.TableAdapterManager = New Vista.muniDataSetTableAdapters.TableAdapterManager()
        Me.GeneralDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_multaTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.RemisionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Id_multaLabel = New System.Windows.Forms.Label()
        PlacaLabel = New System.Windows.Forms.Label()
        RemisionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        CType(Me.MuniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_multaLabel
        '
        Id_multaLabel.AutoSize = True
        Id_multaLabel.Location = New System.Drawing.Point(105, 47)
        Id_multaLabel.Name = "Id_multaLabel"
        Id_multaLabel.Size = New System.Drawing.Size(47, 13)
        Id_multaLabel.TabIndex = 1
        Id_multaLabel.Text = "Id multa:"
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = True
        PlacaLabel.Location = New System.Drawing.Point(294, 47)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(37, 13)
        PlacaLabel.TabIndex = 3
        PlacaLabel.Text = "Placa:"
        '
        'RemisionLabel
        '
        RemisionLabel.AutoSize = True
        RemisionLabel.Location = New System.Drawing.Point(484, 47)
        RemisionLabel.Name = "RemisionLabel"
        RemisionLabel.Size = New System.Drawing.Size(53, 13)
        RemisionLabel.TabIndex = 5
        RemisionLabel.Text = "Remision:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(105, 80)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(294, 80)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(40, 13)
        MontoLabel.TabIndex = 9
        MontoLabel.Text = "Monto:"
        '
        'MuniDataSet
        '
        Me.MuniDataSet.DataSetName = "muniDataSet"
        Me.MuniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "General"
        Me.GeneralBindingSource.DataSource = Me.MuniDataSet
        '
        'GeneralTableAdapter
        '
        Me.GeneralTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GeneralTableAdapter = Me.GeneralTableAdapter
        Me.TableAdapterManager.multasTableAdapter = Nothing
        Me.TableAdapterManager.multaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Vista.muniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'GeneralDataGridView
        '
        Me.GeneralDataGridView.AutoGenerateColumns = False
        Me.GeneralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GeneralDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.GeneralDataGridView.DataSource = Me.GeneralBindingSource
        Me.GeneralDataGridView.Location = New System.Drawing.Point(32, 117)
        Me.GeneralDataGridView.Name = "GeneralDataGridView"
        Me.GeneralDataGridView.Size = New System.Drawing.Size(711, 248)
        Me.GeneralDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_multa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_multa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Placa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Remision"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Remision"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'Id_multaTextBox
        '
        Me.Id_multaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Id_multa", True))
        Me.Id_multaTextBox.Location = New System.Drawing.Point(164, 44)
        Me.Id_multaTextBox.Name = "Id_multaTextBox"
        Me.Id_multaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_multaTextBox.TabIndex = 2
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Placa", True))
        Me.PlacaTextBox.Location = New System.Drawing.Point(353, 44)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlacaTextBox.TabIndex = 4
        '
        'RemisionTextBox
        '
        Me.RemisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Remision", True))
        Me.RemisionTextBox.Location = New System.Drawing.Point(543, 44)
        Me.RemisionTextBox.Name = "RemisionTextBox"
        Me.RemisionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RemisionTextBox.TabIndex = 6
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Fecha", True))
        Me.FechaTextBox.Location = New System.Drawing.Point(164, 77)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FechaTextBox.TabIndex = 8
        '
        'MontoTextBox
        '
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Monto", True))
        Me.MontoTextBox.Location = New System.Drawing.Point(353, 77)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MontoTextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Administrador"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(36, 384)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 12
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(119, 384)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 13
        Me.btnmodificar.Text = "Modoficar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(202, 384)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 14
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(283, 384)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 15
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(364, 384)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 16
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vista.My.Resources.Resources.emblemunreadable_93487
        Me.PictureBox1.Location = New System.Drawing.Point(728, 384)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(770, 419)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_multaLabel)
        Me.Controls.Add(Me.Id_multaTextBox)
        Me.Controls.Add(PlacaLabel)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(RemisionLabel)
        Me.Controls.Add(Me.RemisionTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.MontoTextBox)
        Me.Controls.Add(Me.GeneralDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        CType(Me.MuniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MuniDataSet As muniDataSet
    Friend WithEvents GeneralBindingSource As BindingSource
    Friend WithEvents GeneralTableAdapter As muniDataSetTableAdapters.GeneralTableAdapter
    Friend WithEvents TableAdapterManager As muniDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GeneralDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Id_multaTextBox As TextBox
    Friend WithEvents PlacaTextBox As TextBox
    Friend WithEvents RemisionTextBox As TextBox
    Friend WithEvents FechaTextBox As TextBox
    Friend WithEvents MontoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
