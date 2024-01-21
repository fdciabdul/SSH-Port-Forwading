<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_setting
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
        Panel1 = New Panel()
        Save = New Button()
        Label2 = New Label()
        txt_host = New TextBox()
        Label1 = New Label()
        txt_port = New TextBox()
        Port = New Label()
        txt_username = New TextBox()
        LblHost = New Label()
        txt_password = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Save)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txt_host)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txt_port)
        Panel1.Controls.Add(Port)
        Panel1.Controls.Add(txt_username)
        Panel1.Controls.Add(LblHost)
        Panel1.Controls.Add(txt_password)
        Panel1.Location = New Point(48, 45)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(469, 229)
        Panel1.TabIndex = 10
        ' 
        ' Save
        ' 
        Save.Location = New Point(280, 134)
        Save.Name = "Save"
        Save.Size = New Size(157, 57)
        Save.TabIndex = 0
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' txt_host
        ' 
        txt_host.Location = New Point(122, 61)
        txt_host.Name = "txt_host"
        txt_host.Size = New Size(110, 25)
        txt_host.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 17)
        Label1.TabIndex = 7
        Label1.Text = "Userame"
        ' 
        ' txt_port
        ' 
        txt_port.Location = New Point(301, 61)
        txt_port.Name = "txt_port"
        txt_port.Size = New Size(136, 25)
        txt_port.TabIndex = 2
        ' 
        ' Port
        ' 
        Port.AutoSize = True
        Port.Location = New Point(263, 65)
        Port.Name = "Port"
        Port.Size = New Size(32, 17)
        Port.TabIndex = 6
        Port.Text = "Port"
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(122, 114)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(110, 25)
        txt_username.TabIndex = 3
        ' 
        ' LblHost
        ' 
        LblHost.AutoSize = True
        LblHost.Location = New Point(42, 70)
        LblHost.Name = "LblHost"
        LblHost.Size = New Size(35, 17)
        LblHost.TabIndex = 5
        LblHost.Text = "Host"
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(122, 166)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(110, 25)
        txt_password.TabIndex = 4
        ' 
        ' frm_setting
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(608, 327)
        Controls.Add(Panel1)
        Name = "frm_setting"
        Text = "Setting"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Save As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_host As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_port As TextBox
    Friend WithEvents Port As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents LblHost As Label
    Friend WithEvents txt_password As TextBox
End Class
