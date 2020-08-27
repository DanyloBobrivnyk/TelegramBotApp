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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
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
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(495, 339);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(495, 306);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Upload";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
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
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.scanPictureEdit);
            this.Controls.Add(this.textDishPrice);
            this.Controls.Add(this.textDishDescription);
            this.Controls.Add(this.textDishName);
            this.Controls.Add(this.labelAddDIsh);
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit fileNameEdit;
    }
}