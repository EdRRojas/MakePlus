
using MakePlus.Core;

namespace MakePlus.Entities
{
    public class Custumers : BaseEntity
    {
        public int ID_Custumer { get; set; }
        public string name_Custumer { get; set; }
        public string email {  get; set; }
        public string phone { get; set; }
        public string? street { get; set; }
        public string? sector { get; set; }
        public string? city { get; set; }
        public string? provincia { get; set; }
        public int? zip {  get; set; }
        public string? payment_method { get; set; }
    }
}
