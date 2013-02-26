Public Class RewardsEdit

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'opens adminrewards and closes rewards edit
        Admin_Rewards.Show()
        Me.Close()
    End Sub

    Private Sub RewardsEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Adding = False Then
            'adding is false there for the form is in change mode so the data of the reward selected to be changed
            'was put into the reward structure is now put into the text boxes and the text on the btn is changed to change
            lblRewardID.Text = reward.RewardID
            txtName.Text = reward.name
            txtCost.Text = reward.cost
            btnEnd.Text = "change"
        Else
            'adding is true so the text boxes are empty and a new reward id is put into lblrewardid
            lblRewardID.Text = NRewards + 1
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        'checks if the cost is a number if not then an error message will be sent and the sub ended
        If IsNumeric(txtCost.Text) = False Then
            MsgBox("cost must be a number")
            Exit Sub
        End If
        'checks if there is a name inputed if not then an error message will be sent and the sub ended
        If txtName.Text.Trim = "" Then
            MsgBox("there must be a name")
            Exit Sub
        End If
        'puts the data in the text boxs and lable into the reward structure
        reward.RewardID = lblRewardID.Text
        reward.cost = Int(txtCost.Text)
        reward.name = txtName.Text
        'puts the data from the reward structue into the rewards dat file
        PutReward(reward, reward.RewardID)
        NRewards += 1
        'updates the data grid on adminrewards
        If Adding = True Then
            Admin_Rewards.grdRewards.Rows.Add(reward.RewardID, reward.name, reward.cost)
        Else : Admin_Rewards.grdRewards.Rows.Clear()
            For counter As Integer = 1 To NRewards
                reward = GetReward(counter)
                Admin_Rewards.grdRewards.Rows.Add(reward.RewardID, reward.name, reward.cost)
            Next
        End If
        'closes the rewards edit form and shows the admin rewards form
        Admin_Rewards.Show()
        Me.Close()


    End Sub
End Class