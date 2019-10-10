Imports System.Globalization
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Public ver As String = "1.1"
    Public excelSheets As Excel.Sheets
    Dim StyleNaglowekModulu As Excel.Style

    Public Zestawienie = New 

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay.ToString("h:mm:ss tt")
        Label3.Text = DateTime.Now.ToString()
    End Sub

    Private Sub btnendwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnendwork.Click
        Dim Excel As Object = CreateObject("Excel.Application")
        Dim excelApp As Excel.Application = New Excel.Application()
        Dim excelBook As Excel.Workbook
        Dim strPath As String = "C:\Wzor.xlsm"
        excelBook = excelApp.Workbooks.Open(strPath, 0, False, 5, _
            System.Reflection.Missing.Value, System.Reflection.Missing.Value, _
            False, System.Reflection.Missing.Value, System.Reflection.Missing.Value, _
            True, False, System.Reflection.Missing.Value, False)
        excelSheets = excelBook.Sheets
        Dim excelSheet As Excel.Worksheet = excelSheets(1)

        Dim excelRange As Excel.Range = excelSheet.UsedRange

        Dim myreccnt As Long

        myreccnt = GetFilteredPivotRowCount("KALKULACJA", "B:B")


        For i = 0 To LvwMain.Items.Count - 1
            For j = 0 To LvwMain.Items(i).SubItems.Count - 1
                excelSheet.Cells(i + myreccnt, j + 2) = LvwMain.Items(i).SubItems(j).Text

                If i = 0 And j = 0 Then
                    excelSheet.Range("B" & myreccnt).Font.Bold = True
                    excelSheet.Range("B" & myreccnt).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)
                End If
            Next
        Next
        txtSuma.Text = excelSheet.Range("P4").Value
        excelBook.SaveCopyAs()
        excelBook.Close()
        excelApp.Quit()

        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
            Return
        End If

    End Sub
    Function GetFilteredPivotRowCount(ByVal sheetname As String, ByVal cntrange As String) As Long

        Dim reccnt As Long

        reccnt = excelSheets(sheetname).Range(cntrange).SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible).SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeConstants).Count + 1

        GetFilteredPivotRowCount = reccnt
        'MsgBox(GetFilteredPivotRowCount)

    End Function
End Class
