using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksDaspecsMaintbl
    {
        public AleksDaspecsMaintbl()
        {
            _100txFindCategory = new HashSet<_100txFindCategory>();
        }

        public long Id { get; set; }
        public int Parent { get; set; }
        public string UniqTitle { get; set; }
        public string RealTitle { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string BottomDescription { get; set; }
        public string LegalCompany { get; set; }
        public byte IsExport { get; set; }
        public int Date { get; set; }
        public int UserId { get; set; }
        public int Chked { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public string SerialSession { get; set; }
        public int ShopDate { get; set; }
        public int Delivery { get; set; }
        public int? CustomerBid { get; set; }
        public string CustomerInn { get; set; }
        public string CustomerName { get; set; }
        public string DeployObject { get; set; }
        public int? DealBid { get; set; }
        public string DealName { get; set; }
        public string HeadMail { get; set; }
        public string MrkMail { get; set; }
        public string SellerMail { get; set; }
        public string CustomerContacts { get; set; }
        public byte Deleted { get; set; }
        public byte IsPublic { get; set; }
        public byte IsCart { get; set; }
        public byte IsOpenedToProvider { get; set; }
        public string User { get; set; }

        public virtual AspNetUsers UserNavigation { get; set; }
        public virtual ICollection<_100txFindCategory> _100txFindCategory { get; set; }
    }
}
