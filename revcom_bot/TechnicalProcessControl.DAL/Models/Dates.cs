using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.DAL.Models
{
    public class Dates
    {
        [Key]
        public int Id { get; set; }
        public DateTime Service_Dates { get; set; }
    }
}
