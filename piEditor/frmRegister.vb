Option Explicit On

Public Class frmRegister

    Dim btnEdits As Button()
    Dim lblTitles As Label()
    Dim dgvs As DataGridView()

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            btnEdits = {btnEdit1, btnEdit2, btnEdit3, btnEdit4}
            lblTitles = {lblTitle1, lblTitle2, lblTitle3, lblTitle4}
            dgvs = {dgv1, dgv2, dgv3, dgv4}

            '★モック用テストデータ
            Dim dt As DataTable = New DataTable
            dt.Columns.Add("番号")
            dt.Columns.Add("出力フラグ")
            dt.Columns.Add("氏名")
            dt.Columns.Add("郵便番号")
            dt.Columns.Add("住所")

            For i As Integer = 0 To dgvs.Length - 1
                With dgvs(i)
                    .DataSource = dt                '※デモ用です。実際は4つのデータグリッドビューに同一のデータテーブルを設定しないようにしてください。
                    .RowHeadersVisible = False
                    .AllowUserToAddRows = False
                    .AllowUserToResizeRows = False
                    .AllowUserToResizeColumns = True
                    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                    .ColumnHeadersHeight = 30
                    .EnableHeadersVisualStyles = False
                    .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkKhaki
                    '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                End With
            Next

            '★モック用テストデータ


        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message & "(" & Reflection.MethodBase.GetCurrentMethod.Name & ")")
        Finally

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit1.Click, btnEdit2.Click, btnEdit3.Click, btnEdit4.Click

        Try
            Dim index As Integer = sender.Tag
            Dim f As frmEdit = New frmEdit
            f.lblTitle.Text = lblTitles(index).Text
            f.ShowDialog()
            f.Dispose()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message & "(" & Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click, btnAdd2.Click, btnAdd3.Click, btnAdd4.Click

        Try
            Dim index As Integer = sender.Tag
            Dim f As frmEdit = New frmEdit
            f.lblTitle.Text = lblTitles(index).Text
            f.ShowDialog()
            f.Dispose()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message & "(" & Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'TODO:データグリッドの内容をデータベースに反映する

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message & "(" & Reflection.MethodBase.GetCurrentMethod.Name & ")")
        Finally

        End Try

    End Sub
End Class