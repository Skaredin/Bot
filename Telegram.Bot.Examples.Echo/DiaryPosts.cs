using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class DiaryPosts
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Fiile { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserId { get; set; }
        public long? AccauntsId { get; set; }
        public virtual Accounts Accaunts { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
