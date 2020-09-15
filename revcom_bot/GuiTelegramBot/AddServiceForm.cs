using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using DevExpress.XtraEditors;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System;

namespace GuiTelegramBot
{
    public partial class AddServiceForm : XtraForm
    {
        public BindingSource dishBS = new BindingSource();

        public BindingSource dateBS = new BindingSource();

        public Utils.Operation operation;

        public DateTime currentDate = DateTime.Now;

        private ObjectBase Item
        {
            get { return dishBS.Current as ObjectBase; }
            set
            {
                dishBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AddServiceForm(Utils.Operation operation, List<DishDTO> SelectedDishes, List<DateDTO> ServiceDates)
        {
            InitializeComponent();

            dishBS.DataSource = SelectedDishes;

            Edit_Service_Date.EditValue = currentDate;

            Grid_Cntrl_Dishes.DataSource = dishBS;
            
            /*textDishName.DataBindings.Add("EditValue", dishBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
             textDishDescription.DataBindings.Add("EditValue", dishBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
             textDishPrice.DataBindings.Add("EditValue", dishBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);*/
        }

        public void LoadSelectedDishes()
        {
            Grid_Cntrl_Dishes.DataSource = dishBS;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EditServiceForm editServiceForm = new EditServiceForm((List<DishDTO>)dishBS.DataSource))
            {
                if (editServiceForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }
    }
}
