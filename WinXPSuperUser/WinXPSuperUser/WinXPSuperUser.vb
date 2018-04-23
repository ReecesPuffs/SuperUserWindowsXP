Imports System.Environment
Public Class WinXPSuperUser
    Dim Driveletter As String
    Dim appDataloc As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim DriveIsValid
    Dim sitedl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Verify_Click(sender As Object, e As EventArgs) Handles Verify.Click
        Try
            If IO.Directory.Exists(Driveletter & ":\windows") Then
                MsgBox(Driveletter & ": Drive is a Thing :D", vbOKOnly, "Our Service Says:")
                DriveIsValid = True
            Else
                MsgBox(Driveletter & ": Drive is Not a Thing D:", vbOKOnly, "Our Service Says:")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Driveletter = TextBox1.Text
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        sitedl = "https://github.com/ReecesPuffs/SuperUserWindows"
        MsgBox("Made By Reece's Puffs and digm0repaka, Beta Tested by barndon, Now on GitHub " & sitedl, vbOKOnly, "Version: 4.3.2")
    End Sub

    Private Sub Winver_Click(sender As Object, e As EventArgs) Handles Winver.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\winver.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Services_Click(sender As Object, e As EventArgs) Handles Services.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\services.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Appdata_Click(sender As Object, e As EventArgs) Handles Appdata.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\windows\explorer.exe", appDataloc)
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub DirectXDiag_Click(sender As Object, e As EventArgs) Handles DirectXDiag.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\dxdiag.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub ControlPanel_Click(sender As Object, e As EventArgs) Handles ControlPanel.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\control.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub DiskCleanup_Click(sender As Object, e As EventArgs) Handles DiskCleanup.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\cleanmgr.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub GroupPolicyEditor_Click(sender As Object, e As EventArgs) Handles GroupPolicyEditor.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\windows\System32\gpedit.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub CMD_Click(sender As Object, e As EventArgs) Handles CMD.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\cmd.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub CompMgmt_Click(sender As Object, e As EventArgs) Handles CompMgmt.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\compmgmt.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub DeviceManager_Click(sender As Object, e As EventArgs) Handles DeviceManager.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\devmgmt.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub EventViewer_Click(sender As Object, e As EventArgs) Handles EventViewer.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\eventvwr.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub AppWizard_Click(sender As Object, e As EventArgs) Handles AppWizard.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\windows\system32\appwiz.cpl")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub AbortShutdown_Click(sender As Object, e As EventArgs) Handles AbortShutdown.Click
        If DriveIsValid = True Then
            Shell("shutdown -a")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Shutdown_Click(sender As Object, e As EventArgs) Handles Shutdown.Click
        If DriveIsValid = True Then
            Shell("shutdown -s")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub TaskManager_Click(sender As Object, e As EventArgs) Handles TaskManager.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\System32\taskmgr.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Regedit_Click(sender As Object, e As EventArgs) Handles Regedit.Click
        If DriveIsValid = True Then
            Process.Start(Driveletter & ":\Windows\regedit.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Logoff_Click(sender As Object, e As EventArgs) Handles Logoff.Click
        If DriveIsValid = True Then
            Shell("shutdown -l")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        If DriveIsValid = True Then
            Shell("shutdown -r")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub
End Class
