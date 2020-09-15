namespace GuiTelegramBot
{
    partial class EditServiceForm
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
            this.panelDishesGrid = new System.Windows.Forms.Panel();
            this.dishesGrid = new DevExpress.XtraGrid.GridControl();
            this.dishesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDishName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDishPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDishPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.checkCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.panelDishesGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDishesGrid
            // 
            this.panelDishesGrid.Controls.Add(this.dishesGrid);
            this.panelDishesGrid.Location = new System.Drawing.Point(-1, 0);
            this.panelDishesGrid.Name = "panelDishesGrid";
            this.panelDishesGrid.Size = new System.Drawing.Size(1139, 587);
            this.panelDishesGrid.TabIndex = 2;
            // 
            // dishesGrid
            // 
            this.dishesGrid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.dishesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishesGrid.Location = new System.Drawing.Point(0, 0);
            this.dishesGrid.MainView = this.dishesGridView;
            this.dishesGrid.Name = "dishesGrid";
            this.dishesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit,
            this.repositoryItemMemoEdit,
            this.repositoryItemCheckEdit});
            this.dishesGrid.Size = new System.Drawing.Size(1139, 587);
            this.dishesGrid.TabIndex = 1;
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
            this.gridColumnDishPhoto,
            this.checkCol});
            this.dishesGridView.DetailHeight = 50;
            this.dishesGridView.DetailVerticalIndent = 2;
            this.dishesGridView.GridControl = this.dishesGrid;
            this.dishesGridView.GroupRowHeight = 20;
            this.dishesGridView.LevelIndent = 2;
            this.dishesGridView.Name = "dishesGridView";
            this.dishesGridView.PreviewIndent = 2;
            this.dishesGridView.PreviewLineCount = 2;
            this.dishesGridView.RowHeight = 120;
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
            this.gridColumnDishName.Width = 213;
            // 
            // repositoryItemMemoEdit
            // 
            this.repositoryItemMemoEdit.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit";
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
            this.gridColumnDescription.Width = 460;
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
            this.gridColumnDishPhoto.MaxWidth = 220;
            this.gridColumnDishPhoto.Name = "gridColumnDishPhoto";
            this.gridColumnDishPhoto.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumnDishPhoto.Visible = true;
            this.gridColumnDishPhoto.VisibleIndex = 3;
            this.gridColumnDishPhoto.Width = 173;
            // 
            // repositoryItemPictureEdit
            // 
            this.repositoryItemPictureEdit.InitialImageOptions.SvgImageSize = new System.Drawing.Size(40, 40);
            this.repositoryItemPictureEdit.Name = "repositoryItemPictureEdit";
            this.repositoryItemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // checkCol
            // 
            this.checkCol.Caption = "Selected for Service";
            this.checkCol.ColumnEdit = this.repositoryItemCheckEdit;
            this.checkCol.FieldName = "Checked";
            this.checkCol.Name = "checkCol";
            this.checkCol.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.checkCol.Visible = true;
            this.checkCol.VisibleIndex = 4;
            this.checkCol.Width = 168;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AllowGrayed = true;
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(1051, 593);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(961, 593);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 625);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.panelDishesGrid);
            this.Name = "EditServiceForm";
            this.Text = "EditServiceForm";
            this.panelDishesGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDishesGrid;
        private DevExpress.XtraGrid.GridControl dishesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView dishesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDishName;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDishPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDishPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit;
        public DevExpress.XtraGrid.Columns.GridColumn checkCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
    }
}