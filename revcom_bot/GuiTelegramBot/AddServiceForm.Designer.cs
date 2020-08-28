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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GridsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.DatesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DatesgridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DatesGridControl = new DevExpress.XtraGrid.GridControl();
            this.Dishes_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DishesGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridsSplitContainer)).BeginInit();
            this.GridsSplitContainer.Panel1.SuspendLayout();
            this.GridsSplitContainer.Panel2.SuspendLayout();
            this.GridsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dishes_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DishesGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 423);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(800, 27);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 126);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // GridsSplitContainer
            // 
            this.GridsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridsSplitContainer.Location = new System.Drawing.Point(0, 126);
            this.GridsSplitContainer.Name = "GridsSplitContainer";
            // 
            // GridsSplitContainer.Panel1
            // 
            this.GridsSplitContainer.Panel1.Controls.Add(this.DatesGridControl);
            // 
            // GridsSplitContainer.Panel2
            // 
            this.GridsSplitContainer.Panel2.Controls.Add(this.DishesGridControl);
            this.GridsSplitContainer.Size = new System.Drawing.Size(800, 297);
            this.GridsSplitContainer.SplitterDistance = 121;
            this.GridsSplitContainer.TabIndex = 4;
            // 
            // DatesView
            // 
            this.DatesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DatesgridColumn});
            this.DatesView.GridControl = this.DatesGridControl;
            this.DatesView.Name = "DatesView";
            // 
            // DatesgridColumn
            // 
            this.DatesgridColumn.Caption = "Dates";
            this.DatesgridColumn.Name = "DatesgridColumn";
            this.DatesgridColumn.Visible = true;
            this.DatesgridColumn.VisibleIndex = 0;
            // 
            // DatesGridControl
            // 
            this.DatesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatesGridControl.Location = new System.Drawing.Point(0, 0);
            this.DatesGridControl.MainView = this.DatesView;
            this.DatesGridControl.MenuManager = this.ribbonControl1;
            this.DatesGridControl.Name = "DatesGridControl";
            this.DatesGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatesGridControl.Size = new System.Drawing.Size(121, 297);
            this.DatesGridControl.TabIndex = 0;
            this.DatesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatesView});
            // 
            // Dishes_View
            // 
            this.Dishes_View.GridControl = this.DishesGridControl;
            this.Dishes_View.Name = "Dishes_View";
            // 
            // DishesGridControl
            // 
            this.DishesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DishesGridControl.Location = new System.Drawing.Point(0, 0);
            this.DishesGridControl.MainView = this.Dishes_View;
            this.DishesGridControl.MenuManager = this.ribbonControl1;
            this.DishesGridControl.Name = "DishesGridControl";
            this.DishesGridControl.Size = new System.Drawing.Size(675, 297);
            this.DishesGridControl.TabIndex = 0;
            this.DishesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Dishes_View});
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridsSplitContainer);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Name = "AddServiceForm";
            this.Text = "AddServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.GridsSplitContainer.Panel1.ResumeLayout(false);
            this.GridsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridsSplitContainer)).EndInit();
            this.GridsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dishes_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DishesGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.SplitContainer GridsSplitContainer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.GridControl DatesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DatesView;
        private DevExpress.XtraGrid.Columns.GridColumn DatesgridColumn;
        private DevExpress.XtraGrid.GridControl DishesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView Dishes_View;
    }
}