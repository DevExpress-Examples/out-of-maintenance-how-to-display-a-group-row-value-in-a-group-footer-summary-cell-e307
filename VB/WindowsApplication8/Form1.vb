Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication8
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			gridControl1.DataSource = DataHelper.CreateTable()
		End Sub

		Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gridView1.CustomSummaryCalculate
			If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize AndAlso DirectCast(e.Item, GridGroupSummaryItem).Tag.Equals(1) Then
				e.TotalValue = (TryCast(sender, GridView)).GetGroupRowValue(e.RowHandle)
			End If
		End Sub

	End Class
End Namespace