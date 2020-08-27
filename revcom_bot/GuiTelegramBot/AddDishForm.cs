using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace GuiTelegramBot
{
    public partial class AddDishForm : XtraForm
    {
        public DishDTO dishDTO = new DishDTO();
        public BindingSource dishBS = new BindingSource();
        public Utils.Operation operation;
        public IBotService botService;

        private ObjectBase Item
        {
            get { return dishBS.Current as ObjectBase; }
            set
            {
                dishBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AddDishForm(DishDTO dishDTO, Utils.Operation operation)
        {
            InitializeComponent();

            this.operation = operation;

            dishBS.DataSource = Item = dishDTO;

            textDishName.DataBindings.Add("EditValue", dishBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textDishDescription.DataBindings.Add("EditValue", dishBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            textDishPrice.DataBindings.Add("EditValue", dishBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);

            switch (operation)
            {
                case Utils.Operation.Add:


                    break;
                case Utils.Operation.Update:

                    if (((DishDTO)Item).Photo != null && ((DishDTO)Item).Photo.Length>0 )
                    {
                        int stratIndex = ((DishDTO)Item).Filename.IndexOf('.');
                        string typeFile = ((DishDTO)Item).Filename.Substring(stratIndex);

                        switch (typeFile)
                        {
                            default:
                                //Bitmap bitmap = new Bitmap(drawingScanDTO.Scan);
                                ImageConverter ic = new ImageConverter();

                                Image img = (Image)ic.ConvertFrom(((DishDTO)Item).Photo);

                                Bitmap bitmap1 = new Bitmap(img);

                                scanPictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                                scanPictureEdit.EditValue = bitmap1;
                                //fileNameTbox.EditValue = drawingScanDTO.FileName;
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }


            //this.dishDTO = dishDTO;
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            botService = Program.kernel.Get<IBotService>();

            //if (botService.CheckDetailName((DishDTO)Item))
            //{
            //    MessageBox.Show("Деталь с таким именем уже есть в базе данных!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            if (operation == Utils.Operation.Add)
            {
                botService.DishCreate((DishDTO)Item);
                return true;
            }
            else
            {

                botService.DishUpdate((DishDTO)Item);
                return true;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            Item.BeginEdit();

            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);

                ((DishDTO)Item).Photo = scan;
                ((DishDTO)Item).Filename = fileName;


                try
                {
                    //int drawingScanId = drawingService.DrawingScanCreate(drawingScanDTO);
                    //drawingScanList.Add(drawingScanDTO);
                    //drawingScanEdit.EditValue = drawingScanId;
                    fileNameEdit.Text = ((DishDTO)Item).Filename;

                    Bitmap bitmap = new Bitmap(filePath);
                    scanPictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                    scanPictureEdit.EditValue = bitmap;

                    Item.EndEdit();

                    //fileNameTbox.EditValue = fileName;
                }
                catch (Exception ex)
                {

                    Item.CancelEdit();
                    MessageBox.Show("При добавлении скана возникла ошибка. " + ex.Message, "Сохранение чертежа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                return;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public DishDTO Return()
        {
            return ((DishDTO)Item);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Сохранение контрагента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
