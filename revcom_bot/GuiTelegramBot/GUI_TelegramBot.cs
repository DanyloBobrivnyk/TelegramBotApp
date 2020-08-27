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

namespace GuiTelegramBot
{
    public partial class GUI_TelegramBot : XtraForm
    {

        public IBotService botService; 
        public BindingSource dishBS = new BindingSource();


        public GUI_TelegramBot()
        {
            InitializeComponent();

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
                    //DetailsDTO return_Id = detailsEditFm.Return();
                    //detailsGridView.BeginDataUpdate();
                    //LoadData();
                    //detailsGridView.EndDataUpdate();
                    //int rowHandle = detailsGridView.LocateByValue("Id", return_Id.Id);
                    //detailsGridView.FocusedRowHandle = rowHandle;

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
