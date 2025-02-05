<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashFlow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashFlow))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblReturn = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCredit = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblCashInHand = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblRecovery = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblExpense = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblPending = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCollection = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblOpeningCash = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(905, 55)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "CASH FLOW"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.lblReturn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblCredit)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblCashInHand)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblRecovery)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblExpense)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblPending)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblCollection)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblOpeningCash)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 576)
        Me.Panel1.TabIndex = 100
        '
        'lblReturn
        '
        Me.lblReturn.BackColor = System.Drawing.Color.Goldenrod
        Me.lblReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturn.ForeColor = System.Drawing.Color.White
        Me.lblReturn.Location = New System.Drawing.Point(530, 389)
        Me.lblReturn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(343, 52)
        Me.lblReturn.TabIndex = 15
        Me.lblReturn.Text = "0.00"
        Me.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 405)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Return Cash"
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.Color.IndianRed
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.ForeColor = System.Drawing.Color.White
        Me.lblCredit.Location = New System.Drawing.Point(530, 239)
        Me.lblCredit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(343, 52)
        Me.lblCredit.TabIndex = 13
        Me.lblCredit.Text = "0.00"
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(29, 254)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Daily Credit Cash"
        '
        'lblCashInHand
        '
        Me.lblCashInHand.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCashInHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCashInHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashInHand.ForeColor = System.Drawing.Color.White
        Me.lblCashInHand.Location = New System.Drawing.Point(530, 490)
        Me.lblCashInHand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCashInHand.Name = "lblCashInHand"
        Me.lblCashInHand.Size = New System.Drawing.Size(343, 52)
        Me.lblCashInHand.TabIndex = 11
        Me.lblCashInHand.Text = "0.00"
        Me.lblCashInHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 503)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Cash In Hand"
        '
        'lblRecovery
        '
        Me.lblRecovery.BackColor = System.Drawing.Color.LimeGreen
        Me.lblRecovery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecovery.ForeColor = System.Drawing.Color.White
        Me.lblRecovery.Location = New System.Drawing.Point(530, 187)
        Me.lblRecovery.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecovery.Name = "lblRecovery"
        Me.lblRecovery.Size = New System.Drawing.Size(343, 52)
        Me.lblRecovery.TabIndex = 9
        Me.lblRecovery.Text = "0.00"
        Me.lblRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 201)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Cash Recovery"
        '
        'lblExpense
        '
        Me.lblExpense.BackColor = System.Drawing.Color.Goldenrod
        Me.lblExpense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpense.ForeColor = System.Drawing.Color.White
        Me.lblExpense.Location = New System.Drawing.Point(530, 337)
        Me.lblExpense.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpense.Name = "lblExpense"
        Me.lblExpense.Size = New System.Drawing.Size(343, 52)
        Me.lblExpense.TabIndex = 7
        Me.lblExpense.Text = "0.00"
        Me.lblExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 353)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Daily Expenses"
        '
        'lblPending
        '
        Me.lblPending.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblPending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.Color.White
        Me.lblPending.Location = New System.Drawing.Point(530, 135)
        Me.lblPending.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(343, 52)
        Me.lblPending.TabIndex = 5
        Me.lblPending.Text = "0.00"
        Me.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 149)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pending Cash"
        '
        'lblCollection
        '
        Me.lblCollection.BackColor = System.Drawing.Color.LimeGreen
        Me.lblCollection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollection.ForeColor = System.Drawing.Color.White
        Me.lblCollection.Location = New System.Drawing.Point(530, 84)
        Me.lblCollection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCollection.Name = "lblCollection"
        Me.lblCollection.Size = New System.Drawing.Size(343, 52)
        Me.lblCollection.TabIndex = 3
        Me.lblCollection.Text = "0.00"
        Me.lblCollection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Daily Cash Collection"
        '
        'lblOpeningCash
        '
        Me.lblOpeningCash.BackColor = System.Drawing.Color.LimeGreen
        Me.lblOpeningCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOpeningCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpeningCash.ForeColor = System.Drawing.Color.White
        Me.lblOpeningCash.Location = New System.Drawing.Point(530, 32)
        Me.lblOpeningCash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpeningCash.Name = "lblOpeningCash"
        Me.lblOpeningCash.Size = New System.Drawing.Size(343, 52)
        Me.lblOpeningCash.TabIndex = 1
        Me.lblOpeningCash.Text = "0.00"
        Me.lblOpeningCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Opening Cash B/D"
        '
        'dateTimePicker
        '
        Me.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePicker.Location = New System.Drawing.Point(608, 16)
        Me.dateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Size = New System.Drawing.Size(265, 24)
        Me.dateTimePicker.TabIndex = 0
        Me.dateTimePicker.Visible = False
        '
        'CashFlow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 631)
        Me.Controls.Add(Me.dateTimePicker)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "CashFlow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Flow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents dateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCollection As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOpeningCash As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblExpense As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPending As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCashInHand As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRecovery As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblReturn As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
