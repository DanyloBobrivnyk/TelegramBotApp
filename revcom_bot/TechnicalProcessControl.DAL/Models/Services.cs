using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        public int Date_Id { get; set; }

        public int Dish_Id { get; set; }

    }
}
