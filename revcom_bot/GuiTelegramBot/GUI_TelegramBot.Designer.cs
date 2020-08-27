namespace GuiTelegramBot
{
    partial class GUI_TelegramBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TelegramBot));
            this.ribbonControlDishes = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonAddDish = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEditDish = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRemoveDish = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonService = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDishesOperationsMngr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupServiceManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dishesGrid = new DevExpress.XtraGrid.GridControl();
            this.dishesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDishName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnDishPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDishPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlDishes)).BeginInit();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDishes
            // 
            this.ribbonControlDishes.ExpandCollapseItem.Id = 0;
            this.ribbonControlDishes.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlDishes.ExpandCollapseItem,
            this.ribbonControlDishes.SearchEditItem,
            this.barButtonAddDish,
            this.barButtonEditDish,
            this.barButtonRemoveDish,
            this.barButtonService});
            this.ribbonControlDishes.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlDishes.MaxItemId = 5;
            this.ribbonControlDishes.Name = "ribbonControlDishes";
            this.ribbonControlDishes.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControlDishes.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControlDishes.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControlDishes.Size = new System.Drawing.Size(1139, 100);
            this.ribbonControlDishes.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonAddDish
            // 
            this.barButtonAddDish.Caption = "Add";
            this.barButtonAddDish.Id = 1;
            this.barButtonAddDish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonAddDish.ImageOptions.SvgImage")));
            this.barButtonAddDish.Name = "barButtonAddDish";
            this.barButtonAddDish.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonAddDish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAddDish_ItemClick);
            // 
            // barButtonEditDish
            // 
            this.barButtonEditDish.Caption = "Edit";
            this.barButtonEditDish.Id = 2;
            this.barButtonEditDish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonEditDish.ImageOptions.SvgImage")));
            this.barButtonEditDish.Name = "barButtonEditDish";
            this.barButtonEditDish.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonEditDish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonEditDish_ItemClick);
            // 
            // barButtonRemoveDish
            // 
            this.barButtonRemoveDish.Caption = "Remove";
            this.barButtonRemoveDish.Id = 3;
            this.barButtonRemoveDish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonRemoveDish.ImageOptions.SvgImage")));
            this.barButtonRemoveDish.Name = "barButtonRemoveDish";
            this.barButtonRemoveDish.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonService
            // 
            this.barButtonService.Caption = "Service";
            this.barButtonService.Id = 4;
            this.barButtonService.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonService.ImageOptions.SvgImage")));
            this.barButtonService.Name = "barButtonService";
            this.barButtonService.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupDishesOperationsMngr,
            this.ribbonPageGroupServiceManager});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroupDishesOperationsMngr
            // 
            this.ribbonPageGroupDishesOperationsMngr.ItemLinks.Add(this.barButtonAddDish);
            this.ribbonPageGroupDishesOperationsMngr.ItemLinks.Add(this.barButtonEditDish);
            this.ribbonPageGroupDishesOperationsMngr.ItemLinks.Add(this.barButtonRemoveDish);
            this.ribbonPageGroupDishesOperationsMngr.Name = "ribbonPageGroupDishesOperationsMngr";
            this.ribbonPageGroupDishesOperationsMngr.Text = "Dishes Panel";
            // 
            // ribbonPageGroupServiceManager
            // 
            this.ribbonPageGroupServiceManager.AllowTextClipping = false;
            this.ribbonPageGroupServiceManager.ItemLinks.Add(this.barButtonService);
            this.ribbonPageGroupServiceManager.Name = "ribbonPageGroupServiceManager";
            this.ribbonPageGroupServiceManager.Text = "Service Panel";
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dishesGrid);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(0, 100);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1139, 548);
            this.panelTable.TabIndex = 1;
            // 
            // dishesGrid
            // 
            this.dishesGrid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.dishesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishesGrid.Location = new System.Drawing.Point(0, 0);
            this.dishesGrid.MainView = this.dishesGridView;
            this.dishesGrid.MenuManager = this.ribbonControlDishes;
            this.dishesGrid.Name = "dishesGrid";
            this.dishesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit,
            this.repositoryItemMemoEdit});
            this.dishesGrid.Size = new System.Drawing.Size(1139, 548);
            this.dishesGrid.TabIndex = 0;
            this.dishesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dishesGridView});
            // 
            // dishesGridView
            // 
            this.dishesGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dishesGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dishesGridView.Appearance.Row.Options.UseTextOptions = true;
            this.dishesGridView.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.dishesGridView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dishesGridView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.dishesGridView.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dishesGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.dishesGridView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dishesGridView.AppearancePrint.Row.Options.UseTextOptions = true;
            this.dishesGridView.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dishesGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dishesGridView.ColumnPanelRowHeight = 10;
            this.dishesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDishName,
            this.gridColumnDescription,
            this.gridColumnDishPrice,
            this.gridColumnDishPhoto});
            this.dishesGridView.DetailHeight = 50;
            this.dishesGridView.DetailVerticalIndent = 2;
            this.dishesGridView.GridControl = this.dishesGrid;
            this.dishesGridView.GroupRowHeight = 20;
            this.dishesGridView.LevelIndent = 2;
            this.dishesGridView.Name = "dishesGridView";
            this.dishesGridView.OptionsView.RowAutoHeight = true;
            this.dishesGridView.PreviewIndent = 2;
            this.dishesGridView.PreviewLineCount = 2;
            this.dishesGridView.RowHeight = 128;
            this.dishesGridView.RowSeparatorHeight = 2;
            this.dishesGridView.ViewCaptionHeight = 30;
            // 
            // gridColumnDishName
            // 
            this.gridColumnDishName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnDishName.AppearanceCell.Options.UseFont = true;
            this.gridColumnDishName.Caption = "Name";
            this.gridColumnDishName.ColumnEdit = this.repositoryItemMemoEdit;
            this.gridColumnDishName.FieldName = "Name";
            this.gridColumnDishName.Name = "gridColumnDishName";
            this.gridColumnDishName.OptionsColumn.AllowEdit = false;
            this.gridColumnDishName.OptionsColumn.AllowFocus = false;
            this.gridColumnDishName.Visible = true;
            this.gridColumnDishName.VisibleIndex = 0;
            this.gridColumnDishName.Width = 200;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnDescription.AppearanceCell.Options.UseFont = true;
            this.gridColumnDescription.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumnDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnDescription.AppearanceHeader.Options.UseFont = true;
            this.gridColumnDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumnDescription.Caption = "Description";
            this.gridColumnDescription.ColumnEdit = this.repositoryItemMemoEdit;
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.MinWidth = 100;
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.OptionsColumn.AllowEdit = false;
            this.gridColumnDescription.OptionsColumn.AllowFocus = false;
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 1;
            this.gridColumnDescription.Width = 500;
            // 
            // repositoryItemMemoEdit
            // 
            this.repositoryItemMemoEdit.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit";
            // 
            // gridColumnDishPrice
            // 
            this.gridColumnDishPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnDishPrice.AppearanceCell.Options.UseFont = true;
            this.gridColumnDishPrice.Caption = "Price";
            this.gridColumnDishPrice.FieldName = "Price";
            this.gridColumnDishPrice.MaxWidth = 100;
            this.gridColumnDishPrice.Name = "gridColumnDishPrice";
            this.gridColumnDishPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnDishPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnDishPrice.Visible = true;
            this.gridColumnDishPrice.VisibleIndex = 2;
            this.gridColumnDishPrice.Width = 100;
            // 
            // gridColumnDishPhoto
            // 
            this.gridColumnDishPhoto.Caption = "Photo";
            this.gridColumnDishPhoto.ColumnEdit = this.repositoryItemPictureEdit;
            this.gridColumnDishPhoto.FieldName = "Photo";
            this.gridColumnDishPhoto.MaxWidth = 284;
            this.gridColumnDishPhoto.Name = "gridColumnDishPhoto";
            this.gridColumnDishPhoto.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumnDishPhoto.Visible = true;
            this.gridColumnDishPhoto.VisibleIndex = 3;
            this.gridColumnDishPhoto.Width = 284;
            // 
            // repositoryItemPictureEdit
            // 
            this.repositoryItemPictureEdit.InitialImageOptions.SvgImageSize = new System.Drawing.Size(40, 40);
            this.repositoryItemPictureEdit.Name = "repositoryItemPictureEdit";
            this.repositoryItemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // GUI_TelegramBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 648);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.ribbonControlDishes);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GUI_TelegramBot.IconOptions.SvgImage")));
            this.Name = "GUI_TelegramBot";
            this.Text = "GUI_TelegramBot";
            this.Load += new System.EventHandler(this.GUI_TelegramBot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlDishes)).EndInit();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlDishes;
        private DevExpress.XtraBars.BarButtonItem barButtonAddDish;
        private DevExpress.XtraBars.BarButtonItem barButtonEditDish;
        private DevExpress.XtraBars.BarButtonItem barButtonRemoveDish;
        private DevExpress.XtraBars.BarButtonItem barButtonService;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDishesOperationsMngr;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupServiceManager;
        private System.Windows.Forms.Panel panelTable;
        private DevExpress.XtraGrid.GridControl dishesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView dishesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDishName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDishPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDishPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit;
    }
}