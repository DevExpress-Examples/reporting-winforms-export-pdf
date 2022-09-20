Namespace ReportExportPdfSample
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
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table4 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.table1 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table2 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table3 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "ProductID"
			table4.Name = "CategoryProducts"
			columnExpression1.Table = table4
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "SupplierID"
			columnExpression2.Table = table4
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "ProductName"
			columnExpression3.Table = table4
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "CategoryName"
			columnExpression4.Table = table4
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "Picture"
			columnExpression5.Table = table4
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "Description"
			columnExpression6.Table = table4
			column6.Expression = columnExpression6
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Name = "CategoryProducts"
			selectQuery1.Tables.Add(table4)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pageInfo1, Me.pageInfo2})
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.pictureBox1, Me.table1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 78.99998F
			Me.GroupHeader1.Level = 1
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table2})
			Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader2.HeightF = 28F
			Me.GroupHeader2.Level = 2
			Me.GroupHeader2.Name = "GroupHeader2"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table3})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label2})
			Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
			Me.GroupFooter1.HeightF = 6F
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' pageInfo1
			' 
			Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.pageInfo1.Name = "pageInfo1"
			Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.pageInfo1.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo1.StyleName = "PageInfo"
			' 
			' pageInfo2
			' 
			Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
			Me.pageInfo2.Name = "pageInfo2"
			Me.pageInfo2.SizeF = New System.Drawing.SizeF(325F, 23F)
			Me.pageInfo2.StyleName = "PageInfo"
			Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.pageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' label1
			' 
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(650F, 24.19433F)
			Me.label1.StyleName = "Title"
			Me.label1.Text = "Products"
			' 
			' table1
			' 
			Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
			Me.table1.Name = "table1"
			Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
			Me.table1.SizeF = New System.Drawing.SizeF(362.3111F, 25F)
			' 
			' tableRow1
			' 
			Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2})
			Me.tableRow1.Name = "tableRow1"
			Me.tableRow1.Weight = 1R
			' 
			' tableCell1
			' 
			Me.tableCell1.Name = "tableCell1"
			Me.tableCell1.StyleName = "GroupCaption1"
			Me.tableCell1.Text = "CATEGORY NAME"
			Me.tableCell1.Weight = 0.16900812002328727R
			' 
			' tableCell2
			' 
			Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
			Me.tableCell2.Name = "tableCell2"
			Me.tableCell2.StyleName = "GroupData1"
			Me.tableCell2.Weight = 0.38839360683263058R
			' 
			' table2
			' 
			Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table2.Name = "table2"
			Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2})
			Me.table2.SizeF = New System.Drawing.SizeF(362.3111F, 28F)
			' 
			' tableRow2
			' 
			Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell3, Me.tableCell4})
			Me.tableRow2.Name = "tableRow2"
			Me.tableRow2.Weight = 1R
			' 
			' tableCell3
			' 
			Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell3.Name = "tableCell3"
			Me.tableCell3.StyleName = "DetailCaption1"
			Me.tableCell3.StylePriority.UseBorders = False
			Me.tableCell3.StylePriority.UseTextAlignment = False
			Me.tableCell3.Text = "Product ID"
			Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell3.Weight = 0.24509199876051682R
			' 
			' tableCell4
			' 
			Me.tableCell4.Name = "tableCell4"
			Me.tableCell4.StyleName = "DetailCaption1"
			Me.tableCell4.Text = "Product Name"
			Me.tableCell4.Weight = 0.31230968768780049R
			' 
			' table3
			' 
			Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table3.Name = "table3"
			Me.table3.OddStyleName = "DetailData3_Odd"
			Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow3})
			Me.table3.SizeF = New System.Drawing.SizeF(362.3111F, 25F)
			' 
			' tableRow3
			' 
			Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell7, Me.tableCell8})
			Me.tableRow3.Name = "tableRow3"
			Me.tableRow3.Weight = 11.5R
			' 
			' tableCell7
			' 
			Me.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductID]")})
			Me.tableCell7.Name = "tableCell7"
			Me.tableCell7.StyleName = "DetailData1"
			Me.tableCell7.StylePriority.UseBorders = False
			Me.tableCell7.StylePriority.UseTextAlignment = False
			Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell7.Weight = 0.24509199876051682R
			' 
			' tableCell8
			' 
			Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.tableCell8.Name = "tableCell8"
			Me.tableCell8.StyleName = "DetailData1"
			Me.tableCell8.Weight = 0.31230968768780049R
			' 
			' pictureBox1
			' 
			Me.pictureBox1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
			Me.pictureBox1.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
			Me.pictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
			Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 26.99999F)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.SizeF = New System.Drawing.SizeF(115.0078F, 21.50644F)
			Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' label2
			' 
			Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.label2.Name = "label2"
			Me.label2.SizeF = New System.Drawing.SizeF(650F, 2.08F)
			Me.label2.StyleName = "GroupFooterBackground3"
			Me.label2.StylePriority.UseBorders = False
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Arial", 14.25F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' GroupCaption1
			' 
			Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(162)))), (CInt((CByte(162)))))
			Me.GroupCaption1.BorderColor = System.Drawing.Color.White
			Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupCaption1.BorderWidth = 2F
			Me.GroupCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupCaption1.Name = "GroupCaption1"
			Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupData1
			' 
			Me.GroupData1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(162)))), (CInt((CByte(162)))))
			Me.GroupData1.BorderColor = System.Drawing.Color.White
			Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupData1.BorderWidth = 2F
			Me.GroupData1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupData1.ForeColor = System.Drawing.Color.White
			Me.GroupData1.Name = "GroupData1"
			Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailCaption1
			' 
			Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.DetailCaption1.BorderColor = System.Drawing.Color.White
			Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailCaption1.BorderWidth = 2F
			Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption1.ForeColor = System.Drawing.Color.White
			Me.DetailCaption1.Name = "DetailCaption1"
			Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData1
			' 
			Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailData1.BorderWidth = 2F
			Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData1.ForeColor = System.Drawing.Color.Black
			Me.DetailData1.Name = "DetailData1"
			Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupFooterBackground3
			' 
			Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(137)))), (CInt((CByte(137)))), (CInt((CByte(137)))))
			Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
			Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupFooterBackground3.BorderWidth = 2F
			Me.GroupFooterBackground3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
			Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			' 
			' xrLabel1
			' 
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 53.99997F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(296.0498F, 25F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.Detail, Me.GroupFooter1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "CategoryProducts"
			Me.DataSource = Me.sqlDataSource1
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.PageInfo})
			Me.Version = "22.1"
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private label1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private pictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private table1 As DevExpress.XtraReports.UI.XRTable
		Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private table2 As DevExpress.XtraReports.UI.XRTable
		Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private table3 As DevExpress.XtraReports.UI.XRTable
		Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private label2 As DevExpress.XtraReports.UI.XRLabel
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupData1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
