Imports System.IO

Public Class Match
    Private Sub Match_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim line As String
        Dim dash As Integer
        Dim i = 0
        Dim maxnum = 0

        Dim sr As StreamReader = New StreamReader("batchList.csv")

        Do
            line = sr.ReadLine()
            dash = InStr(line, ",")
            match_DataGridView.Columns.Add(i.ToString, Mid(line, 1, dash - 1))
            match_DataGridView.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            i = i + 1
        Loop Until sr.Peek = -1
        maxnum = i
        sr.Close()

        Dim sr1 As StreamReader = New StreamReader("batchList.csv")
        i = 0
        Do
            line = sr1.ReadLine()
            dash = InStr(line, ",")
            match_DataGridView.Rows.Add()
            match_DataGridView.Rows(i).HeaderCell.Value = Mid(line, 1, dash - 1)
            i = i + 1
        Loop Until sr1.Peek = -1
        sr1.Close()

        match_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

        Dim sr2 As StreamReader = New StreamReader("match.csv")
        i = 0

        Dim dash2 = 1
        Do
            line = sr2.ReadLine()
            dash2 = InStr(1, line, ",")
            match_DataGridView.Rows(i).Cells(0).Value = Mid(line, 1, dash2 - 1)
            For index = 2 To maxnum - 1
                dash = dash2
                dash2 = InStr(dash + 1, line, ",")
                match_DataGridView.Rows(i).Cells(index - 1).Value = Mid(line, dash + 1, dash2 - dash - 1)
            Next
            match_DataGridView.Rows(i).Cells(maxnum - 1).Value = Mid(line, dash2 + 1, Len(line) - dash2)

            i = i + 1
        Loop Until sr2.Peek = -1
        sr2.Close()


    End Sub

    Private Sub close_Button_Click(sender As Object, e As EventArgs) Handles close_Button.Click
        Me.Close()
    End Sub
End Class