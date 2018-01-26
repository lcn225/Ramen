Imports System.IO

Public Class Ramen_Main
    Private Sub Ramen_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combobox_format()

    End Sub

    Private Sub Combobox_format()
        batchQty_ComboBox.Items.Clear()

        For index = 2 To 8
            batchQty_ComboBox.Items.Add(index.ToString)
        Next

        batchQty_ComboBox.SelectedIndex = 0

    End Sub

    Private Sub batchList_Button_Click(sender As Object, e As EventArgs) Handles batchList_Button.Click
        batchList.Show()
    End Sub

    Private Sub matchBox_Button_Click(sender As Object, e As EventArgs) Handles matchBox_Button.Click
        Match.Show()
    End Sub

    Private Sub formatComboBox(i As Integer)

        Dim sr As StreamReader = New StreamReader("batchList.csv")
        Dim line As String

        Dim combo As ComboBox = Me.Controls("batch" & i & "_combobox")

        Dim batchList(0 To 1, 0 To 30) As String
        Dim index As Integer = 0

        Do
            line = sr.ReadLine()
            batchList(0, index) = Mid(line, 1, InStr(line, ",") - 1)
            batchList(1, index) = Mid(line, InStr(line, ",") + 1, 1)
            'combo.Items.Add(Mid(line, 1, InStr(line, ",") - 1))
            i = i + 1
            index = index + 1
        Loop Until sr.Peek = -1
        sr.Close()

        For j = 0 To index - 1
            If batchList(1, j) = 1 Then
                combo.Items.Add(batchList(0, j))
            End If
        Next

        combo.SelectedIndex = 0
    End Sub

    Private Function matchpoint(i As Integer, j As Integer) As String

        Dim strTemp As String = ""
        Dim iLine As Integer
        FileOpen(1, "match.csv", OpenMode.Input)
        iLine = 1
        strTemp = LineInput(1)
        Do While Not EOF(1) And iLine < i   '循环读取一行数据
            strTemp = LineInput(1)    '读入一行数据
            iLine = iLine + 1
        Loop

        FileClose(1)    '关闭文件 

        Label2.Text = strTemp

        Dim dash As Integer = 0
        For index = 1 To j
            dash = InStr(dash + 1, strTemp, ",")
        Next

        Dim dash2 As Integer = InStr(dash + 1, strTemp, ",")

        Dim result As String = Mid(strTemp, dash + 1, dash2 - dash - 1)

        If j = 0 Then
            result = Mid(strTemp, 1, dash - 1)
        End If

        'Label1.Text = Mid(strTemp, dash + 1, dash2 - dash - 1)

        Return result

    End Function
    '找到对应的配点

    Private Sub batchShow(num As Integer)

        For index = 1 To 8
            Me.Controls("batch" & index & "_Label").Visible = False
            Me.Controls("batch" & index & "_combobox").Visible = False
        Next

        For index = 1 To num
            Me.Controls("batch" & index & "_Label").Visible = True
            Me.Controls("batch" & index & "_combobox").Visible = True
            formatComboBox(index)
        Next
    End Sub

    Private Sub batch_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles batchQty_ComboBox.SelectedIndexChanged
        batchShow(batchQty_ComboBox.SelectedIndex + 2)
    End Sub

    Private Sub match_Button_Click(sender As Object, e As EventArgs) Handles match_Button.Click

        Dim num As Integer = Me.batchQty_ComboBox.SelectedIndex + 2
        Dim point As Integer = 0
        Dim comboSelect1 As Integer = 0
        Dim comboSelect2 As Integer = 0


        For index = 1 To num - 1
            For j1 = index + 1 To num
                Dim combo As ComboBox = Me.Controls("batch" & index & "_combobox")
                Dim combo2 As ComboBox = Me.Controls("batch" & j1 & "_combobox")
                comboSelect1 = Mid(combo.SelectedItem.ToString, 1, InStr(combo.SelectedItem.ToString, "."))
                comboSelect2 = Mid(combo2.SelectedItem.ToString, 1, InStr(combo2.SelectedItem.ToString, "."))
                point = point + matchpoint(comboSelect1, comboSelect2)
            Next

        Next

        Label1.Text = point

    End Sub
    '计算现有搭配的组合值

    Private Function matchTotalPoint(batchlist() As String) As Integer

        Dim batchNum As Integer = Int(Me.batchQty_ComboBox.SelectedItem.ToString)
        '获取总配料数

        Dim point As Integer = 0

        For i = 0 To batchNum - 2
            For j = i + 1 To batchNum - 1
                point = point + matchpoint(batchlist(i), batchlist(j))
            Next
        Next

        Return point

    End Function
    '获取某种搭配（数量不定）的总分

    Private Sub super_Button_Click(sender As Object, e As EventArgs) Handles super_Button.Click
        Dim num As Integer = Int(Me.batchQty_ComboBox.SelectedItem.ToString)
        '要计算的配菜的总数
        Dim maxPintBatch(num) As Integer
        '用来存储最高值的配方组合
        Dim batchNum As Integer = Me.batch1_ComboBox.Items.Count
        '获取可用配料数

        Dim batchList(batchNum) As String
        '配料列表

        For index = 1 To batchNum
            batchList(index - 1) = Mid(batch1_ComboBox.Items(index - 1).ToString, 1, InStr(batch1_ComboBox.Items(index - 1).ToString, "."))
        Next
        '将可用配料的编号写入配料列表

        Dim tempList(num + 1) As String
        For index = 0 To num
            tempList(index) = 0
        Next
        '初始化要送计算的临时字符串

        Dim matchnum As Integer = Math.Pow(batchNum, num)
        '总共要计算多少次？

        For l = 0 To matchnum
            For x = 0 To num - 1
                Dim temp As Integer = Math.Pow(batchNum, num - x - 1)
                If x = 0 Then
                    tempList(x + 1) = l Mod temp
                    tempList(x) = l \ temp
                Else
                    tempList(x + 1) = tempList(x) Mod temp
                    tempList(x) = tempList(x) \ temp
                End If

            Next
        Next



    End Sub
End Class


