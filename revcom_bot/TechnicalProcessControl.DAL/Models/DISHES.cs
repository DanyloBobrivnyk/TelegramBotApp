using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revcom_bot.Models
{
    public class DISHES
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal PRICE { get; set; }
        public byte[]  PHOTO { get; set; }

       /* public string Realize(Dish dish, TelegramBotClient bot)
        {
            var data = new StringBuilder();
            
            data.AppendLine($"Название блюда:{dish.Name}");

            data.AppendLine($"{dish.Image}");
        }
       */
    }
}
