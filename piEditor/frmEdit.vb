Option Explicit On

Public Class frmEdit

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            'TODO:新規 もしくは 変更の内容を、frmRegisterの呼び出し元のデータグリッドに反映する

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message & "(" & Reflection.MethodBase.GetCurrentMethod.Name & ")")
        Finally

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class