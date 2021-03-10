Public Class mainfrm


    Private WithEvents standard As standard
    Private seatsStandard() As Label
    Private totalStandard = -1
    Private totalClub = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'standard = New standard
        'grpWork.Controls.Add(standard)
        'nodes()







    End Sub

    Private Sub btnStandard_Click(sender As Object, e As EventArgs) Handles btnStandard.Click
        ' create a check if see if the train is full
        grpClub.Hide()
        Dim strString As String
        Dim seatsStandard() = {lbls1, lbls2}

        If totalStandard < 16 Then
            strString = tbName.Text.ToString

            totalStandard = totalStandard + 1
            seatsStandard(totalStandard).Text = CStr(strString)
            seatsStandard(totalStandard).BackColor = Color.Red




        Else

            MessageBox.Show("sorry seats are filled in standard", "Seats at capaacity.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If





    End Sub

    Private Sub nodes()
        'Dim i As Integer
        'For i = 65 To 90


        '    tvwCust.Nodes.Add(Chr(i), Chr(i))
        'Next

    End Sub

    Private Sub btnClub_Click(sender As Object, e As EventArgs) Handles btnClub.Click

    End Sub
End Class
