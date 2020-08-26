using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txFindCategory
    {
        public long Id { get; set; }
        public long SpecId { get; set; }
        public long LineId { get; set; }
        public int CategoryId { get; set; }
        public bool? IsChecked { get; set; }

        public virtual CatalogCategories Category { get; set; }
        public virtual AleksDaspecsMaintbl Spec { get; set; }
    }
}
