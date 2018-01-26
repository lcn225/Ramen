Imports System.IO

Public Class batchList
    Private Sub batchList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sr As StreamReader = New StreamReader("batchList.csv")
        Dim line As String
        Dim dash As Integer
        Dim i = 0

        batchList_DataGridView.Columns.Add("Name", "名称")
        batchList_DataGridView.Columns.Add("Enable", "是否可用")
        batchList_DataGridView.Columns(0).ReadOnly = True

        Do
            line = sr.ReadLine()
            dash = InStr(line, ",")
            batchList_DataGridView.Rows.Add()
            batchList_DataGridView.Rows(i).Cells(0).Value = Mid(line, 1, dash - 1)
            batchList_DataGridView.Rows(i).Cells(1).Value = Mid(line, dash + 1, Len(line))
            i = i + 1
        Loop Until sr.Peek = -1
        sr.Close()

    End Sub

    Private Sub close_Button_Click(sender As Object, e As EventArgs) Handles close_Button.Click
        Me.Close()
    End Sub

    Private Sub save_Button_Click(sender As Object, e As EventArgs) Handles save_Button.Click
        Me.Close()
    End Sub
End Class