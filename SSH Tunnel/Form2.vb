' frm_setting.vb
Imports Renci.SshNet

Public Class frm_setting
    Private Sub frm_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default port if not already set
        If String.IsNullOrEmpty(txt_port.Text) Then
            txt_port.Text = "22"
        End If

        ' Load saved settings if they exist
        txt_host.Text = My.Settings.Host
        txt_port.Text = My.Settings.Port
        txt_username.Text = My.Settings.Username
        txt_password.Text = My.Settings.Password
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        ' Save settings
        My.Settings.Host = txt_host.Text
        My.Settings.Port = txt_port.Text
        My.Settings.Username = txt_username.Text
        My.Settings.Password = txt_password.Text
        My.Settings.Save()

        ' Disconnect and Reconnect with new settings
        SharedSSH.Disconnect()
        If SharedSSH.Instance IsNot Nothing AndAlso SharedSSH.Instance.IsConnected Then
            MessageBox.Show("SSH Connection successful. Settings saved.", "Success")
        Else
            MessageBox.Show("SSH Connection failed. Settings not saved.", "Error")
        End If
    End Sub

    Private Function CheckSshConnection(host As String, port As Integer, username As String, password As String) As Boolean
        Using client As New SshClient(host, port, username, password)
            Try
                client.Connect()
                Return client.IsConnected
            Catch ex As Exception
                MessageBox.Show($"SSH Connection failed: {ex.Message}", "Error")
                Return False
            Finally
                client.Disconnect()
            End Try
        End Using
    End Function
End Class
