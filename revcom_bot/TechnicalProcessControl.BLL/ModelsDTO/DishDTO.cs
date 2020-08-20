using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class DishDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal PRICE { get; set; }
        public byte[] PHOTO { get; set; }
    }
}
