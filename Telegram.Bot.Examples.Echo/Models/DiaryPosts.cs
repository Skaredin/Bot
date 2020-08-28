using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo.Models
{
    public partial class DiaryPosts
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Fiile { get; set; }
        public DateTime? DateCreate { get; set; }
        public byte[] Filedata { get; set; }
        public string Video { get; set; }
    }
}
