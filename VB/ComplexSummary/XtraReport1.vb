Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace ComplexSummary
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Public avgPrice As Double
		Public sumUnits As Double
		Public total As Double

		Private Sub xrLabel5_SummaryCalculated(ByVal sender As Object, ByVal e As TextFormatEventArgs) Handles xrLabel5.SummaryCalculated
			avgPrice += Convert.ToDouble(e.Value)
		End Sub

		Private Sub xrLabel6_SummaryCalculated(ByVal sender As Object, ByVal e As TextFormatEventArgs) Handles xrLabel6.SummaryCalculated
			sumUnits += Convert.ToDouble(e.Value)
		End Sub

		Private Sub xrLabel7_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrLabel7.PrintOnPage
			total = avgPrice + sumUnits
			CType(sender, XRLabel).Text = total.ToString("#,#")
		End Sub

	End Class
End Namespace
