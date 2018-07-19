<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conf))
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.pnl = New System.Windows.Forms.Panel
        Me.cboWeekDay = New System.Windows.Forms.ComboBox
        Me.lblWeekday = New System.Windows.Forms.Label
        Me.Horário = New System.Windows.Forms.Label
        Me.dtpTime = New System.Windows.Forms.DateTimePicker
        Me.txtDestination = New System.Windows.Forms.TextBox
        Me.lblDestination = New System.Windows.Forms.Label
        Me.txtSource = New System.Windows.Forms.TextBox
        Me.lblSource = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(0, 157)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(720, 160)
        Me.dgv.TabIndex = 10
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.cboWeekDay)
        Me.pnl.Controls.Add(Me.lblWeekday)
        Me.pnl.Controls.Add(Me.Horário)
        Me.pnl.Controls.Add(Me.dtpTime)
        Me.pnl.Controls.Add(Me.txtDestination)
        Me.pnl.Controls.Add(Me.lblDestination)
        Me.pnl.Controls.Add(Me.txtSource)
        Me.pnl.Controls.Add(Me.lblSource)
        Me.pnl.Controls.Add(Me.txtName)
        Me.pnl.Controls.Add(Me.lblName)
        Me.pnl.Enabled = False
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(696, 100)
        Me.pnl.TabIndex = 1
        '
        'cboWeekDay
        '
        Me.cboWeekDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWeekDay.FormattingEnabled = True
        Me.cboWeekDay.Items.AddRange(New Object() {"Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"})
        Me.cboWeekDay.Location = New System.Drawing.Point(162, 63)
        Me.cboWeekDay.Name = "cboWeekDay"
        Me.cboWeekDay.Size = New System.Drawing.Size(232, 21)
        Me.cboWeekDay.TabIndex = 20
        '
        'lblWeekday
        '
        Me.lblWeekday.AutoSize = True
        Me.lblWeekday.Location = New System.Drawing.Point(162, 48)
        Me.lblWeekday.Name = "lblWeekday"
        Me.lblWeekday.Size = New System.Drawing.Size(80, 13)
        Me.lblWeekday.TabIndex = 19
        Me.lblWeekday.Text = "Dia da Semana"
        '
        'Horário
        '
        Me.Horário.AutoSize = True
        Me.Horário.Location = New System.Drawing.Point(10, 47)
        Me.Horário.Name = "Horário"
        Me.Horário.Size = New System.Drawing.Size(43, 13)
        Me.Horário.TabIndex = 18
        Me.Horário.Text = "Destino"
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(10, 63)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(146, 20)
        Me.dtpTime.TabIndex = 17
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(400, 24)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(291, 20)
        Me.txtDestination.TabIndex = 15
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(400, 7)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(43, 13)
        Me.lblDestination.TabIndex = 16
        Me.lblDestination.Text = "Destino"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(162, 24)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(232, 20)
        Me.txtSource.TabIndex = 13
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(162, 7)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(40, 13)
        Me.lblSource.TabIndex = 14
        Me.lblSource.Text = "Origem"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(10, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(146, 20)
        Me.txtName.TabIndex = 11
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(10, 7)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Nome"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.Image = Global.Backup.View.My.Resources.Resources.imsCancel
        Me.btnCancel.Location = New System.Drawing.Point(582, 123)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(27, 28)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.Image = Global.Backup.View.My.Resources.Resources.imsNew
        Me.btnNew.Location = New System.Drawing.Point(615, 123)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(27, 28)
        Me.btnNew.TabIndex = 4
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.Image = Global.Backup.View.My.Resources.Resources.imsDelete
        Me.btnDelete.Location = New System.Drawing.Point(681, 123)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(27, 28)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.Image = Global.Backup.View.My.Resources.Resources.imsadd
        Me.btnAdd.Location = New System.Drawing.Point(648, 123)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(27, 28)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Conf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 317)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(736, 356)
        Me.MinimumSize = New System.Drawing.Size(736, 356)
        Me.Name = "Conf"
        Me.ShowIcon = False
        Me.Text = "Tarefas"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgv As System.Windows.Forms.DataGridView
    Private WithEvents pnl As System.Windows.Forms.Panel
    Private WithEvents cboWeekDay As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeekday As System.Windows.Forms.Label
    Friend WithEvents Horário As System.Windows.Forms.Label
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Private WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Private WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnNew As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button

End Class
