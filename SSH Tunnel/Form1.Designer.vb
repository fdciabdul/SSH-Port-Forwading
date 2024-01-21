<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        NotifyIcon1 = New NotifyIcon(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Open = New ToolStripMenuItem()
        Close = New ToolStripMenuItem()
        LocalPort = New TextBox()
        ToPort = New TextBox()
        Button1 = New Button()
        lblLocal = New Label()
        lblPort = New Label()
        Forward = New Button()
        Log = New TextBox()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(18, 18)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {Open, Close})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional
        ContextMenuStrip1.Size = New Size(195, 76)
        ' 
        ' Open
        ' 
        Open.Image = My.Resources.Resources._568140
        Open.Name = "Open"
        Open.Size = New Size(194, 24)
        Open.Text = "Open"
        Open.ToolTipText = "Open"
        ' 
        ' Close
        ' 
        Close.Image = My.Resources.Resources._5017421_200
        Close.Name = "Close"
        Close.Size = New Size(194, 24)
        Close.Text = "Close"
        Close.ToolTipText = "Close"
        ' 
        ' LocalPort
        ' 
        LocalPort.Location = New Point(80, 56)
        LocalPort.Name = "LocalPort"
        LocalPort.Size = New Size(225, 25)
        LocalPort.TabIndex = 0
        ' 
        ' ToPort
        ' 
        ToPort.Location = New Point(80, 101)
        ToPort.Name = "ToPort"
        ToPort.Size = New Size(225, 25)
        ToPort.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(179, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 25)
        Button1.TabIndex = 2
        Button1.Text = "Setting"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblLocal
        ' 
        lblLocal.AutoSize = True
        lblLocal.Location = New Point(12, 59)
        lblLocal.Name = "lblLocal"
        lblLocal.Size = New Size(62, 17)
        lblLocal.TabIndex = 3
        lblLocal.Text = "LocalPort"
        ' 
        ' lblPort
        ' 
        lblPort.AutoSize = True
        lblPort.Location = New Point(12, 104)
        lblPort.Name = "lblPort"
        lblPort.Size = New Size(50, 17)
        lblPort.TabIndex = 4
        lblPort.Text = "To Port"
        ' 
        ' Forward
        ' 
        Forward.BackColor = SystemColors.ActiveCaption
        Forward.Location = New Point(12, 155)
        Forward.Name = "Forward"
        Forward.Size = New Size(293, 48)
        Forward.TabIndex = 5
        Forward.Text = "Connect"
        Forward.UseVisualStyleBackColor = False
        ' 
        ' Log
        ' 
        Log.BackColor = SystemColors.InfoText
        Log.ForeColor = SystemColors.Info
        Log.Location = New Point(12, 209)
        Log.Multiline = True
        Log.Name = "Log"
        Log.Size = New Size(293, 153)
        Log.TabIndex = 6
        ' 
        ' frm_main
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 376)
        Controls.Add(Log)
        Controls.Add(Forward)
        Controls.Add(lblPort)
        Controls.Add(lblLocal)
        Controls.Add(Button1)
        Controls.Add(ToPort)
        Controls.Add(LocalPort)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SSH Tunnel"
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LocalPort As TextBox
    Friend WithEvents ToPort As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLocal As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents Forward As Button
    Friend WithEvents Log As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Open As ToolStripMenuItem
    Friend WithEvents Close As ToolStripMenuItem

End Class
