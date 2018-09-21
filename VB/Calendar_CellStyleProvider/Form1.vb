Imports DevExpress.Utils
Imports DevExpress.Utils.Design
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Calendar_CellStyleProvider
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            calendarControl1.DateTime = New Date(2016, 12, 31)
            dateEdit1.DateTime = calendarControl1.DateTime
            calendarControl1.CellStyleProvider = New CustomCellStyleProvider()
            dateEdit1.Properties.CellStyleProvider = calendarControl1.CellStyleProvider

            Dim cb As New ContextButton() With {.Alignment = ContextItemAlignment.TopNear, .Visibility=ContextItemVisibility.Hidden}
            calendarControl1.CellSize = New Size(50, 50)
            calendarControl1.ContextButtons.Add(cb)
            AddHandler calendarControl1.ContextButtonCustomize, AddressOf CalendarControl1_ContextButtonCustomize
        End Sub

        Private Sub CalendarControl1_ContextButtonCustomize(ByVal sender As Object, ByVal e As CalendarContextButtonCustomizeEventArgs)
            Dim holidayText As String = Nothing
            If Holidays.IsHoliday(e.Cell.Date, holidayText) Then
                e.Item.Glyph = My.Resources.Party
                e.Item.Visibility = ContextItemVisibility.Visible
                e.Item.ToolTip = holidayText
                e.Item.ShowToolTips = True
            End If
        End Sub
    End Class


    Public NotInheritable Class Holidays

        Private Sub New()
        End Sub

        Public Shared Function IsHoliday(ByVal dt As Date, <System.Runtime.InteropServices.Out()> ByRef holidayText As String) As Boolean
            holidayText = ""
            'New Year's Day
            If dt.Day = 1 AndAlso dt.Month = 1 Then
                holidayText = "New Year's Day"
            End If
            'Independence Day
            If dt.Day = 4 AndAlso dt.Month = 7 Then
                holidayText = "Independence Day"
            End If
            'Veterans Day
            If dt.Day = 11 AndAlso dt.Month = 11 Then
                holidayText = "Veterans Day"
            End If
            'Christmas
            If dt.Day = 25 AndAlso dt.Month = 12 Then
                holidayText = "Christmas"
            End If
            Return Not String.IsNullOrEmpty(holidayText)
        End Function
    End Class

    Public Class CustomCellStyleProvider
        Implements ICalendarCellStyleProvider

        Shared font As Font
        Public Sub UpdateAppearance(ByVal cell As CalendarCellStyle) Implements ICalendarCellStyleProvider.UpdateAppearance
            Dim holidayText As String = Nothing
            If Holidays.IsHoliday(cell.Date, holidayText) Then
                cell.Appearance.ForeColor = Color.Yellow
                If font Is Nothing Then
                    font = New Font(cell.Appearance.Font, FontStyle.Bold)
                End If
                cell.Appearance.Font = font
                If cell.Active Then
                    cell.Appearance.BackColor = Color.HotPink
                Else
                    cell.Appearance.BackColor = Color.LightPink
                End If
            End If
        End Sub
    End Class
End Namespace
