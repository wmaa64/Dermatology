<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddProductUnit
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFactor = New System.Windows.Forms.TextBox()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.chkBaseUnit = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(704, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "اختار الوحدة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(685, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "المعامل التحويل"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(701, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "اختار الصنف"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(664, 403)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 33)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtFactor
        '
        Me.txtFactor.Location = New System.Drawing.Point(543, 118)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFactor.Size = New System.Drawing.Size(221, 20)
        Me.txtFactor.TabIndex = 15
        '
        'cmbProduct
        '
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(543, 26)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(221, 21)
        Me.cmbProduct.TabIndex = 26
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(543, 71)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(221, 21)
        Me.cmbUnit.TabIndex = 27
        '
        'chkBaseUnit
        '
        Me.chkBaseUnit.AutoSize = True
        Me.chkBaseUnit.Location = New System.Drawing.Point(674, 156)
        Me.chkBaseUnit.Name = "chkBaseUnit"
        Me.chkBaseUnit.Size = New System.Drawing.Size(90, 17)
        Me.chkBaseUnit.TabIndex = 28
        Me.chkBaseUnit.Text = "وحدة اساسية"
        Me.chkBaseUnit.UseVisualStyleBackColor = True
        '
        'FrmAddProductUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkBaseUnit)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtFactor)
        Me.Name = "FrmAddProductUnit"
        Me.Text = "FrmAddProductUnit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFactor As TextBox
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents chkBaseUnit As CheckBox
End Class
