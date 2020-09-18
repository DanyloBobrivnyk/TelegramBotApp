using System;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using System.Collections.Generic;
using TechnicalProcessControl.BLL.ModelsDTO;
using System.Linq;

namespace GuiTelegramBot
{
    public partial class EditServiceForm : XtraForm
    {
        public IBotService botService;

        public BindingSource dishBS = new BindingSource();

        public List<DishDTO> updatedListSelectedDishes = new List<DishDTO>();

        public EditServiceForm(List<DishDTO> selectedDishesList)
        {
            InitializeComponent();

            //LoadData(selectedDishesList, dishesGrid);
        }

        public void LoadData(List<DishDTO> selectedDishesList, DevExpress.XtraGrid.GridControl gridCntrl)
        {
            botService = Program.kernel.Get<IBotService>();

            dishBS.DataSource = botService.GetTelegramDishes();

            List<DishDTO> bufferDishesList = new List<DishDTO>();
            List<DishDTO> notSelectedDishesList = ((List<DishDTO>)dishBS.DataSource);
            
            foreach (DishDTO item in notSelectedDishesList)
            { 
                if (selectedDishesList.All(bdsm => bdsm.ID != item.ID))
                    bufferDishesList.Add(item);
            }

            dishBS.DataSource = bufferDishesList;
            gridCntrl.DataSource = dishBS;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
            updatedListSelectedDishes = ((List<DishDTO>)dishBS.DataSource).Where(s => s.Checked).ToList();
            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
