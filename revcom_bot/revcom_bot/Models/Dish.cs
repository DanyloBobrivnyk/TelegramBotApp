﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace revcom_bot.Models
{
    public class Dish
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

       /* public string Realize(Dish dish, TelegramBotClient bot)
        {
            var data = new StringBuilder();
            
            data.AppendLine($"Название блюда:{dish.Name}");

            data.AppendLine($"{dish.Image}");
        }
       */
    }
}