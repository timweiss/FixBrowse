Public Class Settings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Bookmark1 = Form1.AdressBarTextinput.Text
        My.Settings.BookmarkButton1 = TextBox1.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Bookmark2 = Form1.AdressBarTextinput.Text
        My.Settings.BookmarkButton2 = TextBox2.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Bookmark3 = Form1.AdressBarTextinput.Text
        My.Settings.BookmarkButton3 = TextBox3.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.Save()
        My.Settings.Reload()
        Form1.Button1.Text = My.Settings.BookmarkButton1
        Form1.Button2.Text = My.Settings.BookmarkButton2
        Form1.Button3.Text = My.Settings.BookmarkButton3
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = My.Settings.Version
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class