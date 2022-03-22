<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFromValue = New System.Windows.Forms.TextBox()
        Me.txtToValue = New System.Windows.Forms.TextBox()
        Me.cboFromUnit = New System.Windows.Forms.ComboBox()
        Me.cboToUnit = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFromValue
        '
        Me.txtFromValue.Location = New System.Drawing.Point(21, 53)
        Me.txtFromValue.Name = "txtFromValue"
        Me.txtFromValue.Size = New System.Drawing.Size(130, 23)
        Me.txtFromValue.TabIndex = 0
        '
        'txtToValue
        '
        Me.txtToValue.Location = New System.Drawing.Point(256, 53)
        Me.txtToValue.Name = "txtToValue"
        Me.txtToValue.ReadOnly = True
        Me.txtToValue.Size = New System.Drawing.Size(130, 23)
        Me.txtToValue.TabIndex = 1
        '
        'cboFromUnit
        '
        Me.cboFromUnit.FormattingEnabled = True
        Me.cboFromUnit.Items.AddRange(New Object() {"th", "bc", "in", "h", "ft", "yd", "ftm", "ch", "fur", "mi", "nmi", "lea", "mm", "cm", "dm", "m", "dam", "hm", "km"})
        Me.cboFromUnit.Location = New System.Drawing.Point(21, 82)
        Me.cboFromUnit.Name = "cboFromUnit"
        Me.cboFromUnit.Size = New System.Drawing.Size(130, 23)
        Me.cboFromUnit.TabIndex = 2
        '
        'cboToUnit
        '
        Me.cboToUnit.FormattingEnabled = True
        Me.cboToUnit.Items.AddRange(New Object() {"th", "bc", "in", "h", "ft", "yd", "ftm", "ch", "fur", "mi", "nmi", "lea", "mm", "cm", "dm", "m", "dam", "hm", "km"})
        Me.cboToUnit.Location = New System.Drawing.Point(256, 82)
        Me.cboToUnit.Name = "cboToUnit"
        Me.cboToUnit.Size = New System.Drawing.Size(130, 23)
        Me.cboToUnit.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(95, 129)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(106, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(207, 129)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(412, 177)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.cboToUnit)
        Me.Controls.Add(Me.cboFromUnit)
        Me.Controls.Add(Me.txtToValue)
        Me.Controls.Add(Me.txtFromValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFromValue As TextBox
    Friend WithEvents txtToValue As TextBox
    Friend WithEvents cboFromUnit As ComboBox
    Friend WithEvents cboToUnit As ComboBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClose As Button
End Class
