using System;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.Services;
using System.Collections.Generic;
using TechnicalProcessControl.BLL.ModelsDTO;
using System.Linq;

namespace GuiTelegramBot
{
    public partial class EditServiceForm : XtraForm
    {
        public IBotService botService;

        public BindingSource dishBS = new BindingSource();

        public EditServiceForm(List<DishDTO> selectedDishesList)
        {
            InitializeComponent();

            LoadData(dishBS, selectedDishesList, dishesGrid);
        }

        public void LoadData(BindingSource bindingSource, List<DishDTO> selectedDishesList, DevExpress.XtraGrid.GridControl gridCntrl)
        {
            botService = Program.kernel.Get<IBotService>();

            bindingSource.DataSource = botService.GetTelegramDishes();

            List<DishDTO> bufferDishesList = new List<DishDTO>(); 
            List<DishDTO> notSelectedDishesList = ((List<DishDTO>)bindingSource.DataSource);
            
            foreach (DishDTO item in notSelectedDishesList)
            { 
                if (selectedDishesList.All(bdsm => bdsm.ID != item.ID))
                    bufferDishesList.Add(item);
            }

            bindingSource.DataSource = bufferDishesList;
            gridCntrl.DataSource = bindingSource;
        }
    }
}
