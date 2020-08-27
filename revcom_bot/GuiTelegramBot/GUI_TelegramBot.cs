using System;
using System.Collections;
using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.XtraEditors;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using System.Drawing.Drawing2D;

namespace GuiTelegramBot
{
    public partial class GUI_TelegramBot : XtraForm
    {

        public IBotService botService; 
        public BindingSource dishBS = new BindingSource();


        public GUI_TelegramBot()
        {
            InitializeComponent();


            LoadData();
        }

        public void LoadData()
        {
            botService = Program.kernel.Get<IBotService>();

            dishBS.DataSource = botService.GetTelegramDishes();
            dishesGrid.DataSource = dishBS;
            //dishesGridView.Columns["Description"].AppearanceCell.TextOptions.Trimming = Trimming.Character;
            //dishesGridView.Columns["Description"].AppearanceCell.TextOptions.WordWrap = WordWrap.Wrap;

        }

        private void GUI_TelegramBot_Load(object sender, EventArgs e)
        {

        }

        private void barButtonAddDish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            using (AddDishForm addDishForm = new AddDishForm(new DishDTO(), Utils.Operation.Add))
            {
                if (addDishForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DishDTO return_Id = addDishForm.Return();
                    dishesGridView.BeginDataUpdate();
                    LoadData();
                    dishesGridView.EndDataUpdate();
                    int rowHandle = dishesGridView.LocateByValue("ID", return_Id.ID);
                    dishesGridView.FocusedRowHandle = rowHandle;
                }
            }
            
            //AddDishForm form = new AddDishForm();
            //form.ShowDialog();
        }

        private void barButtonEditDish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (AddDishForm addDishForm = new AddDishForm((DishDTO)dishBS.Current ,Utils.Operation.Update))
            {
                if (addDishForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //DetailsDTO return_Id = detailsEditFm.Return();
                    //detailsGridView.BeginDataUpdate();
                    //LoadData();
                    //detailsGridView.EndDataUpdate();
                    //int rowHandle = detailsGridView.LocateByValue("Id", return_Id.Id);
                    //detailsGridView.FocusedRowHandle = rowHandle;

                }
            }

        }
    }
}
