<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainPartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPartToComboBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPartToListBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearPartInListBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountPartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DescComboBox = New System.Windows.Forms.ComboBox()
        Me.qtyTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MaintainPartsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(543, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 48)
        '
        'PartToolStripMenuItem
        '
        Me.PartToolStripMenuItem.Name = "PartToolStripMenuItem"
        Me.PartToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PartToolStripMenuItem.Text = "Add Part of ListBox"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MaintainPartsToolStripMenuItem
        '
        Me.MaintainPartsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPartToComboBoxToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem2, Me.AddPartToListBoxToolStripMenuItem, Me.ClearPartInListBoxToolStripMenuItem, Me.CountPartToolStripMenuItem})
        Me.MaintainPartsToolStripMenuItem.Name = "MaintainPartsToolStripMenuItem"
        Me.MaintainPartsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MaintainPartsToolStripMenuItem.Text = "Maintain Parts"
        '
        'AddPartToComboBoxToolStripMenuItem
        '
        Me.AddPartToComboBoxToolStripMenuItem.Name = "AddPartToComboBoxToolStripMenuItem"
        Me.AddPartToComboBoxToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.AddPartToComboBoxToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.AddPartToComboBoxToolStripMenuItem.Text = "Add Part to ComboBox"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete Part from ComboBox"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(329, 22)
        Me.ToolStripMenuItem2.Text = "---------------------------------------------------"
        '
        'AddPartToListBoxToolStripMenuItem
        '
        Me.AddPartToListBoxToolStripMenuItem.Name = "AddPartToListBoxToolStripMenuItem"
        Me.AddPartToListBoxToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddPartToListBoxToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.AddPartToListBoxToolStripMenuItem.Text = "Add Part to ListBox"
        '
        'ClearPartInListBoxToolStripMenuItem
        '
        Me.ClearPartInListBoxToolStripMenuItem.Name = "ClearPartInListBoxToolStripMenuItem"
        Me.ClearPartInListBoxToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearPartInListBoxToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.ClearPartInListBoxToolStripMenuItem.Text = "Clear Part in ListBox"
        '
        'CountPartToolStripMenuItem
        '
        Me.CountPartToolStripMenuItem.Name = "CountPartToolStripMenuItem"
        Me.CountPartToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.CountPartToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.CountPartToolStripMenuItem.Text = "Count Parts in ListBox"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Controls.Add(Me.DescComboBox)
        Me.GroupBox1.Controls.Add(Me.qtyTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.salesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Part and Order Information"
        '
        'DescComboBox
        '
        Me.DescComboBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DescComboBox.FormattingEnabled = True
        Me.DescComboBox.Items.AddRange(New Object() {"Brake Pads", "Engine", "Injector", "Oil Filter", "Tire", "Transmission", "Wheel Rim"})
        Me.DescComboBox.Location = New System.Drawing.Point(115, 29)
        Me.DescComboBox.Name = "DescComboBox"
        Me.DescComboBox.Size = New System.Drawing.Size(387, 21)
        Me.DescComboBox.TabIndex = 2
        '
        'qtyTextBox
        '
        Me.qtyTextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.qtyTextBox.Location = New System.Drawing.Point(361, 65)
        Me.qtyTextBox.Name = "qtyTextBox"
        Me.qtyTextBox.Size = New System.Drawing.Size(141, 20)
        Me.qtyTextBox.TabIndex = 4
        Me.qtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label3.Location = New System.Drawing.Point(237, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantity to be Shipped:"
        '
        'salesTextBox
        '
        Me.salesTextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.salesTextBox.Location = New System.Drawing.Point(115, 65)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.salesTextBox.TabIndex = 2
        Me.salesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sales Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Description:"
        '
        'ListBox
        '
        Me.ListBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(12, 160)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(519, 95)
        Me.ListBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Location = New System.Drawing.Point(328, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Order Total:"
        '
        'totalTextBox
        '
        Me.totalTextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.totalTextBox.Location = New System.Drawing.Point(397, 279)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(134, 20)
        Me.totalTextBox.TabIndex = 5
        Me.totalTextBox.TabStop = False
        Me.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 320)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "The Edwardsville Auto Store - Jess Clarene Arreza"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintainPartsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DescComboBox As ComboBox
    Friend WithEvents qtyTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents salesTextBox As TextBox
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPartToComboBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPartToListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearPartInListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountPartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
