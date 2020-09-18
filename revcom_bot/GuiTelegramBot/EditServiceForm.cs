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
        
        int idToSave;
        
        public List<DishDTO> updatedListSelectedDishes = new List<DishDTO>();
        public List<DishDTO> bufferDishesList = new List<DishDTO>();

        public EditServiceForm(DateDTO dateDTO, List<int> dishDTOs)
        {
            InitializeComponent();

            LoadData(dishesGrid, dishDTOs);
            idToSave = dateDTO.Id;
        }

        public void LoadData(DevExpress.XtraGrid.GridControl gridCntrl, List<int> selectedDishDTOs)
        {
            botService = Program.kernel.Get<IBotService>();

            dishBS.DataSource = botService.GetTelegramDishes();
            
            foreach (var item in (List<DishDTO>)dishBS.DataSource)
            { 
                if (selectedDishDTOs.All(bdsm => bdsm != item.ID))
                    bufferDishesList.Add(item);
            }

            dishBS.DataSource = bufferDishesList;
            gridCntrl.DataSource = dishBS;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dishesGridView.PostEditor();
            bufferDishesList = ((List<DishDTO>)dishBS.DataSource).Where(s => s.Checked).ToList();
            List<ServiceDTO> serviceDTOs = new List<ServiceDTO>();
            foreach (var item in bufferDishesList)
            {
                botService.ServiceCreate(new ServiceDTO
                {
                    Date_Id = idToSave,
                    Dish_Id = item.ID
                }); 
            }
            DialogResult = DialogResult.OK;
            MessageBox.Show("Dishes was added to service.");
            this.Close();
        }

        
    }
}
