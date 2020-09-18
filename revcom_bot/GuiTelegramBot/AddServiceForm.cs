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
        public BindingSource dateBS = new BindingSource();
        public BindingSource servicesBS = new BindingSource();
        public BindingSource dishBS = new BindingSource();

        public List<DishDTO> bufferDishesList = new List<DishDTO>();

        public Utils.Operation operation;

        public IBotService botService;

        public DateTime currentDate = DateTime.Now;

        //private ObjectBase Item
        //{
        //    get { return dishBS.Current as ObjectBase; }
        //    set
        //    {
        //        dishBS.DataSource = value;
        //        value.BeginEdit();
        //    }
        //}

        public AddServiceForm(Utils.Operation operation)
        {
            InitializeComponent();

            LoadDataDate();

            /*textDishName.DataBindings.Add("EditValue", dishBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
             textDishDescription.DataBindings.Add("EditValue", dishBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
             textDishPrice.DataBindings.Add("EditValue", dishBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);*/
        }

        public void LoadDataDate()
        {
            botService = Program.kernel.Get<IBotService>();

            dateBS.DataSource = botService.GetTelegramDates();

            Grid_Cntrl_Dates.DataSource = dateBS;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveDate();
        }

        public bool SaveDate()
        {

            botService = Program.kernel.Get<IBotService>();

            if (Edit_Service_Date.EditValue != null)
            {
                if (botService.CheckDate((DateTime)Edit_Service_Date.EditValue))
                    MessageBox.Show("");
                else
                {
                    MessageBox.Show("Гав");
                    Grid_Cntrl_Dates.BeginUpdate();
                    
                    botService.DateCreate(new DateDTO()
                    {
                        Service_Dates = (DateTime)Edit_Service_Date.EditValue
                    });
                    LoadDataDate();

                    Grid_Cntrl_Dates.EndUpdate();
                }
                    
            }
            return false;

            //DateTime selectedDateTime = ((DateTime)Edit_Service_Date.EditValue);  

            //foreach (var item in dateDTOList)
            //{
            //    if (dateDTOList.Any(c => c.Service_Dates.Value.Day == selectedDateTime.Day) && dateDTOList.Any(c => c.Service_Dates.Value.Month == selectedDateTime.Month))
            //    {
            //        MessageBox.Show("This date is already saved into the database.\nIf you want to edit existing date - choose it from the grid down below.");
            //        return false;
            //    }
            //    else if(selectedDateTime == null)
            //    {
            //        MessageBox.Show("You must fill the data field!\nProgram can't work without any data -__-");
            //        return false;
            //    }
            //    else
            //    {
            //        botService.DateCreate();
            //        return true;
            //    }
            //}
            //MessageBox.Show("SaveDate Function Error :(");
            //return false;
        }

        private void Button_Accept_Window_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveDate())
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Date saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            botService = Program.kernel.Get<IBotService>();

            if (dateBS.Count>0)
            {
                servicesBS.DataSource = botService.GetServiceDTOByDateId(((DateDTO)dateBS.Current).Id);
                gridControlDishesInService.DataSource = servicesBS;

            }
        }

        private void barButtonDeleteService_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            botService.DateDelete(((DateDTO)dateBS.Current).Id);
            gridView2.BeginUpdate();
            dateBS.MoveLast();
            LoadDataDate();
            gridView2.EndUpdate();
            
        }

        private void barBtnAddDish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            List<int> bufferDishesIdList = new List<int>();
            foreach (var item in (List<ServiceDTO>)servicesBS.DataSource)
            {
                bufferDishesIdList.Add(item.Dish_Id);
            }

            using (EditServiceForm editServiceForm = new EditServiceForm((DateDTO)dateBS.Current, bufferDishesIdList))
            {
                if (editServiceForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    gridView1.BeginDataUpdate();

                    servicesBS.DataSource = botService.GetServiceDTOByDateId(((DateDTO)dateBS.Current).Id);
                    gridControlDishesInService.DataSource = servicesBS;

                    gridView1.EndDataUpdate();

                }
            }
        }

        private void barBtnDeleteDish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            botService.ServiceUpdate(((ServiceDTO)servicesBS.Current).Dish_Id, ((DateDTO)dateBS.Current).Id);
            gridView1.BeginUpdate();
            servicesBS.DataSource = botService.GetServiceDTOByDateId(((DateDTO)dateBS.Current).Id);
            gridControlDishesInService.DataSource = servicesBS;
            gridView1.EndUpdate();
        }
    }
}
