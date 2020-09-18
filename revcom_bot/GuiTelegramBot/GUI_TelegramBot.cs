using System;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace GuiTelegramBot
{
    public partial class GUI_TelegramBot : XtraForm
    {

        public IBotService botService; 

        public BindingSource dishBS = new BindingSource();
        public BindingSource dateBS = new BindingSource();

        public List<DishDTO> SelectedDishes = new List<DishDTO>();
        public List<DateDTO> SerivceDatesList = new List<DateDTO>();
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

        private void barButtonService_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dishesGridView.PostEditor();
            SelectedDishes = ((List<DishDTO>)dishBS.DataSource).Where(s => s.Checked).ToList();

            using (AddServiceForm addSericeForm = new AddServiceForm(Utils.Operation.Add))
            {
                if (addSericeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //dishesGridView.PostEditor();
                    /*DishDTO return_Id = addSericeForm.Return();
                    dishesGridView.BeginDataUpdate();
                    LoadData();
                    dishesGridView.EndDataUpdate();
                    int rowHandle = dishesGridView.LocateByValue("ID", return_Id.ID);
                    dishesGridView.FocusedRowHandle = rowHandle;*/
                }
            }
        }

        private void repositoryItemCheckEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonRemoveDish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            botService = Program.kernel.Get<IBotService>();

            botService.DishDelete(((DishDTO)dishBS.Current).ID);

            dishesGridView.BeginDataUpdate();
            LoadData();
            dishesGridView.EndDataUpdate();

        }
    }
}
