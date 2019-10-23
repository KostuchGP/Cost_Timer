Imports System.Globalization
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Public ver As String = "1.1"
    Public excelSheets As Excel.Sheets
    Dim StyleNaglowekModulu As Excel.Style
    Dim z1 As Date 'zmienna 1 czas startu
    Dim z2 As Date 'zmienna 2 czas stopu
    Dim z3 As Integer = 0 'zmienna to liczenia wystąpienia
    Dim z4 As Boolean = False 'zmienna sprawdzanie czy start został zresetowany

    'Definicja tablicy do przechowywania danych godzin
    Public zestawienie(6, z3) As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        txtBoxConsole.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim date1 As DateTime = DateTime.Now
        Label3.Text = DateTime.Now.ToString()
        If date1.Hour.ToString = "16" Then
            btnendwork_Click(sender, e)
        End If
    End Sub

    Private Sub btnendwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnendwork.Click
        Dim Excel As Object = CreateObject("Excel.Application")
        Dim excelApp As Excel.Application = New Excel.Application()
        Dim excelBook As Excel.Workbook
        Dim strPath As String = "C:\Godziny.xlsm"
        excelBook = excelApp.Workbooks.Open(strPath, 0, False, 5, _
            System.Reflection.Missing.Value, System.Reflection.Missing.Value, _
            False, System.Reflection.Missing.Value, System.Reflection.Missing.Value, _
            True, False, System.Reflection.Missing.Value, False)
        excelSheets = excelBook.Sheets
        Dim excelSheet As Excel.Worksheet = excelSheets(1)

        Dim excelRange As Excel.Range = excelSheet.UsedRange

        Dim myreccnt As Long

        myreccnt = GetFilteredPivotRowCount("CZAS", "A:A")

        excelSheet.Cells(myreccnt, 1) = DateTime.Now.ToString("yyyy-MM-dd")
        excelSheet.Range("A" & myreccnt).Font.Bold = True
        myreccnt += 1

        For i = 0 To z3
            'For j = 0 To LvwMain.Items(i).SubItems.Count - 1
            'excelSheet.Cells(i + myreccnt, j + 2) = LvwMain.Items(i).SubItems(j).Text
            excelSheet.Cells(i + myreccnt, 1) = zestawienie(0, i)
            excelSheet.Cells(i + myreccnt, 4) = zestawienie(3, i)
            excelSheet.Cells(i + myreccnt, 7) = zestawienie(6, i)

            '   If i = 0 And j = 0 Then
            '        excelSheet.Range("A" & myreccnt).Font.Bold = True
            'excelSheet.Range("A" & myreccnt).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)
            '     End If
            '   Next
        Next
        excelBook.Save()
        excelBook.Close()
        excelApp.Quit()

        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
            Return
        End If

        Me.Close()
    End Sub
    Function GetFilteredPivotRowCount(ByVal sheetname As String, ByVal cntrange As String) As Long
        Dim reccnt As Long

        reccnt = excelSheets(sheetname).Range(cntrange).SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible).SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeConstants).Count + 1

        GetFilteredPivotRowCount = reccnt
        'MsgBox(GetFilteredPivotRowCount)
    End Function

    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        Wpis_Minutes()
        Wpis_Start()
    End Sub

    Private Sub Wpis_Start()
        If ComBox1.Text = Nothing Then Exit Sub
        If txtBox1.Text = Nothing Then Exit Sub
        If z4 = True Then Exit Sub
        zestawienie(0, z3) = ComBox1.Text
        zestawienie(3, z3) = txtBox1.Text
        z3 += 1
        z1 = DateTime.Now
        z4 = True
        ReDim Preserve zestawienie(6, z3)
    End Sub

    Function calculationMinutes(ByVal z1 As Date, ByVal z2 As Date) As String
        Dim result As String
        Dim cal As TimeSpan = z2 - z1
        Dim a As Integer
        a = cal.TotalMinutes
        result = a.ToString
        Return result
    End Function

    Private Sub btnstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop.Click
        Wpis_Minutes()
    End Sub

    Private Sub txtBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Wpis_Minutes()
            Wpis_Start()
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Wpis_Minutes()
        If ComBox1.Text = Nothing Then Exit Sub
        If txtBox1.Text = Nothing Then Exit Sub
        If z3 = 0 Then
            txtBoxConsole.Text &= Environment.NewLine & "Naliczanie czasu pracy rozpoczęte..."
            Exit Sub
        End If
        If z4 = False Then Exit Sub
        z2 = DateTime.Now
        zestawienie(6, z3 - 1) = calculationMinutes(z1, z2)
        z4 = False
        txtBoxConsole.Text &= Environment.NewLine & zestawienie(0, z3 - 1) & Microsoft.VisualBasic.Chr(32) & zestawienie(3, z3 - 1) & Microsoft.VisualBasic.Chr(32) & zestawienie(6, z3 - 1)
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Version: 1.00" & vbCrLf & "Author: Grzegorz Pawęzowski" & vbCrLf & "License: All right reserved Grzegorz Pawezowski 2019", vbInformation, "Information")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim url As String = "http://http://www.sda.org.pl/"
        Process.Start(url)
    End Sub


End Class
