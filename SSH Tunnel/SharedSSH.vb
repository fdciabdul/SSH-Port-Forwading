' SharedSSH.vb
Imports Renci.SshNet

Public Class SharedSSH
    Private Shared _instance As SshClient = Nothing

    Public Shared ReadOnly Property Instance As SshClient
        Get
            If _instance Is Nothing OrElse Not _instance.IsConnected Then
                Dim host As String = My.Settings.Host
                Dim port As Integer = Integer.Parse(My.Settings.Port)
                Dim username As String = My.Settings.Username
                Dim password As String = My.Settings.Password
                _instance = New SshClient(host, port, username, password)
                Try
                    _instance.Connect()
                Catch ex As Exception
                    MessageBox.Show($"Error connecting to SSH: {ex.Message}", "Error")
                    _instance = Nothing
                End Try
            End If
            Return _instance
        End Get
    End Property

    Public Shared Sub Disconnect()
        If _instance IsNot Nothing AndAlso _instance.IsConnected Then
            _instance.Disconnect()
        End If
        _instance = Nothing
    End Sub
End Class
