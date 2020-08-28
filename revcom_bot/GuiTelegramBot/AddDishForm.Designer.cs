namespace GuiTelegramBot
{
    partial class AddDishForm
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
            this.labelAddDIsh = new System.Windows.Forms.Label();
            this.textDishName = new DevExpress.XtraEditors.TextEdit();
            this.textDishDescription = new DevExpress.XtraEditors.TextEdit();
            this.textDishPrice = new DevExpress.XtraEditors.TextEdit();
            this.scanPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.UploadButton = new DevExpress.XtraEditors.SimpleButton();
            this.fileNameEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textDishName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDishDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDishPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddDIsh
            // 
            this.labelAddDIsh.AutoSize = true;
            this.labelAddDIsh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddDIsh.Location = new System.Drawing.Point(12, 9);
            this.labelAddDIsh.Name = "labelAddDIsh";
            this.labelAddDIsh.Size = new System.Drawing.Size(150, 23);
            this.labelAddDIsh.TabIndex = 0;
            this.labelAddDIsh.Text = "Adding new dish";
            // 
            // textDishName
            // 
            this.textDishName.EditValue = "Dish Name";
            this.textDishName.Location = new System.Drawing.Point(16, 66);
            this.textDishName.Name = "textDishName";
            this.textDishName.Size = new System.Drawing.Size(172, 20);
            this.textDishName.TabIndex = 1;
            // 
            // textDishDescription
            // 
            this.textDishDescription.EditValue = "Dish Description (Optional)";
            this.textDishDescription.Location = new System.Drawing.Point(16, 112);
            this.textDishDescription.Name = "textDishDescription";
            this.textDishDescription.Size = new System.Drawing.Size(172, 20);
            this.textDishDescription.TabIndex = 2;
            // 
            // textDishPrice
            // 
            this.textDishPrice.EditValue = "Dish Price";
            this.textDishPrice.Location = new System.Drawing.Point(16, 157);
            this.textDishPrice.Name = "textDishPrice";
            this.textDishPrice.Size = new System.Drawing.Size(172, 20);
            this.textDishPrice.TabIndex = 3;
            // 
            // scanPictureEdit
            // 
            this.scanPictureEdit.Location = new System.Drawing.Point(223, 12);
            this.scanPictureEdit.Name = "scanPictureEdit";
            this.scanPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.scanPictureEdit.Size = new System.Drawing.Size(347, 262);
            this.scanPictureEdit.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(495, 339);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(414, 339);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(495, 306);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 9;
            this.UploadButton.Text = "Upload";
            this.UploadButton.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // fileNameEdit
            // 
            this.fileNameEdit.EditValue = "";
            this.fileNameEdit.Location = new System.Drawing.Point(223, 280);
            this.fileNameEdit.Name = "fileNameEdit";
            this.fileNameEdit.Size = new System.Drawing.Size(347, 20);
            this.fileNameEdit.TabIndex = 10;
            // 
            // AddDishForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Ivory;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 374);
            this.Controls.Add(this.fileNameEdit);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.scanPictureEdit);
            this.Controls.Add(this.textDishPrice);
            this.Controls.Add(this.textDishDescription);
            this.Controls.Add(this.textDishName);
            this.Controls.Add(this.labelAddDIsh);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "AddDishForm";
            this.Text = "AddDishForm";
            ((System.ComponentModel.ISupportInitialize)(this.textDishName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDishDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDishPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddDIsh;
        private DevExpress.XtraEditors.TextEdit textDishName;
        private DevExpress.XtraEditors.TextEdit textDishDescription;
        private DevExpress.XtraEditors.TextEdit textDishPrice;
        private DevExpress.XtraEditors.PictureEdit scanPictureEdit;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton UploadButton;
        private DevExpress.XtraEditors.TextEdit fileNameEdit;
    }
}