using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using DevExpress.XtraEditors;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace GuiTelegramBot
{
    public partial class AddServiceForm : XtraForm
    {
        public BindingSource dishBS = new BindingSource();
        public Utils.Operation operation;

        private ObjectBase Item
        {
            get { return dishBS.Current as ObjectBase; }
            set
            {
                dishBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AddServiceForm(Utils.Operation operation, List<DishDTO> SelectedDishes)
        {
            InitializeComponent();

            dishBS.DataSource = SelectedDishes;

            DishesGridControl.DataSource = dishBS;

           
            /* textDishName.DataBindings.Add("EditValue", dishBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
             textDishDescription.DataBindings.Add("EditValue", dishBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
             textDishPrice.DataBindings.Add("EditValue", dishBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);*/
        }

        public void LoadSelectedDishes()
        {
            DishesGridControl.DataSource = dishBS;
        }
    }
}
