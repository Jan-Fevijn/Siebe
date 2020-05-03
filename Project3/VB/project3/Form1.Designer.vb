<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToevoegenBrood
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToevoegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtbrood = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.nmrCode = New System.Windows.Forms.NumericUpDown()
        Me.nmrPrijs = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nmrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrPrijs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToevoegenToolStripMenuItem, Me.SaldoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToevoegenToolStripMenuItem
        '
        Me.ToevoegenToolStripMenuItem.Name = "ToevoegenToolStripMenuItem"
        Me.ToevoegenToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ToevoegenToolStripMenuItem.Text = "Toevoegen"
        '
        'SaldoToolStripMenuItem
        '
        Me.SaldoToolStripMenuItem.Name = "SaldoToolStripMenuItem"
        Me.SaldoToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.SaldoToolStripMenuItem.Text = "saldo"
        '
        'txtbrood
        '
        Me.txtbrood.Location = New System.Drawing.Point(52, 112)
        Me.txtbrood.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbrood.Name = "txtbrood"
        Me.txtbrood.Size = New System.Drawing.Size(76, 20)
        Me.txtbrood.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "brood:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 173)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 233)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "prijs:"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(143, 170)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(56, 19)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'nmrCode
        '
        Me.nmrCode.Location = New System.Drawing.Point(53, 171)
        Me.nmrCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nmrCode.Name = "nmrCode"
        Me.nmrCode.Size = New System.Drawing.Size(75, 20)
        Me.nmrCode.TabIndex = 8
        '
        'nmrPrijs
        '
        Me.nmrPrijs.DecimalPlaces = 2
        Me.nmrPrijs.Location = New System.Drawing.Point(53, 231)
        Me.nmrPrijs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nmrPrijs.Name = "nmrPrijs"
        Me.nmrPrijs.Size = New System.Drawing.Size(75, 20)
        Me.nmrPrijs.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nieuwe broden "
        '
        'frmToevoegenBrood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(330, 292)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nmrPrijs)
        Me.Controls.Add(Me.nmrCode)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbrood)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmToevoegenBrood"
        Me.Text = "Brood Toevoegen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nmrCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrPrijs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToevoegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtbrood As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents nmrCode As NumericUpDown
    Friend WithEvents nmrPrijs As NumericUpDown
    Friend WithEvents Label4 As Label
End Class
