Imports Microsoft.Win32

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim systemRegistry As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")

        systemRegistry.SetValue("DisableTaskMgr", 1)

        systemRegistry.Close()

    End Sub


End Class