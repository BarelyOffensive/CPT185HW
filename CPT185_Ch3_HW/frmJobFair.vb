'Program Name:  Job Fair
'Programmer:    Kenneth Yarborough
'Date Written:  2/6/22
'Purpose:       The purpose of this program is to allow the user to view information regarding a job fair

Public Class frmJobFair

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        lblRoom.Visible = True      'Display the room label
        lblHall.Visible = True      'Display the hall label
        lblDate.Visible = True      'Display the date label
        btnDetails.Enabled = False  'Disable the details button
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()                     'Close the window
    End Sub

End Class
