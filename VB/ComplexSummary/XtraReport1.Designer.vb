Imports Microsoft.VisualBasic
Imports System
Namespace ComplexSummary
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary3 As New DevExpress.XtraReports.UI.XRSummary()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New ComplexSummary.nwindDataSet()
			Me.productsTableAdapter = New ComplexSummary.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4, Me.xrLabel3, Me.xrLabel2})
			Me.Detail.HeightF = 23F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
			Me.xrLabel4.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(361.9167F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.StylePriority.UseTextAlignment = False
			Me.xrLabel4.Text = "xrLabel4"
			Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
			Me.xrLabel3.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(249.4167F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.Text = "xrLabel3"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrLabel2.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(239.4167F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 48F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 49F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' xrLabel7
			' 
			Me.xrLabel7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(230))))), (CInt(Fix((CByte(230))))))
			Me.xrLabel7.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(480.6667F, 0F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel7.StylePriority.UseBackColor = False
			Me.xrLabel7.StylePriority.UseFont = False
			Me.xrLabel7.StylePriority.UseTextAlignment = False
			xrSummary1.FormatString = "{0:$0.00}"
			Me.xrLabel7.Summary = xrSummary1
			Me.xrLabel7.Text = "xrLabel7"
			Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
'			Me.xrLabel7.PrintOnPage += New DevExpress.XtraReports.UI.PrintOnPageEventHandler(Me.xrLabel7_PrintOnPage);
			' 
			' xrLabel5
			' 
			Me.xrLabel5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
			Me.xrLabel5.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(250.4584F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel5.StylePriority.UseBackColor = False
			Me.xrLabel5.StylePriority.UseFont = False
			Me.xrLabel5.StylePriority.UseTextAlignment = False
			xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrLabel5.Summary = xrSummary2
			Me.xrLabel5.Text = "xrLabel3"
			Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
'			Me.xrLabel5.SummaryCalculated += New DevExpress.XtraReports.UI.TextFormatEventHandler(Me.xrLabel5_SummaryCalculated);
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255))))))
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
			Me.xrLabel6.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(361.9167F, 0F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel6.StylePriority.UseBackColor = False
			Me.xrLabel6.StylePriority.UseFont = False
			Me.xrLabel6.StylePriority.UseTextAlignment = False
			xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrLabel6.Summary = xrSummary3
			Me.xrLabel6.Text = "xrLabel4"
			Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
'			Me.xrLabel6.SummaryCalculated += New DevExpress.XtraReports.UI.TextFormatEventHandler(Me.xrLabel6_SummaryCalculated);
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5, Me.xrLabel6, Me.xrLabel7})
			Me.ReportFooter.HeightF = 70F
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Margins = New System.Drawing.Printing.Margins(50, 100, 48, 49)
			Me.Version = "10.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
	End Class
End Namespace
