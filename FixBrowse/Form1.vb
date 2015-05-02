Public Class Form1

    Private Sub AdressBarGoButton_Click(sender As Object, e As EventArgs) Handles AdressBarGoButton.Click
        WebBrowser1.Navigate(AdressBarTextinput.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Settings.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(My.Settings.Bookmark1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = My.Settings.BookmarkButton1
        Button2.Text = My.Settings.BookmarkButton2
        Button3.Text = My.Settings.BookmarkButton3
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate(My.Settings.Bookmark2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(My.Settings.Bookmark3)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Console.WriteLine(WebBrowser1.Url)
    End Sub
End Class
