
Imports Renci.SshNet
Imports Renci.SshNet.Common

Public Class frm_main
    Private sshClient As SshClient
    Private forwardedPort As ForwardedPortRemote

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click
        ConnectToSsh()
        If sshClient Is Nothing OrElse Not sshClient.IsConnected Then
            MessageBox.Show("SSH is not connected.")
            Return
        End If

        SetupPortForwarding()
        Log.AppendText($"Connected to ssh.. {My.Settings.Host}" & Environment.NewLine)
    End Sub

    Private Sub ConnectToSsh()
        If sshClient IsNot Nothing AndAlso sshClient.IsConnected Then
            Return ' Already connected
        End If

        Try
            sshClient = New SshClient(My.Settings.Host, Integer.Parse(My.Settings.Port), My.Settings.Username, My.Settings.Password)
            sshClient.Connect()
            Forward.Text = "Connected"
            Forward.Enabled = False
            Forward.BackColor = Color.Green






            Log.AppendText($"Connected to ssh.. {My.Settings.Host}" & Environment.NewLine)
        Catch ex As Exception
            MessageBox.Show($"Error connecting to SSH: {ex.Message}")
            sshClient = Nothing
        End Try
    End Sub

    Private Sub SetupPortForwarding()
        Dim remotePortNumber As Integer = 6000 ' Remote port on the SSH server
        Dim localPortNumber As Integer = 80 ' Local port to forward to

        If forwardedPort IsNot Nothing AndAlso forwardedPort.IsStarted Then
            sshClient.RemoveForwardedPort(forwardedPort)
        End If

        forwardedPort = New ForwardedPortRemote(remotePortNumber, "127.0.0.1", localPortNumber)
        sshClient.AddForwardedPort(forwardedPort)

        AddHandler forwardedPort.Exception, AddressOf ForwardedPort_Exception
        Try
            forwardedPort.Start()
            Log.AppendText($"Remote forwarding: SSH Server Port {remotePortNumber} -> Local Port {localPortNumber}" & Environment.NewLine)
        Catch ex As Exception
            Log.AppendText($"Error starting remote port forwarding: {ex.Message}" & Environment.NewLine)
        End Try
    End Sub


    Private Sub ForwardedPort_Exception(sender As Object, e As ExceptionEventArgs)
        Invoke(Sub()
                   Log.AppendText($"Error in remote port forwarding: {e.Exception.Message}" & Environment.NewLine)
               End Sub)
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize NotifyIcon
        NotifyIcon1.Icon = SystemIcons.Application ' Set your desired icon
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_setting.ShowDialog()
        ' Refresh SSH settings here after frm_setting is closed
        If sshClient IsNot Nothing AndAlso sshClient.IsConnected Then
            sshClient.Disconnect()
        End If
        ConnectToSsh()
    End Sub

    Private Sub frm_main_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        If sshClient IsNot Nothing AndAlso sshClient.IsConnected Then
            sshClient.Disconnect()
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs)
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs)
        Show() ' Show the form
        WindowState = FormWindowState.Normal ' Optional: Restore the window if minimized
        NotifyIcon1.Visible = False ' Hide the NotifyIcon from the system tray
    End Sub
    Private Sub frm_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Hide()
            MessageBox.Show("Application run in backgroun on System Tray")

            NotifyIcon1.Visible = True ' Show the NotifyIcon in the system tray
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Open.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Close.Click
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
End Class
