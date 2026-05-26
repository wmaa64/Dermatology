<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddSession
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
        Me.dtSessionDate = New System.Windows.Forms.DateTimePicker()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.cbDevice = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtSessionDate
        '
        Me.dtSessionDate.Location = New System.Drawing.Point(682, 37)
        Me.dtSessionDate.Name = "dtSessionDate"
        Me.dtSessionDate.Size = New System.Drawing.Size(200, 20)
        Me.dtSessionDate.TabIndex = 0
        '
        'cbArea
        '
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(682, 107)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(121, 21)
        Me.cbArea.TabIndex = 1
        '
        'cbDevice
        '
        Me.cbDevice.FormattingEnabled = True
        Me.cbDevice.Location = New System.Drawing.Point(682, 164)
        Me.cbDevice.Name = "cbDevice"
        Me.cbDevice.Size = New System.Drawing.Size(121, 21)
        Me.cbDevice.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(682, 229)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(682, 302)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(200, 96)
        Me.txtNotes.TabIndex = 4
        Me.txtNotes.Text = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(682, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 32)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FrmAddSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 530)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cbDevice)
        Me.Controls.Add(Me.cbArea)
        Me.Controls.Add(Me.dtSessionDate)
        Me.Name = "FrmAddSession"
        Me.Text = "FrmAddSession"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtSessionDate As DateTimePicker
    Friend WithEvents cbArea As ComboBox
    Friend WithEvents cbDevice As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents btnSave As Button
End Class
