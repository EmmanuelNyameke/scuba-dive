<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScuba
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
        Panel1 = New Panel()
        lblLength = New Label()
        lblCost = New Label()
        lblScubaDive = New Label()
        btnClear = New Button()
        btnDiveCost = New Button()
        lstDive = New ListBox()
        lblSelect = New Label()
        txtTeam = New TextBox()
        lblTeam = New Label()
        cboLocation = New ComboBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(lblLength)
        Panel1.Controls.Add(lblCost)
        Panel1.Controls.Add(lblScubaDive)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnDiveCost)
        Panel1.Controls.Add(lstDive)
        Panel1.Controls.Add(lblSelect)
        Panel1.Controls.Add(txtTeam)
        Panel1.Controls.Add(lblTeam)
        Panel1.Controls.Add(cboLocation)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(417, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 451)
        Panel1.TabIndex = 0
        ' 
        ' lblLength
        ' 
        lblLength.AutoSize = True
        lblLength.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLength.Location = New Point(130, 402)
        lblLength.Name = "lblLength"
        lblLength.Size = New Size(157, 30)
        lblLength.TabIndex = 10
        lblLength.Text = "XXXXXXXXXXXX"
        lblLength.Visible = False
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCost.Location = New Point(130, 381)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(157, 30)
        lblCost.TabIndex = 9
        lblCost.Text = "XXXXXXXXXXXX"
        lblCost.Visible = False
        ' 
        ' lblScubaDive
        ' 
        lblScubaDive.AutoSize = True
        lblScubaDive.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScubaDive.Location = New Point(130, 360)
        lblScubaDive.Name = "lblScubaDive"
        lblScubaDive.Size = New Size(157, 30)
        lblScubaDive.TabIndex = 8
        lblScubaDive.Text = "XXXXXXXXXXXX"
        lblScubaDive.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.MidnightBlue
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(263, 293)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(102, 36)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear Form"
        btnClear.UseVisualStyleBackColor = False
        btnClear.Visible = False
        ' 
        ' btnDiveCost
        ' 
        btnDiveCost.BackColor = Color.MidnightBlue
        btnDiveCost.ForeColor = Color.White
        btnDiveCost.Location = New Point(71, 293)
        btnDiveCost.Name = "btnDiveCost"
        btnDiveCost.Size = New Size(102, 36)
        btnDiveCost.TabIndex = 6
        btnDiveCost.Text = "Dive Cost"
        btnDiveCost.UseVisualStyleBackColor = False
        btnDiveCost.Visible = False
        ' 
        ' lstDive
        ' 
        lstDive.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstDive.FormattingEnabled = True
        lstDive.ItemHeight = 25
        lstDive.Location = New Point(123, 197)
        lstDive.Name = "lstDive"
        lstDive.Size = New Size(214, 79)
        lstDive.TabIndex = 5
        lstDive.Visible = False
        ' 
        ' lblSelect
        ' 
        lblSelect.AutoSize = True
        lblSelect.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSelect.Location = New Point(116, 169)
        lblSelect.Name = "lblSelect"
        lblSelect.Size = New Size(182, 30)
        lblSelect.TabIndex = 4
        lblSelect.Text = "Select Scuba Dive:"
        lblSelect.Visible = False
        ' 
        ' txtTeam
        ' 
        txtTeam.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTeam.Location = New Point(316, 115)
        txtTeam.Name = "txtTeam"
        txtTeam.Size = New Size(49, 35)
        txtTeam.TabIndex = 3
        txtTeam.TextAlign = HorizontalAlignment.Center
        txtTeam.Visible = False
        ' 
        ' lblTeam
        ' 
        lblTeam.AutoSize = True
        lblTeam.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTeam.Location = New Point(74, 118)
        lblTeam.Name = "lblTeam"
        lblTeam.Size = New Size(219, 30)
        lblTeam.TabIndex = 2
        lblTeam.Text = "Number in Dive Team:"
        lblTeam.Visible = False
        ' 
        ' cboLocation
        ' 
        cboLocation.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboLocation.FormattingEnabled = True
        cboLocation.Items.AddRange(New Object() {"Australia", "Belize", "Fiji"})
        cboLocation.Location = New Point(130, 72)
        cboLocation.Name = "cboLocation"
        cboLocation.Size = New Size(167, 33)
        cboLocation.TabIndex = 1
        cboLocation.Text = "Select Location:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(2, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(442, 34)
        Label1.TabIndex = 0
        Label1.Text = "Oceanic Scuba Expeditions"
        ' 
        ' frmScuba
        ' 
        AcceptButton = btnDiveCost
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.scuba
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btnClear
        ClientSize = New Size(854, 451)
        Controls.Add(Panel1)
        Name = "frmScuba"
        Text = "Oceanic Scuba Expedition"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents lblTeam As Label
    Friend WithEvents btnDiveCost As Button
    Friend WithEvents lstDive As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblScubaDive As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblLength As Label
    Friend WithEvents lblCost As Label

End Class
