Option Explicit On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '★モック用テストデータ
        Dim dt As DataTable = New DataTable
        dt.Columns.Add("ID")
        dt.Columns.Add("建物No")
        dt.Columns.Add("行政区")
        dt.Columns.Add("所在地")
        dt.Columns.Add("ステータス")
        dt.Columns.Add("敷地外調査")
        dt.Columns.Add("敷地内調査")
        dt.Columns.Add("重点対象地区")
        dt.Columns.Add("建物登記名義")
        dt.Columns.Add("建物登記名義郵便番号")
        dt.Columns.Add("建物登記名義住所")
        dt.Columns.Add("土地登記名義")
        dt.Columns.Add("土地登記名義郵便番号")
        dt.Columns.Add("土地登記名義住所")
        dt.Columns.Add("建物納税通知先")
        dt.Columns.Add("建物納税通知先郵便番号")
        dt.Columns.Add("建物納税通知先住所")
        dt.Columns.Add("土地納税通知先")
        dt.Columns.Add("土地納税通知先郵便番号")
        dt.Columns.Add("土地納税通知先住所")
        dt.Columns.Add("最新対応日")
        dt.Columns.Add("最新対応種別")
        dt.Columns.Add("最新対応種別（その他）")
        dt.Columns.Add("評価")
        dt.Columns.Add("建築年度")
        With dgvMain
            .DataSource = dt
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 30
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkKhaki
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End With

        '★モック用テストデータ

    End Sub

    Private Sub btnEditPersonal_Click(sender As Object, e As EventArgs) Handles btnEditPersonal.Click

        Try
            Dim f As frmRegister = New frmRegister
            f.ShowDialog()
            f.Dispose()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message & "(" & Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try

    End Sub

    Private Sub lblCheck_Click(sender As Object, e As EventArgs) Handles lblCheck.Click
        chkOutputFlag.Checked = Not chkOutputFlag.Checked
    End Sub
End Class
