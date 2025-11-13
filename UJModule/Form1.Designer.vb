<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModule
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnPrac = New System.Windows.Forms.Button()
        Me.btnCT = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnBusiness = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(21, 24)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(221, 117)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnPrac
        '
        Me.btnPrac.Location = New System.Drawing.Point(21, 413)
        Me.btnPrac.Name = "btnPrac"
        Me.btnPrac.Size = New System.Drawing.Size(221, 117)
        Me.btnPrac.TabIndex = 1
        Me.btnPrac.Text = "Do Practicals and Exam For Informatics 1A"
        Me.btnPrac.UseVisualStyleBackColor = True
        '
        'btnCT
        '
        Me.btnCT.Location = New System.Drawing.Point(21, 213)
        Me.btnCT.Name = "btnCT"
        Me.btnCT.Size = New System.Drawing.Size(221, 117)
        Me.btnCT.TabIndex = 2
        Me.btnCT.Text = "Write Class Tests and Exam for Mathematics 1A"
        Me.btnCT.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(312, 213)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(221, 117)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(831, 24)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplay.Size = New System.Drawing.Size(345, 565)
        Me.txtDisplay.TabIndex = 4
        '
        'btnBusiness
        '
        Me.btnBusiness.Location = New System.Drawing.Point(312, 24)
        Me.btnBusiness.Name = "btnBusiness"
        Me.btnBusiness.Size = New System.Drawing.Size(221, 117)
        Me.btnBusiness.TabIndex = 5
        Me.btnBusiness.Text = "Exam For Business"
        Me.btnBusiness.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(312, 413)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(221, 117)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save on Sequential File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(603, 24)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(221, 117)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load From Sequential File"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 601)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBusiness)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnCT)
        Me.Controls.Add(Me.btnPrac)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "frmModule"
        Me.Text = "UJ Module"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents btnPrac As Button
    Friend WithEvents btnCT As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnBusiness As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
End Class
