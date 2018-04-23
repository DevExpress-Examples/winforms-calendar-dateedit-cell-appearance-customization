Namespace Calendar_CellStyleProvider
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.calendarControl1 = New DevExpress.XtraEditors.Controls.CalendarControl()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            DirectCast(Me.calendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.calendarControl1.Location = New System.Drawing.Point(227, 27)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.Size = New System.Drawing.Size(244, 222)
            Me.calendarControl1.TabIndex = 0
            ' 
            ' dateEdit1
            ' 
            Me.dateEdit1.EditValue = Nothing
            Me.dateEdit1.Location = New System.Drawing.Point(12, 24)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Size = New System.Drawing.Size(194, 20)
            Me.dateEdit1.TabIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(626, 475)
            Me.Controls.Add(Me.dateEdit1)
            Me.Controls.Add(Me.calendarControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.calendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private calendarControl1 As DevExpress.XtraEditors.Controls.CalendarControl
        Private dateEdit1 As DevExpress.XtraEditors.DateEdit
    End Class
End Namespace

