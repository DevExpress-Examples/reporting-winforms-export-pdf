Namespace ReportExportPdfSample
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
			Me.components = New System.ComponentModel.Container()
			Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.pdfCommandBar1 = New DevExpress.XtraPdfViewer.Bars.PdfCommandBar()
			Me.pdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
			Me.pdfFileSaveAsBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem()
			Me.pdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
			Me.pdfFindTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
			Me.pdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
			Me.pdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
			Me.pdfSetPageNumberBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem()
			Me.repositoryItemPageNumberEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit()
			Me.pdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
			Me.pdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
			Me.pdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
			Me.pdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
			Me.pdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
			Me.pdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
			Me.pdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
			Me.pdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
			Me.pdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
			Me.pdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
			Me.pdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
			Me.pdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
			Me.pdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
			Me.pdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
			Me.pdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
			Me.pdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
			Me.pdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.pdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController(Me.components)
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pdfViewer1
			' 
			Me.pdfViewer1.Location = New System.Drawing.Point(12, 132)
			Me.pdfViewer1.MenuManager = Me.barManager1
			Me.pdfViewer1.Name = "pdfViewer1"
			Me.pdfViewer1.Size = New System.Drawing.Size(855, 590)
			Me.pdfViewer1.TabIndex = 0
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.pdfCommandBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.pdfFileOpenBarItem1, Me.pdfFileSaveAsBarItem1, Me.pdfFilePrintBarItem1, Me.pdfFindTextBarItem1, Me.pdfPreviousPageBarItem1, Me.pdfNextPageBarItem1, Me.pdfSetPageNumberBarItem1, Me.pdfZoomOutBarItem1, Me.pdfZoomInBarItem1, Me.pdfExactZoomListBarSubItem1, Me.pdfZoom10CheckItem1, Me.pdfZoom25CheckItem1, Me.pdfZoom50CheckItem1, Me.pdfZoom75CheckItem1, Me.pdfZoom100CheckItem1, Me.pdfZoom125CheckItem1, Me.pdfZoom150CheckItem1, Me.pdfZoom200CheckItem1, Me.pdfZoom400CheckItem1, Me.pdfZoom500CheckItem1, Me.pdfSetActualSizeZoomModeCheckItem1, Me.pdfSetPageLevelZoomModeCheckItem1, Me.pdfSetFitWidthZoomModeCheckItem1, Me.pdfSetFitVisibleZoomModeCheckItem1})
			Me.barManager1.MaxItemId = 24
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPageNumberEdit1})
			' 
			' pdfCommandBar1
			' 
			Me.pdfCommandBar1.Control = Me.pdfViewer1
			Me.pdfCommandBar1.DockCol = 0
			Me.pdfCommandBar1.DockRow = 0
			Me.pdfCommandBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.pdfCommandBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfFileOpenBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfFileSaveAsBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfFilePrintBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfFindTextBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfPreviousPageBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfNextPageBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetPageNumberBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoomOutBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoomInBarItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfExactZoomListBarSubItem1)
			})
			' 
			' pdfFileOpenBarItem1
			' 
			Me.pdfFileOpenBarItem1.Id = 0
			Me.pdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
			Me.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1"
			' 
			' pdfFileSaveAsBarItem1
			' 
			Me.pdfFileSaveAsBarItem1.Id = 1
			Me.pdfFileSaveAsBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
			Me.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1"
			' 
			' pdfFilePrintBarItem1
			' 
			Me.pdfFilePrintBarItem1.Id = 2
			Me.pdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
			Me.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1"
			' 
			' pdfFindTextBarItem1
			' 
			Me.pdfFindTextBarItem1.Id = 3
			Me.pdfFindTextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
			Me.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1"
			' 
			' pdfPreviousPageBarItem1
			' 
			Me.pdfPreviousPageBarItem1.Id = 4
			Me.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1"
			' 
			' pdfNextPageBarItem1
			' 
			Me.pdfNextPageBarItem1.Id = 5
			Me.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1"
			' 
			' pdfSetPageNumberBarItem1
			' 
			Me.pdfSetPageNumberBarItem1.Edit = Me.repositoryItemPageNumberEdit1
			Me.pdfSetPageNumberBarItem1.Id = 6
			Me.pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1"
			' 
			' repositoryItemPageNumberEdit1
			' 
			Me.repositoryItemPageNumberEdit1.AutoHeight = False
			Me.repositoryItemPageNumberEdit1.Mask.EditMask = "########;"
			Me.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1"
			Me.repositoryItemPageNumberEdit1.Orientation = DevExpress.XtraEditors.PagerOrientation.Horizontal
			' 
			' pdfZoomOutBarItem1
			' 
			Me.pdfZoomOutBarItem1.Id = 7
			Me.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1"
			' 
			' pdfZoomInBarItem1
			' 
			Me.pdfZoomInBarItem1.Id = 8
			Me.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1"
			' 
			' pdfExactZoomListBarSubItem1
			' 
			Me.pdfExactZoomListBarSubItem1.Id = 9
			Me.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom10CheckItem1, True),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom25CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom50CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom75CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom100CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom125CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom150CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom200CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom400CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom500CheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetActualSizeZoomModeCheckItem1, True),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetPageLevelZoomModeCheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitWidthZoomModeCheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitVisibleZoomModeCheckItem1)
			})
			Me.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1"
			Me.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
			' 
			' pdfZoom10CheckItem1
			' 
			Me.pdfZoom10CheckItem1.Id = 10
			Me.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1"
			' 
			' pdfZoom25CheckItem1
			' 
			Me.pdfZoom25CheckItem1.Id = 11
			Me.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1"
			' 
			' pdfZoom50CheckItem1
			' 
			Me.pdfZoom50CheckItem1.Id = 12
			Me.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1"
			' 
			' pdfZoom75CheckItem1
			' 
			Me.pdfZoom75CheckItem1.Id = 13
			Me.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1"
			' 
			' pdfZoom100CheckItem1
			' 
			Me.pdfZoom100CheckItem1.Id = 14
			Me.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1"
			' 
			' pdfZoom125CheckItem1
			' 
			Me.pdfZoom125CheckItem1.Id = 15
			Me.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1"
			' 
			' pdfZoom150CheckItem1
			' 
			Me.pdfZoom150CheckItem1.Id = 16
			Me.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1"
			' 
			' pdfZoom200CheckItem1
			' 
			Me.pdfZoom200CheckItem1.Id = 17
			Me.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1"
			' 
			' pdfZoom400CheckItem1
			' 
			Me.pdfZoom400CheckItem1.Id = 18
			Me.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1"
			' 
			' pdfZoom500CheckItem1
			' 
			Me.pdfZoom500CheckItem1.Id = 19
			Me.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1"
			' 
			' pdfSetActualSizeZoomModeCheckItem1
			' 
			Me.pdfSetActualSizeZoomModeCheckItem1.Id = 20
			Me.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1"
			' 
			' pdfSetPageLevelZoomModeCheckItem1
			' 
			Me.pdfSetPageLevelZoomModeCheckItem1.Id = 21
			Me.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1"
			' 
			' pdfSetFitWidthZoomModeCheckItem1
			' 
			Me.pdfSetFitWidthZoomModeCheckItem1.Id = 22
			Me.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1"
			' 
			' pdfSetFitVisibleZoomModeCheckItem1
			' 
			Me.pdfSetFitVisibleZoomModeCheckItem1.Id = 23
			Me.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(879, 24)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 734)
			Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(879, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
			Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 710)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(879, 24)
			Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 710)
			' 
			' pdfBarController1
			' 
			Me.pdfBarController1.BarItems.Add(Me.pdfFileOpenBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfFileSaveAsBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfFilePrintBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfFindTextBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfPreviousPageBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfNextPageBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetPageNumberBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoomOutBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoomInBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom10CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom25CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom50CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom75CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom100CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom125CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom150CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom200CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom400CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom500CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetActualSizeZoomModeCheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetPageLevelZoomModeCheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetFitWidthZoomModeCheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetFitVisibleZoomModeCheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfExactZoomListBarSubItem1)
			Me.pdfBarController1.Control = Me.pdfViewer1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12F)
			Me.simpleButton1.Appearance.Options.UseFont = True
			Me.simpleButton1.Location = New System.Drawing.Point(12, 58)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(187, 42)
			Me.simpleButton1.TabIndex = 5
			Me.simpleButton1.Text = "Export Report to PDF"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(879, 734)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.pdfViewer1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Export Report to PDF"
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private pdfCommandBar1 As DevExpress.XtraPdfViewer.Bars.PdfCommandBar
		Private pdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
		Private pdfFileSaveAsBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem
		Private pdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
		Private pdfFindTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem
		Private pdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
		Private pdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
		Private pdfSetPageNumberBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem
		Private repositoryItemPageNumberEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit
		Private pdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
		Private pdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
		Private pdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
		Private pdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
		Private pdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
		Private pdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
		Private pdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
		Private pdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
		Private pdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
		Private pdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
		Private pdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
		Private pdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
		Private pdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
		Private pdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
		Private pdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
		Private pdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
		Private pdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private pdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

