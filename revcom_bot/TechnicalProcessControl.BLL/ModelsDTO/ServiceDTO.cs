using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.BLL.ModelsDTO
{ 
    public class ServiceDTO
    { 
       
        [Key]
        public int Id { get; set; }
        public int Date_Id { get; set; }
        public int Dish_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; }

        public string Filename { get; set; }
    }
}
