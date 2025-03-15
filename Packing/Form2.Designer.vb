<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PackingDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackingDataSet = New Packing.PackingDataSet()
        Me.AdminTableAdapter = New Packing.PackingDataSetTableAdapters.AdminTableAdapter()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackingDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.PackingDataSetBindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Customer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(147, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "OrderPlaced"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(147, 268)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Packaging"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(505, 156)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "View Products"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Admin Pannel"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(514, 372)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PackingDataSetBindingSource
        '
        Me.PackingDataSetBindingSource.DataSource = Me.PackingDataSet
        Me.PackingDataSetBindingSource.Position = 0
        '
        'PackingDataSet
        '
        Me.PackingDataSet.DataSetName = "PackingDataSet"
        Me.PackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Admin Pannel"
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackingDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PackingDataSetBindingSource As BindingSource
    Friend WithEvents PackingDataSet As PackingDataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As PackingDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
End Class
