using revcom_bot.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revcom_bot
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw;

        public Form1()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //

            this.bw = new BackgroundWorker();
            this.bw.DoWork += bw_DoWork;
        }

        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var key = e.Argument as String; // получаем ключ из аргументов
            try
            {
                var Bot = new Telegram.Bot.TelegramBotClient(key); // инициализируем API
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                
                await Bot.SetWebhookAsync(); // Обязательно! убираем старую привязку к вебхуку для бота

                // Inlin'ы
                Bot.OnInlineQuery += async (object si, Telegram.Bot.Args.InlineQueryEventArgs ei) =>
                {
                    var query = ei.InlineQuery.Query;

                    var msg = new Telegram.Bot.Types.InputMessageContents.InputTextMessageContent
                    {
                        MessageText = @"Это супер крутой текст статьи
                        с переносами
                        и <b>html</b> <i>тегами!</i>",
                        ParseMode = Telegram.Bot.Types.Enums.ParseMode.Html,
                    };

                    Telegram.Bot.Types.InlineQueryResults.InlineQueryResult[] results = {
                        new Telegram.Bot.Types.InlineQueryResults.InlineQueryResultArticle
                        {
                            Id = "1",
                            Title = "Тестовый тайтл",
                            Description = "Описание статьи тут",
                            InputMessageContent = msg,
                        },
                        new Telegram.Bot.Types.InlineQueryResults.InlineQueryResultAudio
                        {
                            Url = "http://aftamat4ik.ru/wp-content/uploads/2017/05/mongol-shuudan_-_kozyr-nash-mandat.mp3",
                            Id = "2",
                            FileId = "123423433",
                            Title = "Монгол Шуудан - Козырь наш Мандат!",
                        },
                        new Telegram.Bot.Types.InlineQueryResults.InlineQueryResultPhoto
                        {
                            Id = "3",
                            Url = "http://aftamat4ik.ru/wp-content/uploads/2017/05/14277366494961.jpg",
                            ThumbUrl = "http://aftamat4ik.ru/wp-content/uploads/2017/05/14277366494961-150x150.jpg",
                            Caption = "Текст под фоткой",
                            Description = "Описание",
                        },
                        new Telegram.Bot.Types.InlineQueryResults.InlineQueryResultVideo
                        {
                            Id = "4",
                            Url = "http://aftamat4ik.ru/wp-content/uploads/2017/05/bb.mp4",
                            ThumbUrl = "http://aftamat4ik.ru/wp-content/uploads/2017/05/joker_5-150x150.jpg",
                            Title = "демо видеоролика",
                            MimeType = "video/mp4",
                        }
                    };


                    await Bot.AnswerInlineQueryAsync(ei.InlineQuery.Id, results);
                };

                // Callback'и от кнопок
                Bot.OnCallbackQuery += async (object sc, Telegram.Bot.Args.CallbackQueryEventArgs ev) =>
                {
                    var message = ev.CallbackQuery.Message;
                    if(ev.CallbackQuery.Data == "callback1") {
                        await Bot.AnswerCallbackQueryAsync(ev.CallbackQuery.Id, "You have choosen " + ev.CallbackQuery.Data, true);
                    } else 
                    if (ev.CallbackQuery.Data == "callback2")
                    {
                        await Bot.SendTextMessageAsync(message.Chat.Id, "тест", replyToMessageId: message.MessageId);
                        await Bot.AnswerCallbackQueryAsync(ev.CallbackQuery.Id); // отсылаем пустое, чтобы убрать "частики" на кнопке
                    }
                };

                Bot.OnUpdate += async (object su, Telegram.Bot.Args.UpdateEventArgs evu) =>
                {
                    if (evu.Update.CallbackQuery != null || evu.Update.InlineQuery != null) return; // в этом блоке нам келлбэки и инлайны не нужны
                    var update = evu.Update;
                    var message = update.Message;
                    if (message == null) return;
                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
                    {
                        if (message.Text == "/saysomething")
                        {
                            // в ответ на команду /saysomething выводим сообщение
                            await Bot.SendTextMessageAsync(message.Chat.Id, "тест", replyToMessageId: message.MessageId);
                        }
                        if (message.Text == "/getmenu")
                        {
                            // в ответ на команду /getimage выводим картинку
                            var dish1 = new Dish();
                            dish1.Name = "Golubtsi";
                            dish1.Image = "https://www.koolinar.ru/all_image/recipes/145/145511/recipe_364d4cd5-421a-4e35-93f5-34748438c804_large.jpg";
                            dish1.Description = "Голубцы без сметаны";

                            var dish2 = new Dish();
                            dish2.Name = "Borshch";
                            dish2.Image = "https://www.delonghi.com/Global/recipes/multifry/512.jpg";
                            dish2.Description = "Борщ со сметной";

                            List<Dish> Dishes = new List<Dish>();
                            Dishes.Add(dish1);
                            Dishes.Add(dish2);

                            foreach(var dish in Dishes)
                            {
                                await Bot.SendPhotoAsync(message.Chat.Id, dish.Image, $"Имя:{dish.Name}, Описание:{dish.Description}.");
                            }
                            
                            
                        }

                        // inline buttons
                        if (message.Text == "/ibuttons")
                        {
                            var keyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(
                                                    new Telegram.Bot.Types.InlineKeyboardButton[][]
                                                    {   
                                                            // First row
                                                            new [] {
                                                                // First column
                                                                new Telegram.Bot.Types.InlineKeyboardButton("раз","callback1"),

                                                                // Second column
                                                                new Telegram.Bot.Types.InlineKeyboardButton("два","callback2"),
                                                            },
                                                    }
                                                );

                            await Bot.SendTextMessageAsync(message.Chat.Id, "Давай накатим, товарищ, по одной!", false, false, 0, keyboard, Telegram.Bot.Types.Enums.ParseMode.Default);
                        }

                        // reply buttons
                        if (message.Text == "/rbuttons")
                        {
                            var keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup
                            {
                                Keyboard = new[] {
                                                new[] // row 1
                                                {
                                                    new Telegram.Bot.Types.KeyboardButton("Накатим!"),
                                                    new Telegram.Bot.Types.KeyboardButton("Рря!")
                                                },
                                            },
                                ResizeKeyboard = true
                            };

                            await Bot.SendTextMessageAsync(message.Chat.Id, "Давай накатим, товарищ, мой!", false, false, 0, keyboard, Telegram.Bot.Types.Enums.ParseMode.Default);
                        }
                        // обработка reply кнопок
                        if (message.Text.ToLower() == "накатим!")
                        {
                            await Bot.SendTextMessageAsync(message.Chat.Id, "Ну, за охоту!", replyToMessageId: message.MessageId);
                        }
                        if (message.Text.ToLower() == "рря!")
                        {
                            await Bot.SendTextMessageAsync(message.Chat.Id, "Ну, за демократию!", replyToMessageId: message.MessageId);
                        }
                    }
                };

                // запускаем прием обновлений
                Bot.StartReceiving();
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex.Message); // если ключ не подошел - пишем об этом в консоль отладки
            }

        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            var text = @txtKey.Text; // получаем содержимое текстового поля txtKey в переменную text
            if (text != "" && this.bw.IsBusy != true)
            {
                this.bw.RunWorkerAsync(text); // передаем эту переменную в виде аргумента методу bw_DoWork
                BtnRun.Text = "Бот запущен...";
            }
        }
    }
}
