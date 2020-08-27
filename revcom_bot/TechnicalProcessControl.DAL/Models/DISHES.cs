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
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[]  Photo { get; set; }
        public string Filename { get; set; }

       /* public string Realize(Dish dish, TelegramBotClient bot)
        {
            var data = new StringBuilder();
            
            data.AppendLine($"Название блюда:{dish.Name}");

            data.AppendLine($"{dish.Image}");
        }
       */
    }
}
