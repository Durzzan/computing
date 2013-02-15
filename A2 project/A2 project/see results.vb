Public Class see_results

    Private Sub see_results_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lst1.ClearSelected()
        lst1.Items.Add("02/05 5:45 Luck Skywalker")
        lst1.Items.Add("02/05 5:50 Anakin Skywalker")
        lst1.Items.Add("02/05 5:55 Leya Organa")
        lst1.Items.Add("02/05 6:00 Han Solo")
        lst1.Items.Add("02/05 6:05 Obiwan Kenobi")
        lst1.Items.Add("02/05 6:10 Qui-gon Jin")
        lst1.Items.Add("02/05 6:15 Wedge Antillies")
        lst1.Items.Add("02/05 6:20 Biggs Darklighter")


        Label1.Text = "Padme Amadala"
    End Sub
End Class