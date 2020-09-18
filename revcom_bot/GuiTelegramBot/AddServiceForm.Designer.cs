namespace GuiTelegramBot
{
    partial class AddServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiceForm));
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.Button_Accept_Window = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonAddServiceDate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDeleteService = new DevExpress.XtraBars.BarButtonItem();
            this.Edit_Service_Date = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barBtnAddDish = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteDish = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGrpServiceEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGrpServiceDate = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Panel_Grid_Cntrl = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grid_Cntrl_Dates = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlDishesInService = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.Button_Cancel_Window = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.Panel_Grid_Cntrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cntrl_Dates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDishesInService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.Button_Accept_Window);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 499);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1023, 27);
            // 
            // Button_Accept_Window
            // 
            this.Button_Accept_Window.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.Button_Accept_Window.Caption = "Accept";
            this.Button_Accept_Window.Id = 11;
            this.Button_Accept_Window.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Accept_Window.ImageOptions.SvgImage")));
            this.Button_Accept_Window.Name = "Button_Accept_Window";
            this.Button_Accept_Window.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Button_Accept_Window_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonAddServiceDate,
            this.barButtonDeleteService,
            this.Button_Accept_Window,
            this.Edit_Service_Date,
            this.barBtnAddDish,
            this.barBtnDeleteDish,
            this.barEditItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 27;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1,
            this.repositoryItemRadioGroup1,
            this.repositoryItemRadioGroup2,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemGridLookUpEdit1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1023, 100);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonAddServiceDate
            // 
            this.barButtonAddServiceDate.Caption = "Add service date";
            this.barButtonAddServiceDate.Id = 4;
            this.barButtonAddServiceDate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonAddServiceDate.ImageOptions.SvgImage")));
            this.barButtonAddServiceDate.Name = "barButtonAddServiceDate";
            this.barButtonAddServiceDate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonAddServiceDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonDeleteService
            // 
            this.barButtonDeleteService.Caption = "Delete service from list";
            this.barButtonDeleteService.Id = 5;
            this.barButtonDeleteService.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonDeleteService.ImageOptions.SvgImage")));
            this.barButtonDeleteService.Name = "barButtonDeleteService";
            this.barButtonDeleteService.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonDeleteService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDeleteService_ItemClick);
            // 
            // Edit_Service_Date
            // 
            this.Edit_Service_Date.Caption = "Service Date";
            this.Edit_Service_Date.Edit = this.repositoryItemDateEdit1;
            this.Edit_Service_Date.EditWidth = 100;
            this.Edit_Service_Date.Id = 23;
            this.Edit_Service_Date.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Edit_Service_Date.ImageOptions.SvgImage")));
            this.Edit_Service_Date.Name = "Edit_Service_Date";
            this.Edit_Service_Date.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemDateEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barBtnAddDish
            // 
            this.barBtnAddDish.Caption = "Add dish";
            this.barBtnAddDish.Id = 24;
            this.barBtnAddDish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnAddDish.ImageOptions.SvgImage")));
            this.barBtnAddDish.Name = "barBtnAddDish";
            this.barBtnAddDish.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddDish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddDish_ItemClick);
            // 
            // barBtnDeleteDish
            // 
            this.barBtnDeleteDish.Caption = "Delete Dish";
            this.barBtnDeleteDish.Id = 25;
            this.barBtnDeleteDish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDeleteDish.ImageOptions.SvgImage")));
            this.barBtnDeleteDish.Name = "barBtnDeleteDish";
            this.barBtnDeleteDish.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDeleteDish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteDish_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemGridLookUpEdit1;
            this.barEditItem1.Id = 26;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGrpServiceEdit,
            this.PageGrpServiceDate});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // PageGrpServiceEdit
            // 
            this.PageGrpServiceEdit.ItemLinks.Add(this.Edit_Service_Date);
            this.PageGrpServiceEdit.ItemLinks.Add(this.barButtonAddServiceDate);
            this.PageGrpServiceEdit.ItemLinks.Add(this.barButtonDeleteService);
            this.PageGrpServiceEdit.Name = "PageGrpServiceEdit";
            this.PageGrpServiceEdit.Text = "Servie edit panel";
            // 
            // PageGrpServiceDate
            // 
            this.PageGrpServiceDate.ItemLinks.Add(this.barBtnAddDish);
            this.PageGrpServiceDate.ItemLinks.Add(this.barBtnDeleteDish);
            this.PageGrpServiceDate.Name = "PageGrpServiceDate";
            this.PageGrpServiceDate.Text = "Service date control";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // Panel_Grid_Cntrl
            // 
            this.Panel_Grid_Cntrl.Controls.Add(this.splitContainer1);
            this.Panel_Grid_Cntrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Grid_Cntrl.Location = new System.Drawing.Point(0, 100);
            this.Panel_Grid_Cntrl.Name = "Panel_Grid_Cntrl";
            this.Panel_Grid_Cntrl.Size = new System.Drawing.Size(1023, 399);
            this.Panel_Grid_Cntrl.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Grid_Cntrl_Dates);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlDishesInService);
            this.splitContainer1.Size = new System.Drawing.Size(1023, 399);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 0;
            // 
            // Grid_Cntrl_Dates
            // 
            this.Grid_Cntrl_Dates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Cntrl_Dates.Location = new System.Drawing.Point(0, 0);
            this.Grid_Cntrl_Dates.MainView = this.gridView2;
            this.Grid_Cntrl_Dates.MenuManager = this.ribbonControl1;
            this.Grid_Cntrl_Dates.Name = "Grid_Cntrl_Dates";
            this.Grid_Cntrl_Dates.Size = new System.Drawing.Size(235, 399);
            this.Grid_Cntrl_Dates.TabIndex = 1;
            this.Grid_Cntrl_Dates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDateId,
            this.gridColumnDate});
            this.gridView2.GridControl = this.Grid_Cntrl_Dates;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // gridColumnDateId
            // 
            this.gridColumnDateId.FieldName = "Id";
            this.gridColumnDateId.Name = "gridColumnDateId";
            this.gridColumnDateId.OptionsColumn.AllowEdit = false;
            this.gridColumnDateId.OptionsColumn.AllowFocus = false;
            this.gridColumnDateId.Visible = true;
            this.gridColumnDateId.VisibleIndex = 0;
            // 
            // gridColumnDate
            // 
            this.gridColumnDate.FieldName = "Service_Dates";
            this.gridColumnDate.Name = "gridColumnDate";
            this.gridColumnDate.OptionsColumn.AllowEdit = false;
            this.gridColumnDate.OptionsColumn.AllowFocus = false;
            this.gridColumnDate.Visible = true;
            this.gridColumnDate.VisibleIndex = 1;
            // 
            // gridControlDishesInService
            // 
            this.gridControlDishesInService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDishesInService.Location = new System.Drawing.Point(0, 0);
            this.gridControlDishesInService.MainView = this.gridView1;
            this.gridControlDishesInService.MenuManager = this.ribbonControl1;
            this.gridControlDishesInService.Name = "gridControlDishesInService";
            this.gridControlDishesInService.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlDishesInService.Size = new System.Drawing.Size(784, 399);
            this.gridControlDishesInService.TabIndex = 0;
            this.gridControlDishesInService.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnDescription,
            this.gridColumnPrice,
            this.gridColumnPhoto});
            this.gridView1.GridControl = this.gridControlDishesInService;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 50;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 189;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Description";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.OptionsColumn.AllowEdit = false;
            this.gridColumnDescription.OptionsColumn.AllowFocus = false;
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 1;
            this.gridColumnDescription.Width = 354;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.Caption = "Price";
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 2;
            this.gridColumnPrice.Width = 137;
            // 
            // gridColumnPhoto
            // 
            this.gridColumnPhoto.Caption = "Photo";
            this.gridColumnPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumnPhoto.FieldName = "Photo";
            this.gridColumnPhoto.Name = "gridColumnPhoto";
            this.gridColumnPhoto.OptionsColumn.AllowEdit = false;
            this.gridColumnPhoto.OptionsColumn.AllowFocus = false;
            this.gridColumnPhoto.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumnPhoto.Visible = true;
            this.gridColumnPhoto.VisibleIndex = 3;
            this.gridColumnPhoto.Width = 79;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // Button_Cancel_Window
            // 
            this.Button_Cancel_Window.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.Button_Cancel_Window.Caption = "Cancel";
            this.Button_Cancel_Window.Id = 12;
            this.Button_Cancel_Window.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Button_Cancel_Window.ImageOptions.SvgImage")));
            this.Button_Cancel_Window.Name = "Button_Cancel_Window";
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 526);
            this.Controls.Add(this.Panel_Grid_Cntrl);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Name = "AddServiceForm";
            this.Text = "AddServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.Panel_Grid_Cntrl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cntrl_Dates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDishesInService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGrpServiceEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonAddServiceDate;
        private DevExpress.XtraBars.BarButtonItem barButtonDeleteService;
        private System.Windows.Forms.Panel Panel_Grid_Cntrl;
        private DevExpress.XtraBars.BarButtonItem Button_Accept_Window;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGrpServiceDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraBars.BarEditItem Edit_Service_Date;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarButtonItem Button_Cancel_Window;
        private DevExpress.XtraBars.BarButtonItem barBtnAddDish;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteDish;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl Grid_Cntrl_Dates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControlDishesInService;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
    }
}