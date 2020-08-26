using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Examples.Echo
{
    public static class Program
    {
        private static TelegramBotClient Bot;
        private static u436263_100tztestContext db = new u436263_100tztestContext();
      

        public static async Task Main()
        {
//#if USE_PROXY
            //var Proxy = new WebProxy(Configuration.Proxy.Host, Configuration.Proxy.Port) { UseDefaultCredentials = true };
            //Bot = new TelegramBotClient(Configuration.BotToken, webProxy: Proxy);
//#else
            Bot = new TelegramBotClient(Configuration.BotToken);
//#endif

            var me = await Bot.GetMeAsync();
            Console.Title = me.Username;

            Bot.OnUpdate += BotOnUpdate;
            Bot.OnMessage += BotOnMessageReceived;
            Bot.OnMessageEdited += BotOnMessageReceived;
            Bot.OnCallbackQuery += BotOnCallbackQueryReceived;
            Bot.OnInlineQuery += BotOnInlineQueryReceived;
            Bot.OnInlineResultChosen += BotOnChosenInlineResultReceived;
            Bot.OnReceiveError += BotOnReceiveError;
         
            Bot.StartReceiving(Array.Empty<UpdateType>());
            Console.WriteLine($"Start listening for @{me.Username}");

            Console.ReadLine();
            Bot.StopReceiving();


        }
      
    


    private static async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            //принимает обычные сообщения, но не от канала, возможно нужна какая-то дополнительная функция
            var message = messageEventArgs.Message;
            if (message == null || message.Type != MessageType.Text)//тут убрать, возможен не только текст
                return;

            switch (message.Text.Split(' ').First())
            {
                // Send inline keyboard
                case "/inline":
                    await SendInlineKeyboard(message);
                    break;

                // send custom keyboard
                case "/keyboard":
                    await SendReplyKeyboard(message);
                    break;

                // send a photo
                case "/photo":
                    await SendDocument(message);
                    break;

                // request location or contact
                case "/request":
                    await RequestContactAndLocation(message);
                    break;

                default:
                    await Usage(message);
                    break;
            }

            // Send inline keyboard
            // You can process responses in BotOnCallbackQueryReceived handler
            static async Task SendInlineKeyboard(Message message)
            {
                await Bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

                // Simulate longer running task
                await Task.Delay(500);

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    // first row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData("1.1", "11"),
                        InlineKeyboardButton.WithCallbackData("1.2", "12"),
                    },
                    // second row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData("2.1", "21"),
                        InlineKeyboardButton.WithCallbackData("2.2", "22"),
                    }
                });
                await Bot.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Choose",
                    replyMarkup: inlineKeyboard
                );
            }

          
                static async Task SendReplyKeyboard(Message message)
            {
                var replyKeyboardMarkup = new ReplyKeyboardMarkup(
                    new KeyboardButton[][]
                    {
                        new KeyboardButton[] { "1.1", "1.2" },
                        new KeyboardButton[] { "2.1", "2.2" },
                    },
                    resizeKeyboard: true
                );

                await Bot.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Choose",
                    replyMarkup: replyKeyboardMarkup

                );
            }

            static async Task SendDocument(Message message)
            {
                await Bot.SendChatActionAsync(message.Chat.Id, ChatAction.UploadPhoto);

                const string filePath = @"Files/tux.png";
                using var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                var fileName = filePath.Split(Path.DirectorySeparatorChar).Last();
                await Bot.SendPhotoAsync(
                    chatId: message.Chat.Id,
                    photo: new InputOnlineFile(fileStream, fileName),
                    caption: "Nice Picture"
                );
            }
         

            static async Task RequestContactAndLocation(Message message)
            {
                var RequestReplyKeyboard = new ReplyKeyboardMarkup(new[]
                {
                    KeyboardButton.WithRequestLocation("Location"),
                    KeyboardButton.WithRequestContact("Contact"),
                });
                await Bot.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Who or Where are you?",
                    replyMarkup: RequestReplyKeyboard
                );
            }

            static async Task Usage(Message message)
            {
                const string usage = "Usage:\n" +
                                        "/inline   - send inline keyboard\n" +
                                        "/keyboard - send custom keyboard\n" +
                                        "/photo    - send a photo\n" +
                                        "/request  - request location or contact";
                await Bot.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: usage,
                    replyMarkup: new ReplyKeyboardRemove()
                );
            }

           
        }

        // Process Inline Keyboard callback data
        private static async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            var callbackQuery = callbackQueryEventArgs.CallbackQuery;

            await Bot.AnswerCallbackQueryAsync(
                callbackQueryId: callbackQuery.Id,
                text: $"Received {callbackQuery.Data}"
            );

            await Bot.SendTextMessageAsync(
                chatId: callbackQuery.Message.Chat.Id,
                text: $"Received {callbackQuery.Data}"
            );
        }

        #region Inline Mode

        private static async void BotOnInlineQueryReceived(object sender, InlineQueryEventArgs inlineQueryEventArgs)
        {
            Console.WriteLine($"Received inline query from: {inlineQueryEventArgs.InlineQuery.From.Id}");

            InlineQueryResultBase[] results = {
                // displayed result
                new InlineQueryResultArticle(
                    id: "3",
                    title: "TgBots",
                    inputMessageContent: new InputTextMessageContent(
                        "hello"
                    )
                )
            };
            await Bot.AnswerInlineQueryAsync(
                inlineQueryId: inlineQueryEventArgs.InlineQuery.Id,
                results: results,
                isPersonal: true,
                cacheTime: 0
            );
        }

        private static void BotOnChosenInlineResultReceived(object sender, ChosenInlineResultEventArgs chosenInlineResultEventArgs)
        {
            Console.WriteLine($"Received inline result: {chosenInlineResultEventArgs.ChosenInlineResult.ResultId}");
        }

        #endregion

        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("Received error: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message
            );
        }


        public static void Mainlol()
        {
            byte[] inArray = new byte[256];
            byte[] outArray = new byte[256];
            string s2;
            string s3;
            string step1 = "1) The input is a byte array (inArray) of arbitrary data.";
            string step2 = "2) Convert a subarray of the input data array to a base 64 string.";
            string step3 = "3) Convert the entire input data array to a base 64 string.";
            string step4 = "4) The two methods in steps 2 and 3 produce the same result: {0}";
            string step5 = "5) Convert the base 64 string to an output byte array (outArray).";
            string step6 = "6) The input and output arrays, inArray and outArray, are equal: {0}";
            int x;
            string nl = Environment.NewLine;
            string ruler1a = "         1         2         3         4";
            string ruler2a = "1234567890123456789012345678901234567890";
            string ruler3a = "----+----+----+----+----+----+----+----+";
            string ruler1b = "         5         6         7      ";
            string ruler2b = "123456789012345678901234567890123456";
            string ruler3b = "----+----+----+----+----+----+----+-";
            string ruler = String.Concat(ruler1a, ruler1b, nl,
                                           ruler2a, ruler2b, nl,
                                           ruler3a, ruler3b, nl);

            // 1) Display an arbitrary array of input data (inArray). The data could be
            //    derived from user input, a file, an algorithm, etc.

            Console.WriteLine(step1);
            Console.WriteLine();
            for (x = 0; x < inArray.Length; x++)
            {
                inArray[x] = (byte)x;
                Console.Write("{0:X2} ", inArray[x]);
                if (((x + 1) % 20) == 0) Console.WriteLine();
            }
            Console.Write("{0}{0}", nl);

            // 2) Convert a subarray of the input data to a base64 string. In this case,
            //    the subarray is the entire input data array. New lines (CRLF) are inserted.

            Console.WriteLine(step2);
            s2 = Convert.ToBase64String(inArray, 0, inArray.Length,
                                        Base64FormattingOptions.InsertLineBreaks);
            Console.WriteLine("{0}{1}{2}{3}", nl, ruler, s2, nl);

            // 3) Convert the input data to a base64 string. In this case, the entire
            //    input data array is converted by default. New lines (CRLF) are inserted.

            Console.WriteLine(step3);
            s3 = Convert.ToBase64String(inArray, Base64FormattingOptions.InsertLineBreaks);

            // 4) Test whether the methods in steps 2 and 3 produce the same result.
            Console.WriteLine(step4, s2.Equals(s3));

            // 5) Convert the base 64 string to an output array (outArray).
            Console.WriteLine(step5);
            outArray = Convert.FromBase64String(s2);

            // 6) Is outArray equal to inArray?
            Console.WriteLine(step6, ArraysAreEqual(inArray, outArray));
        }

        public static bool ArraysAreEqual(byte[] a1, byte[] a2)
        {
            if (a1.Length != a2.Length) return false;
            for (int i = 0; i < a1.Length; i++)
                if (a1[i] != a2[i]) return false;
            return true;
        }


    public static async void BotOnUpdate(object sender, UpdateEventArgs updateEventArgs)
        {
            try
            {

    
            if (updateEventArgs.Update.Type == UpdateType.ChannelPost)
            {
                string postFile = "";
                string postFileVidio = "";
                string postFileDocument = "";
                    Message post = updateEventArgs.Update.ChannelPost;
                if (post.Type == MessageType.Photo)
                {
                    Types.File photo = await Bot.GetFileAsync(post.Photo.LastOrDefault().FileId );
                    string download_url = $"https://api.telegram.org/file/bot{Configuration.BotToken}/" + photo.FilePath;
                    using (WebClient client = new WebClient())
                    {
                        byte[] photoByte = client.DownloadData(download_url);
                        postFile = Convert.ToBase64String(photoByte, 0, photoByte.Length,
                                        Base64FormattingOptions.InsertLineBreaks);
                            
                           
                    }
                        

                        DiaryPosts diary = new DiaryPosts()
                            {
                                Text = post.Text,
                                Fiile = postFile,
                                DateCreate = DateTime.Now,
                            };
                            db.DiaryPosts.Add(diary);
                            await db.SaveChangesAsync();
                        
                    }
                    
                    else if (post.Type == MessageType.Video)
                {
                    //Фото и видео нужно хранить в байтах
                    Types.File vidio = await Bot.GetFileAsync(post.Video.FileId);
                    string download_url = $"https://api.telegram.org/file/bot{Configuration.BotToken}/" + vidio.FilePath;
                    using (WebClient client = new WebClient())
                    {
                        byte[] vidioByte = client.DownloadData(download_url);
                        postFileVidio = Convert.ToBase64String(vidioByte, 0, vidioByte.Length,
                                        Base64FormattingOptions.InsertLineBreaks);

                      
                        DiaryPosts diary = new DiaryPosts()
                        {
                            Text = post.Text,
                            Fiile = postFileVidio,
                            DateCreate = DateTime.Now,
                        };
                        db.DiaryPosts.Add(diary);
                        await db.SaveChangesAsync();
                    }
                    
                   
                    //Types.File photo = await Bot.GetFileAsync(post.Document.ToString.FileId);
                    //string download_url = $"https://api.telegram.org/file/bot{Configuration.BotToken}/" + photo.FilePath;
                    //string download_url = $"https://api.telegram.org/file/bot{Configuration.BotToken}/" + photo.FilePath;




                }
                else if (post.Type == MessageType.Document)
                {
                    //Фото и видео нужно хранить в байтах
                    Types.File document = await Bot.GetFileAsync(post.Document.FileId);
                        string download_url = $"https://api.telegram.org/file/bot{Configuration.BotToken}/" + document.FilePath;
                        using (WebClient client = new WebClient())
                        {
                            byte[] DocumentByte = client.DownloadData(download_url);


                            DiaryPosts diary = new DiaryPosts()
                            {
                                Text = post.Text,
                                //Fiile = postFileDocument,
                                 = ,
                                DateCreate = DateTime.Now,
                            };
                            db.DiaryPosts.Add(diary);
                            await db.SaveChangesAsync();



                        }












                    }
                else if (post.Type == MessageType.Text)
                {
                    DiaryPosts diary = new DiaryPosts()
                    {
                        Text = post.Text,
                        DateCreate = DateTime.Now,
                    };

                    db.DiaryPosts.Add(diary);
                    await db.SaveChangesAsync();
                }
                

                //TODO: Store channel post
                //записать эти поля в базу:
                //post.MessageId - Id поста
                //post.Text - текст
                //postFile - файл в base64 строке (тип поля в бд nvarchar!)
                //дальше в 100ТЗ выводить надо из БД
            }
            else if (updateEventArgs.Update.Type == UpdateType.EditedChannelPost)
            {
                string postFile = "";
                Message editedPost = updateEventArgs.Update.EditedChannelPost;
                if (editedPost.Type == MessageType.Photo)
                {
                    Types.File photo = await Bot.GetFileAsync(editedPost.Photo.LastOrDefault().FileId);
                    string download_url = $"https://api.telegram.org/file/bot{Configuration.BotToken}/" + photo.FilePath;
                    using (WebClient client = new WebClient())
                    {
                        byte[] photoByte = client.DownloadData(download_url);
                        postFile = Convert.ToBase64String(photoByte, 0, photoByte.Length,
                                        Base64FormattingOptions.InsertLineBreaks);

                    }

                }
                //TODO: Store edited channel post
            }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
