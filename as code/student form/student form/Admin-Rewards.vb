Public Class Admin_Rewards

    Private Sub Admin_Rewards_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populate grdRewards
        For counter As Integer = 1 To NRewards
            reward = GetReward(counter)
            grdRewards.Rows.Add(reward.RewardID, reward.name, reward.cost)
        Next
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'show admindirectory and close adminrewards
        AdminDirectory.Show()
        Me.Close()
    End Sub

    Private Sub grdRewards_CellContentdoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRewards.CellContentClick
        Dim ID As Integer
        'intialise variable but if it doesnt work because content sellected is a header it will exit sub
        Try
            ID = grdRewards.Rows(e.RowIndex).Cells(0).Value
        Catch
            Exit Sub
        End Try
        'get reward 
        reward = GetReward(ID)
        'set global variable adding to false to tell the rewardsEdit form to open in change mode
        Adding = False
        'open the rewardsEdit form
        RewardsEdit.Show()

    End Sub

    Private Sub btnAddReward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReward.Click
        'set global variable adding to true to tell the rewardsEdit form to open in add mode
        Adding = True
        'open the rewardsedit form
        RewardsEdit.Show()
    End Sub
End Class